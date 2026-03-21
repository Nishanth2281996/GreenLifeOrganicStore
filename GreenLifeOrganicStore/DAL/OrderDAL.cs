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
            O.Order_Status_id,
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

        // Get orders for a specific customer
        public DataTable GetCustomerOrders(int customerId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
        SELECT 
            O.Order_id,
            O.Order_Date,
            O.Quantity,
            O.SubTotal,
            O.GrandTotal,
            OS.Status_Name
        FROM Orders O
        INNER JOIN OrderStatus OS 
            ON O.Order_Status_id = OS.Order_Status_id
        WHERE O.Customer_id = @CustomerId
        ORDER BY O.Order_Date DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        // Get full details for one selected order
        public DataTable GetOrderDetails(int orderId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
        SELECT 
            O.Order_id,
            O.Order_Date,
            O.Quantity,
            O.SubTotal,
            O.GrandTotal,
            O.C_FullName,
            O.C_Phone,
            O.C_City,
            O.C_Address,
            OS.Status_Name,
            PM.Payment_Method,
            PS.Payment_Status_Name,
            P.Payment_Date
        FROM Orders O
        INNER JOIN OrderStatus OS
            ON O.Order_Status_id = OS.Order_Status_id
        LEFT JOIN Payment P
            ON O.Order_id = P.Order_id
        LEFT JOIN Payment_Method PM
            ON P.Payment_Method_id = PM.Payment_Method_id
        LEFT JOIN PaymentStatus PS
            ON P.Payment_Status_id = PS.Payment_Status_id
        WHERE O.Order_id = @OrderId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    return table;
                }
            }
        }

        // Get full details for one selected customer order
        public DataTable GetCustomerOrderDetails(int orderId, int customerId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                // Load order, customer, status, and payment details
                string query = @"
            SELECT 
                O.Order_id,
                O.Customer_id,
                O.Order_Date,
                O.Quantity,
                O.SubTotal,
                O.GrandTotal,
                O.C_FullName,
                O.C_Phone,
                O.C_City,
                O.C_Address,
                U.U_Email,
                OS.Status_Name,
                PM.Payment_Method,
                PS.Payment_Status_Name,
                P.Payment_Date
            FROM Orders O
            INNER JOIN Users U
                ON O.Customer_id = U.Users_id
            INNER JOIN OrderStatus OS
                ON O.Order_Status_id = OS.Order_Status_id
            LEFT JOIN Payment P
                ON O.Order_id = P.Order_id
            LEFT JOIN Payment_Method PM
                ON P.Payment_Method_id = PM.Payment_Method_id
            LEFT JOIN PaymentStatus PS
                ON P.Payment_Status_id = PS.Payment_Status_id
            WHERE O.Order_id = @OrderId
              AND O.Customer_id = @CustomerId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Pass selected order id
                    cmd.Parameters.AddWithValue("@OrderId", orderId);

                    // Pass logged-in customer id
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Store result in DataTable
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        // Load orders for the logged-in customer
        public DataTable GetOrdersByCustomer(int customerId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT 
                                    o.Order_id,
                                    o.Order_Date,
                                    os.Status_Name,
                                    o.SubTotal,
                                    o.GrandTotal,
                                    o.Quantity
                                 FROM Orders o
                                 INNER JOIN OrderStatus os ON o.Order_Status_id = os.Order_Status_id
                                 WHERE o.Customer_id = @Customer_id
                                 ORDER BY o.Order_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Safe parameter value
                    cmd.Parameters.AddWithValue("@Customer_id", customerId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public bool UpdateOrderStatus(int orderId, int orderStatusId)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "UPDATE Orders SET Order_Status_id = @OrderStatusId WHERE Order_id = @OrderId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameter values safely
                    cmd.Parameters.AddWithValue("@OrderStatusId", orderStatusId);
                    cmd.Parameters.AddWithValue("@OrderId", orderId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
    }
}
