using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.Models
{
    public class Supplier
    {
       
        public int Supplier_id { get; set; }
        public string Supplier_Name { get; set; }
        public string S_Email { get; set; }
        public string S_Phone { get; set; }
        public string S_Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
