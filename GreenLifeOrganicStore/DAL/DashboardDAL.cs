using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GreenLifeOrganicStore.DAL
{
    public class DashboardDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();

        //Get Total Customers 
        public int GetTotalCustomers()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Role_id =@RoleId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoleId", 2);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        //Get total Products
        public int GetTotalProducts()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {

                string query = "SELECT COUNT(*) FROM Products";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                return (int)cmd.ExecuteScalar();

            }

        }

        //Get Total Orders
        public int GetTotalOrders()
        {
            using(SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Orders";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                return (int)cmd.ExecuteScalar();
            }
        }

        //Get Total Revenue 
        public decimal GetTotalRevenue()
        {
            using(SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT ISNULL(SUM(GrandTotal) , 0) FROM Orders ";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
    }
}
