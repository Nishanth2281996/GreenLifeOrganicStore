using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GreenLifeOrganicStore.Services
{
    public class PasswordHelper
    {
        private const int SaltSize = 32;
        private const int HashSize = 64;
        private const int Iterations = 10000;

        //Create Password Salt and Hash 
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var rng = new RNGCryptoServiceProvider()) //Random Number Generation 
            {
                passwordSalt = new byte[SaltSize]; //Allocate Salt 
                rng.GetBytes(passwordSalt); //Generate Random Salt  
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, passwordSalt, Iterations)) //PBKDF2 Hashing 
            {
                passwordHash = pbkdf2.GetBytes(HashSize); //Generate Password Hash 
            }
        }


        //Verify Password During Log in 
          public bool VerifyPassword(string password , byte[] storedHash , byte[] storedSalt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, storedSalt, Iterations))
            {
                byte[] computedHash = pbkdf2.GetBytes(HashSize);

                //Compare Computed hash with Store Hash 
                for (int i = 0; i < computedHash.Length; i++) {
                    if (computedHash[i] != storedHash[i]) {
                        return false;  //Password mismatch
                    }
            }
        }

            return true; //password match
        }
    }
}
