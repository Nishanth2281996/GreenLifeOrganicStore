using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GreenLifeOrganicStore.DAL
{
    public class CartDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();
        public bool IsProductAlreadyInCart(int userId, int productId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT COUNT(*)
                                 FROM Cart
                                 WHERE Users_id = @Users_id
                                   AND Product_id = @Product_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter values
                    cmd.Parameters.AddWithValue("@Users_id", userId);
                    cmd.Parameters.AddWithValue("@Product_id", productId);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        // Insert a new product into cart
        public bool AddToCart(int userId, int productId, int quantity, decimal unitPrice)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"INSERT INTO Cart (Quantity, Unit_Price, Users_id, Product_id)
                                 VALUES (@Quantity, @Unit_Price, @Users_id, @Product_id)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter values
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Unit_Price", unitPrice);
                    cmd.Parameters.AddWithValue("@Users_id", userId);
                    cmd.Parameters.AddWithValue("@Product_id", productId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Increase quantity if product already exists in cart
        public bool IncreaseCartQuantity(int userId, int productId, int quantityToAdd)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"UPDATE Cart
                                 SET Quantity = Quantity + @QuantityToAdd
                                 WHERE Users_id = @Users_id
                                   AND Product_id = @Product_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter values
                    cmd.Parameters.AddWithValue("@QuantityToAdd", quantityToAdd);
                    cmd.Parameters.AddWithValue("@Users_id", userId);
                    cmd.Parameters.AddWithValue("@Product_id", productId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Get current stock quantity for selected product
        public int GetProductStock(int productId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Stock_Qty
                                 FROM Products
                                 WHERE Product_id = @Product_id
                                   AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Product_id", productId);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }

                    return 0;
                }
            }
        }

        // Get final product price after discount
        public decimal GetProductFinalPrice(int productId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Unit_Price, Discount_Percent
                                 FROM Products
                                 WHERE Product_id = @Product_id
                                   AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Product_id", productId);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal unitPrice = Convert.ToDecimal(reader["Unit_Price"]);
                            decimal discountPercent = Convert.ToDecimal(reader["Discount_Percent"]);

                            decimal finalPrice = unitPrice - (unitPrice * discountPercent / 100);
                            return finalPrice;
                        }
                    }
                }
            }

            return 0;
        }

        // Get current quantity of this product already in the user's cart
        public int GetCartQuantity(int userId, int productId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT ISNULL(Quantity, 0)
                         FROM Cart
                         WHERE Users_id = @Users_id
                           AND Product_id = @Product_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter values
                    cmd.Parameters.AddWithValue("@Users_id", userId);
                    cmd.Parameters.AddWithValue("@Product_id", productId);

                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }

                    return 0;
                }
            }
        }

        // Load all cart rows for one customer
        public DataTable GetCartItemsByUser(int userId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT 
                            c.Cart_id,
                            c.Product_id,
                            p.Product_Name,
                            c.Unit_Price,
                            c.Quantity,
                            (c.Unit_Price * c.Quantity) AS Subtotal
                         FROM Cart c
                         INNER JOIN Products p ON c.Product_id = p.Product_id
                         WHERE c.Users_id = @Users_id
                         ORDER BY c.Cart_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter value
                    cmd.Parameters.AddWithValue("@Users_id", userId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        // Remove one cart row
        public bool RemoveCartItem(int cartId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"DELETE FROM Cart
                         WHERE Cart_id = @Cart_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter value
                    cmd.Parameters.AddWithValue("@Cart_id", cartId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Update quantity of a cart row
        public bool UpdateCartQuantity(int cartId, int quantity)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"UPDATE Cart
                         SET Quantity = @Quantity
                         WHERE Cart_id = @Cart_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter values
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Cart_id", cartId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Load payment methods into ComboBox
        public DataTable GetPaymentMethods()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Payment_Method_id, Payment_Method
                         FROM Payment_Method
                         ORDER BY Payment_Method";

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

        // Get product id from cart row
        public int GetProductIdByCartId(int cartId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Product_id
                         FROM Cart
                         WHERE Cart_id = @Cart_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter value
                    cmd.Parameters.AddWithValue("@Cart_id", cartId);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }

                    return 0;
                }
            }
        }
    }
}
