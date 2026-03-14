using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace GreenLifeOrganicStore.DAL
{
    public class CategoryDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();

        //Get all Categories from Data tables
        public DataTable GetAllCategories()
        {
            using(SqlConnection conn = dbHelper.GetConnection())
            {
                //Select category id and name 
                string query = "SELECT Category_id , Category_Name FROM Category";

                SqlDataAdapter adapter = new SqlDataAdapter(query , conn);

                //Datatable to store reterived data 
                DataTable table = new DataTable();

                //Fill Datatable with query results 
                adapter.Fill(table);

                return table;
            }
        }

        //Insert New Category into database 
        public void InsertCategory(string categoryName)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                //SQL query to insert category name 
                string query = "INSERT INTO Category (Category_Name) VALUES (@Name)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", categoryName);  

                conn.Open();

                //Excute insert command
                cmd.ExecuteNonQuery();
            }
        }

        //Update Existing Category 
        public void UpdateCategory(int categoryId, string categoryName)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                //Update Category 
                string query = "UPDATE Category SET Category_Name = @Name WHERE Category_id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                //Add New Name to Category 
                cmd.Parameters.AddWithValue("@Name", categoryName);

                //Add Category Id Parameter 
                cmd.Parameters.AddWithValue("@Id", categoryId);

                conn.Open();
                cmd.ExecuteNonQuery();

            }
        }

            //Delete Category From Database 
            public void DeleteCategory(int categoryId)
            {
                using (SqlConnection conn = dbHelper.GetConnection())
                {
                    string query = "DELETE FROM Category WHERE Category_id = @Id ";

                    SqlCommand cmd = new SqlCommand(query , conn);

                    cmd.Parameters.AddWithValue("@Id", categoryId);

                    conn.Open() ;

                    cmd.ExecuteNonQuery();
                }
            }

        public DataTable SearchCategories(string keyword)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                //Search Category by Name 
                string query = "SELECT Category_id, Category_Name FROM Category WHERE Category_Name LIKE @Keyword";


                SqlCommand cmd = new SqlCommand(query, conn);

                //Add Search parameter with % for partial matching 
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }
    }
    }

