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
        //Connection String used to connect the database 
        private readonly string connectionString = 
            @"Server=NISHANTH\SQLEXPRESS;Database=GreenLifeOrganicStoreDB;Integrated Security=True;";


        //Create and return SQL Connection 
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        //Test Database Connection 
        public string TestConnection()
        {
            try
            {
                //Create Connection 
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return "Database connection successful."; //Success Message 
                }
            }
            catch (Exception ex)
            {
                return "Database connection failed: " + ex.Message ; //Error Message 
            }
        }
    }
}
