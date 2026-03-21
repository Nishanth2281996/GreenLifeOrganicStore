using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.DAL
{
    public class ReviewDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();

        // Save a new product review
        public bool InsertReview(int customerId, int productId, int rating, string comment)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                // Insert review into Reviews table
                string query = @"
                    INSERT INTO Reviews (Customer_id, Product_id, Rating, Comment)
                    VALUES (@CustomerId, @ProductId, @Rating, @Comment)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Pass customer id
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);

                    // Pass product id
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    // Pass rating value
                    cmd.Parameters.AddWithValue("@Rating", rating);

                    // Pass comment text
                    cmd.Parameters.AddWithValue("@Comment", comment);

                    // Open database connection
                    conn.Open();

                    // Run insert query
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
