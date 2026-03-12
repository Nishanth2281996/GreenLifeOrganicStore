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

        public User Login(string email , string password)
        {
            User user = userDAL.GetUserByEmail(email);

            if (user == null) {
                return null;
            }

            bool isPasswordValid = passwordHelper.VerifyPassword(password,user.Password_Hash,user.Password_Salt);

            if (!isPasswordValid) { 
            return null;
            }

            return user;
        }

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

            user.Password_Hash = passwordHash;
            user.Password_Salt = passwordSalt;
            user.Role_id = 2;

            int rowsAffected = userDAL.InsertUser(user);
            return rowsAffected > 0;
        }
    }
}
