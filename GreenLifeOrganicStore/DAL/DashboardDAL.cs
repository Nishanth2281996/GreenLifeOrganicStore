using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Get low stock products for chart
        public DataTable GetLowStockChartData()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT Product_Name, Stock_Qty
                    FROM Products
                    WHERE Stock_Qty <= @StockLimit
                    ORDER BY Stock_Qty ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StockLimit", 7); // Low stock limit

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        // Get pending orders for chart
        public DataTable GetPendingOrdersChartData()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT TOP 6 O.Order_id, O.GrandTotal
                    FROM Orders O
                    INNER JOIN OrderStatus OS 
                        ON O.Order_Status_id = OS.Order_Status_id
                    WHERE OS.Status_Name = @StatusName
                    ORDER BY O.Order_Date DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StatusName", "Pending"); // Pending only

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        // Get newest customers for chart
        public DataTable GetNewCustomersChartData()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT TOP 6 Full_Name
                    FROM Users
                    WHERE Role_id = @RoleId
                    ORDER BY CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoleId", 2); // Customer role

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        // Get review count grouped by rating
        public DataTable GetFeedbackChartData()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT Rating, COUNT(*) AS TotalReviews
                    FROM Reviews
                    GROUP BY Rating
                    ORDER BY Rating";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}

