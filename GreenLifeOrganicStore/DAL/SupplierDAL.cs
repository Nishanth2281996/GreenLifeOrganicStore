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
    public class SupplierDAL
    {
        // DbHelper object to access the database connection
        private readonly DbHelper dbHelper = new DbHelper();

        // Load all active suppliers
        public DataTable GetAllSuppliers()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Supplier_id, Supplier_Name, S_Email, S_Phone, S_Address
                                 FROM Supplier
                                 WHERE IsActive = 1
                                 ORDER BY Supplier_id DESC";

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

        // Insert a new supplier
        public bool InsertSupplier(Supplier supplier)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"INSERT INTO Supplier
                                 (Supplier_Name, S_Email, S_Phone, S_Address, CreatedAt, IsActive)
                                 VALUES
                                 (@Supplier_Name, @S_Email, @S_Phone, @S_Address, GETDATE(), 1)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add values safely using parameters
                    cmd.Parameters.AddWithValue("@Supplier_Name", supplier.Supplier_Name);
                    cmd.Parameters.AddWithValue("@S_Email", supplier.S_Email);
                    cmd.Parameters.AddWithValue("@S_Phone", supplier.S_Phone);
                    cmd.Parameters.AddWithValue("@S_Address", supplier.S_Address);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Update an existing supplier
        public bool UpdateSupplier(Supplier supplier)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"UPDATE Supplier
                                 SET Supplier_Name = @Supplier_Name,
                                     S_Email = @S_Email,
                                     S_Phone = @S_Phone,
                                     S_Address = @S_Address
                                 WHERE Supplier_id = @Supplier_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add values safely using parameters
                    cmd.Parameters.AddWithValue("@Supplier_id", supplier.Supplier_id);
                    cmd.Parameters.AddWithValue("@Supplier_Name", supplier.Supplier_Name);
                    cmd.Parameters.AddWithValue("@S_Email", supplier.S_Email);
                    cmd.Parameters.AddWithValue("@S_Phone", supplier.S_Phone);
                    cmd.Parameters.AddWithValue("@S_Address", supplier.S_Address);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Soft delete supplier by changing IsActive to 0
        public bool DeleteSupplier(int supplierId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"UPDATE Supplier
                                 SET IsActive = 0
                                 WHERE Supplier_id = @Supplier_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add supplier id safely using parameter
                    cmd.Parameters.AddWithValue("@Supplier_id", supplierId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Search suppliers by name, email, or phone
        public DataTable SearchSuppliers(string keyword)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Supplier_id, Supplier_Name, S_Email, S_Phone, S_Address
                                 FROM Supplier
                                 WHERE IsActive = 1
                                 AND (
                                        Supplier_Name LIKE @Keyword
                                     OR S_Email LIKE @Keyword
                                     OR S_Phone LIKE @Keyword
                                 )
                                 ORDER BY Supplier_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add search text safely using parameter
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

        // Check whether supplier email already exists
        public bool SupplierEmailExists(string email, int supplierId = 0)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT COUNT(*)
                                 FROM Supplier
                                 WHERE S_Email = @Email
                                 AND Supplier_id <> @Supplier_id
                                 AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Supplier_id", supplierId);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}

