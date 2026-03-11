using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GreenLifeOrganicStore.DAL
{
    public class DbHelper
    {
        private readonly string connectionString =
            @"Server=NISHANTH\SQLEXPRESS;Database=GreenLifeOrganicStoreDB;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public string TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return "Database connection successful.";
                }
            }
            catch (Exception ex)
            {
                return "Database connection failed: " + ex.Message;
            }
        }
    }
}
