using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.Models
{
    public class User
    {
        public int Users_id { get; set; }
        public string Full_Name { get; set; }
        public string U_Email {  get; set; }
        public string U_Phone { get; set;}
        public string U_City { get; set; }
        public string U_Address {  get; set; }
        public byte[] Password_Hash {  get; set; }
        public byte[] Password_Salt { get; set; }
        public string ProfileImagePath {  get; set; }
        public DateTime CreatedAt { get; set; }
        public int Role_id { get; set; }

        
    }
}
