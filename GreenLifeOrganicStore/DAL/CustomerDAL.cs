using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.DAL
{
    public class CustomerDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();

        public DataTable GetAllCustomers()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Users_id, Full_Name, U_Email, U_Phone, U_Address, U_City, CreatedAt
                                 FROM Users
                                 WHERE Role_id = @RoleId
                                 ORDER BY Users_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Role_id = 2 means Customer
                    cmd.Parameters.AddWithValue("@RoleId", 2);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }


        // Search customers by name, email, phone, city, or address
        public DataTable SearchCustomers(string keyword)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT Users_id, Full_Name, U_Email, U_Phone, U_Address, U_City, CreatedAt
                                 FROM Users
                                 WHERE Role_id = @RoleId AND
                                      (Full_Name LIKE @Keyword OR
                                       U_Email LIKE @Keyword OR
                                       U_Phone LIKE @Keyword OR
                                       U_Address LIKE @Keyword OR
                                       U_City LIKE @Keyword)
                                 ORDER BY Users_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Only search customer accounts
                    cmd.Parameters.AddWithValue("@RoleId", 2);

                    // Search text with LIKE
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
    }
}
