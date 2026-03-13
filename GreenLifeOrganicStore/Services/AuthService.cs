using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreenLifeOrganicStore.DAL;
using GreenLifeOrganicStore.Models;

namespace GreenLifeOrganicStore.Services
{
    public class AuthService
    {
        private readonly UserDAL userDAL = new UserDAL();
        private readonly PasswordHelper passwordHelper = new PasswordHelper();


        //Check email and Password 
        public User Login(string email , string password)
        {
            //Get User details from database using email 
            User user = userDAL.GetUserByEmail(email);

            //if user not found return null
            if (user == null) {
                return null;
            }

            bool isPasswordValid = passwordHelper.VerifyPassword(password,user.Password_Hash,user.Password_Salt);

            //if password incorrect return null
            if (!isPasswordValid) { 
            return null;
            }


            //Login Successfull return user object 
            return user;
        }


        //Check given email already exist 
        public bool EmailExists(string email) {
        return userDAL.EmailExists(email);
        }

        public bool RegisterCustomer(User user , string plainPassword)
        {
            if (userDAL.EmailExists(user.U_Email))
            {
                return false;
            }
            byte[] passwordHash;
            byte[] passwordSalt;
            
            passwordHelper.CreatePasswordHash(plainPassword, out passwordHash, out passwordSalt);

            //Store Hash and salt in user object 
            user.Password_Hash = passwordHash;
            user.Password_Salt = passwordSalt;

            //Assign role id for customer 
            user.Role_id = 2;

            int rowsAffected = userDAL.InsertUser(user);
            return rowsAffected > 0;
        }


        //Check if an Admin user already exists in the system
        public bool AdminExists()
        {
            //Call UserDAL method to check admin count in database
            return userDAL.AdminExists();
        }

        //Create the first/default Admin account
        public bool CreateDefaultAdmin(string fullName, string email, string phone, string address, string city, string plainPassword)
        {
            //If an admin already exists, do not create another admin
            if (userDAL.AdminExists())
            {
                return false;
            }

            //Check if the email is already used by another user
            if (userDAL.EmailExists(email))
            {
                return false;
            }

            //Variables to store generated password hash and salt
            byte[] passwordHash;
            byte[] passwordSalt;

            //Generate secure password hash and salt from plain password
            passwordHelper.CreatePasswordHash(plainPassword, out passwordHash, out passwordSalt);

            //Create a new User object for Admin
            User adminUser = new User
            {
                Full_Name = fullName,
                U_Email = email,
                U_Phone = phone,
                U_Address = address,
                U_City = city,
                Password_Hash = passwordHash, 
                Password_Salt = passwordSalt, 
                ProfileImagePath = null, 
                Role_id = 1 
            };

            //Insert admin user into the database
            int rowsAffected = userDAL.InsertUser(adminUser);

            //Return true if admin was successfully created
            return rowsAffected > 0;
        }
    }
}
