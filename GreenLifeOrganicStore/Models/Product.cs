using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.Models
{
    public class Product
    {
        public int Product_id { get; set; }
        public int Category_id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Image_Path { get; set; }
        public int Stock_Qty { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal Discount_Percent { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
