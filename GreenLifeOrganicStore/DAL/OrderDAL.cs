using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.DAL
{
    public class OrderDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();

        public DataTable GetAllOrders()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                SELECT 
                    O.Order_id,
                    O.C_FullName,
                    O.Order_Date,
                    O.Quantity,
                    O.SubTotal,
                    O.GrandTotal,
                    OS.Status_Name
                FROM Orders O
                INNER JOIN OrderStatus OS 
                    ON O.Order_Status_id = OS.Order_Status_id
                ORDER BY O.Order_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        // Load all order statuses for ComboBox
        public DataTable GetOrderStatuses()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT Order_Status_id, Status_Name FROM OrderStatus ORDER BY Status_Name ASC";

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

        // Search orders by order id, customer name, phone, city, or status
        public DataTable SearchOrders(string keyword)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        O.Order_id,
                        O.C_FullName,
                        O.Order_Date,
                        O.Quantity,
                        O.SubTotal,
                        O.GrandTotal,
                        O.Order_Status_id,
                        OS.Status_Name
                    FROM Orders O
                    INNER JOIN OrderStatus OS 
                        ON O.Order_Status_id = OS.Order_Status_id
                    WHERE 
                        CAST(O.Order_id AS NVARCHAR) LIKE @Keyword OR
                        O.C_FullName LIKE @Keyword OR
                        O.C_Phone LIKE @Keyword OR
                        O.C_City LIKE @Keyword OR
                        OS.Status_Name LIKE @Keyword
                    ORDER BY O.Order_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add search keyword with wildcard
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


        // Filter orders by selected status
        public DataTable FilterOrdersByStatus(int orderStatusId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        O.Order_id,
                        O.C_FullName,
                        O.Order_Date,
                        O.Quantity,
                        O.SubTotal,
                        O.GrandTotal,
                        O.Order_Status_id,
                        OS.Status_Name
                    FROM Orders O
                    INNER JOIN OrderStatus OS 
                        ON O.Order_Status_id = OS.Order_Status_id
                    WHERE O.Order_Status_id = @OrderStatusId
                    ORDER BY O.Order_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Pass selected order status id
                    cmd.Parameters.AddWithValue("@OrderStatusId", orderStatusId);

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
