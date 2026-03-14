using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.DAL
{
    public class PaymentDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();

        public DataTable GetAllPayments()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        P.Payment_id,
                        P.Order_id,
                        O.C_FullName,
                        P.Payment_Amount,
                        P.Payment_Date,
                        PM.Payment_Method,
                        PS.Payment_Status_Name
                    FROM Payment P
                    INNER JOIN Orders O ON P.Order_id = O.Order_id
                    INNER JOIN Payment_Method PM ON P.Payment_Method_id = PM.Payment_Method_id
                    INNER JOIN PaymentStatus PS ON P.Payment_Status_id = PS.Payment_Status_id
                    ORDER BY P.Payment_id DESC";

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



        // Search payments by payment id, order id, customer name, method, or status
        public DataTable SearchPayments(string keyword)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT 
                        P.Payment_id,
                        P.Order_id,
                        O.C_FullName,
                        P.Payment_Amount,
                        P.Payment_Date,
                        PM.Payment_Method,
                        PS.Payment_Status_Name
                    FROM Payment P
                    INNER JOIN Orders O ON P.Order_id = O.Order_id
                    INNER JOIN Payment_Method PM ON P.Payment_Method_id = PM.Payment_Method_id
                    INNER JOIN PaymentStatus PS ON P.Payment_Status_id = PS.Payment_Status_id
                    WHERE 
                        CAST(P.Payment_id AS NVARCHAR) LIKE @Keyword OR
                        CAST(P.Order_id AS NVARCHAR) LIKE @Keyword OR
                        O.C_FullName LIKE @Keyword OR
                        PM.Payment_Method LIKE @Keyword OR
                        PS.Payment_Status_Name LIKE @Keyword
                    ORDER BY P.Payment_id DESC";

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

        // Get total number of payments
        public int GetTotalPayments()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Payment";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Get total amount of completed payments
        // IMPORTANT:
        // This query assumes Payment_Status_Name = 'Completed'
        public decimal GetCompletedAmount()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
                    SELECT ISNULL(SUM(P.Payment_Amount), 0)
                    FROM Payment P
                    INNER JOIN PaymentStatus PS ON P.Payment_Status_id = PS.Payment_Status_id
                    WHERE PS.Payment_Status_Name = @StatusName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use parameterized query for safety
                    cmd.Parameters.AddWithValue("@StatusName", "Completed");

                    conn.Open();
                    return  ConvertToDecimal(cmd.ExecuteScalar());
                }
            }
        }



        // Helper method to safely convert SQL result to decimal
        private decimal ConvertToDecimal(object value)
        {
            if (value == null || value == System.DBNull.Value)
            {
                return 0;
            }

            return System.Convert.ToDecimal(value);
        }

    }
}
