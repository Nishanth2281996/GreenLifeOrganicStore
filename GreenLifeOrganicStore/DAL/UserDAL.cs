using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenLifeOrganicStore.Models;
using System.Data.SqlClient;

namespace GreenLifeOrganicStore.DAL
{
    public class UserDAL
    {
        private readonly DbHelper dbHelper = new DbHelper();

        //Get information using email
        public User GetUserByEmail(string email)
        {
            User user = null; 

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                //SQL Query to get User Email
                string query = @"SELECT Users_id, Full_Name, U_Email, U_Phone, U_Address, U_City,
                                        Password_Hash, Password_Salt, ProfileImagePath, CreatedAt, Role_id
                                 FROM Users
                                 WHERE U_Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email); //Pass Email Value to Query 

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                Users_id = Convert.ToInt32(reader["Users_id"]),
                                Full_Name = reader["Full_Name"].ToString(),
                                U_Email = reader["U_Email"].ToString(),
                                U_Phone = reader["U_Phone"].ToString(),
                                U_Address = reader["U_Address"].ToString(),
                                U_City = reader["U_City"].ToString(),
                                Password_Hash = (byte[])reader["Password_Hash"],
                                Password_Salt = (byte[])reader["Password_Salt"],
                                ProfileImagePath = reader["ProfileImagePath"] == DBNull.Value ? null : reader["ProfileImagePath"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                Role_id = Convert.ToInt32(reader["Role_id"])
                            };
                        }
                    }
                }
            }

            return user; //Return User Object 
        }

        public bool EmailExists(string email)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE U_Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    conn.Open();

                    int count = (int)cmd.ExecuteScalar();//Execute Query to get Single value 
                    return count > 0;
                }
            }
        }

        //Insert New User to the table 
        public int InsertUser(User user)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {

                //SQL Query to insert New User 
                string query = @"INSERT INTO Users
                                (Full_Name, U_Email, U_Phone, U_Address, U_City, Password_Hash, Password_Salt, ProfileImagePath, Role_id)
                                VALUES
                                (@Full_Name, @U_Email, @U_Phone, @U_Address, @U_City, @Password_Hash, @Password_Salt, @ProfileImagePath, @Role_id)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    //Send User detail to SQL Parameter 
                    cmd.Parameters.AddWithValue("@Full_Name", user.Full_Name);
                    cmd.Parameters.AddWithValue("@U_Email", user.U_Email);
                    cmd.Parameters.AddWithValue("@U_Phone", user.U_Phone);
                    cmd.Parameters.AddWithValue("@U_Address", user.U_Address);
                    cmd.Parameters.AddWithValue("@U_City", user.U_City);
                    cmd.Parameters.AddWithValue("@Password_Hash", user.Password_Hash);
                    cmd.Parameters.AddWithValue("@Password_Salt", user.Password_Salt);

                    if (string.IsNullOrEmpty(user.ProfileImagePath))
                    {
                        cmd.Parameters.AddWithValue("@ProfileImagePath", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ProfileImagePath", user.ProfileImagePath);
                    }

                    cmd.Parameters.AddWithValue("@Role_id", user.Role_id);//Store Role id 

                    conn.Open();

                    return cmd.ExecuteNonQuery(); //Excecute insert query and return rows affected
                }
            }
        }



       public bool AdminExists()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                //Count How many users have admin role
                string query = "SELECT COUNT(*) FROM Users WHERE Role_id = @Role_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Role_id", 1);

                    conn.Open();

                    //Return true if at least one admin exists, otherwise false
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public int UpdatePassword(string email, byte[] passwordHash, byte[] passwordSalt)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {

                //Update user's password hash and salt using their email 
                string query = @"UPDATE Users SET Password_Hash = @PasswordHash,
                                                  Password_Salt = @PasswordSalt
                                                  WHERE U_Email = @Email";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@PasswordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("@Email", email);

                    conn.Open();

                    return cmd.ExecuteNonQuery();


                }

            }

        }


        public User GetUserById(int userId)
        {
            User user = null;

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"SELECT * FROM Users WHERE Users_id = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                Users_id = Convert.ToInt32(reader["Users_id"]),
                                Full_Name = reader["Full_Name"].ToString(),
                                U_Email = reader["U_Email"].ToString(),
                                U_Phone = reader["U_Phone"].ToString(),
                                U_Address = reader["U_Address"].ToString(),
                                U_City = reader["U_City"].ToString(),
                                ProfileImagePath = reader["ProfileImagePath"] == DBNull.Value ? null : reader["ProfileImagePath"].ToString()
                            };
                        }
                    }
                }
            }

            return user;
        }

        public bool UpdateUserProfile(User user)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
        UPDATE Users
        SET Full_Name = @Full_Name,
            U_Email = @U_Email,
            U_Phone = @U_Phone,
            U_Address = @U_Address,
            U_City = @U_City,
            ProfileImagePath = @ProfileImagePath
        WHERE Users_id = @Users_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Full_Name", user.Full_Name);
                    cmd.Parameters.AddWithValue("@U_Email", user.U_Email);
                    cmd.Parameters.AddWithValue("@U_Phone", user.U_Phone);
                    cmd.Parameters.AddWithValue("@U_Address", user.U_Address);
                    cmd.Parameters.AddWithValue("@U_City", user.U_City);

                    if (string.IsNullOrEmpty(user.ProfileImagePath))
                        cmd.Parameters.AddWithValue("@ProfileImagePath", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@ProfileImagePath", user.ProfileImagePath);

                    cmd.Parameters.AddWithValue("@Users_id", user.Users_id);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
    }



