using GreenLifeOrganicStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.DAL
{
    public class ProductDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();

        // Load all active products with category and supplier names
        public DataTable GetAllProducts()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT 
                                    p.Product_id,
                                    p.Product_Name,
                                    c.Category_Name,
                                    s.Supplier_Name,
                                    p.Unit_Price,
                                    p.Stock_Qty,
                                    p.Product_Image_Path,
                                    p.Discount_Percent
                                 FROM Products p
                                 INNER JOIN Category c ON p.Category_id = c.Category_id
                                 LEFT JOIN SupplierProduct sp ON p.Product_id = sp.Product_id
                                 LEFT JOIN Supplier s ON sp.Supplier_id = s.Supplier_id
                                 WHERE p.IsActive = 1
                                 ORDER BY p.Product_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public DataTable GetCategoriesForCombo()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Category_id, Category_Name
                                 FROM Category
                                 ORDER BY Category_Name";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        // Load active suppliers into ComboBox
        public DataTable GetSuppliersForCombo()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Supplier_id, Supplier_Name
                                 FROM Supplier
                                 WHERE IsActive = 1
                                 ORDER BY Supplier_Name";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        // Insert product and supplier link using transaction
        public bool InsertProduct(Product product, int supplierId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string productQuery = @"INSERT INTO Products
                                            (Category_id, Product_Name, Product_Image_Path, Stock_Qty, Unit_Price, Discount_Percent, IsActive, CreatedAt)
                                            VALUES
                                            (@Category_id, @Product_Name, @Product_Image_Path, @Stock_Qty, @Unit_Price, @Discount_Percent, 1, GETDATE());
                                            SELECT SCOPE_IDENTITY();";

                    int productId;

                    using (SqlCommand cmd = new SqlCommand(productQuery, conn, transaction))
                    {
                        // Add product values safely using parameters
                        cmd.Parameters.AddWithValue("@Category_id", product.Category_id);
                        cmd.Parameters.AddWithValue("@Product_Name", product.Product_Name);
                        cmd.Parameters.AddWithValue("@Product_Image_Path", product.Product_Image_Path);
                        cmd.Parameters.AddWithValue("@Stock_Qty", product.Stock_Qty);
                        cmd.Parameters.AddWithValue("@Unit_Price", product.Unit_Price);
                        cmd.Parameters.AddWithValue("@Discount_Percent", product.Discount_Percent);

                        productId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string supplierProductQuery = @"INSERT INTO SupplierProduct (Supplier_id, Product_id)
                                                    VALUES (@Supplier_id, @Product_id)";

                    using (SqlCommand cmd = new SqlCommand(supplierProductQuery, conn, transaction))
                    {
                        // Save supplier-product link
                        cmd.Parameters.AddWithValue("@Supplier_id", supplierId);
                        cmd.Parameters.AddWithValue("@Product_id", productId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        // Update product and supplier link using transaction
        public bool UpdateProduct(Product product, int supplierId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string productQuery = @"UPDATE Products
                                            SET Category_id = @Category_id,
                                                Product_Name = @Product_Name,
                                                Product_Image_Path = @Product_Image_Path,
                                                Stock_Qty = @Stock_Qty,
                                                Unit_Price = @Unit_Price,
                                                Discount_Percent = @Discount_Percent
                                            WHERE Product_id = @Product_id";

                    using (SqlCommand cmd = new SqlCommand(productQuery, conn, transaction))
                    {
                        // Update product values
                        cmd.Parameters.AddWithValue("@Product_id", product.Product_id);
                        cmd.Parameters.AddWithValue("@Category_id", product.Category_id);
                        cmd.Parameters.AddWithValue("@Product_Name", product.Product_Name);
                        cmd.Parameters.AddWithValue("@Product_Image_Path", product.Product_Image_Path);
                        cmd.Parameters.AddWithValue("@Stock_Qty", product.Stock_Qty);
                        cmd.Parameters.AddWithValue("@Unit_Price", product.Unit_Price);
                        cmd.Parameters.AddWithValue("@Discount_Percent", product.Discount_Percent);

                        cmd.ExecuteNonQuery();
                    }

                    string deleteLinkQuery = @"DELETE FROM SupplierProduct
                                               WHERE Product_id = @Product_id";

                    using (SqlCommand cmd = new SqlCommand(deleteLinkQuery, conn, transaction))
                    {
                        // Remove old supplier link
                        cmd.Parameters.AddWithValue("@Product_id", product.Product_id);
                        cmd.ExecuteNonQuery();
                    }

                    string newLinkQuery = @"INSERT INTO SupplierProduct (Supplier_id, Product_id)
                                            VALUES (@Supplier_id, @Product_id)";

                    using (SqlCommand cmd = new SqlCommand(newLinkQuery, conn, transaction))
                    {
                        // Save new supplier link
                        cmd.Parameters.AddWithValue("@Supplier_id", supplierId);
                        cmd.Parameters.AddWithValue("@Product_id", product.Product_id);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Soft delete product
        public bool DeleteProduct(int productId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"UPDATE Products
                                 SET IsActive = 0
                                 WHERE Product_id = @Product_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Product_id", productId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Search products
        public DataTable SearchProducts(string keyword)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT 
                                    p.Product_id,
                                    p.Product_Name,
                                    c.Category_Name,
                                    s.Supplier_Name,
                                    p.Unit_Price,
                                    p.Stock_Qty,
                                    p.Product_Image_Path,
                                    p.Discount_Percent
                                 FROM Products p
                                 INNER JOIN Category c ON p.Category_id = c.Category_id
                                 LEFT JOIN SupplierProduct sp ON p.Product_id = sp.Product_id
                                 LEFT JOIN Supplier s ON sp.Supplier_id = s.Supplier_id
                                 WHERE p.IsActive = 1
                                   AND (
                                        p.Product_Name LIKE @Keyword
                                        OR c.Category_Name LIKE @Keyword
                                        OR s.Supplier_Name LIKE @Keyword
                                   )
                                 ORDER BY p.Product_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }





        // Load all active products for customer side ////////////////////////////////////////////////////////////
        // Load categories for ComboBox
        // Load customer products with optional category and search filters
        public DataTable GetFilteredProductsForCustomer(int categoryId, string keyword)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT 
                                    p.Product_id,
                                    p.Product_Name,
                                    p.Product_Image_Path,
                                    p.Stock_Qty,
                                    p.Unit_Price,
                                    p.Discount_Percent,
                                    c.Category_Name,
                                    c.Category_id,
                                    ISNULL(AVG(CAST(r.Rating AS DECIMAL(10,2))), 0) AS AvgRating,
                                    COUNT(r.Review_id) AS ReviewCount
                                 FROM Products p
                                 INNER JOIN Category c ON p.Category_id = c.Category_id
                                 LEFT JOIN Reviews r ON p.Product_id = r.Product_id
                                 WHERE p.IsActive = 1";

                // Add category filter only if selected category is not All
                if (categoryId > 0)
                {
                    query += " AND p.Category_id = @Category_id";
                }

                // Add search filter only if keyword is entered
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query += " AND p.Product_Name LIKE @Keyword";
                }

                query += @" GROUP BY 
                                p.Product_id,
                                p.Product_Name,
                                p.Product_Image_Path,
                                p.Stock_Qty,
                                p.Unit_Price,
                                p.Discount_Percent,
                                c.Category_Name,
                                c.Category_id
                            ORDER BY p.Product_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add category parameter when needed
                    if (categoryId > 0)
                    {
                        cmd.Parameters.AddWithValue("@Category_id", categoryId);
                    }

                    // Add search parameter when needed
                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }


    }
}
