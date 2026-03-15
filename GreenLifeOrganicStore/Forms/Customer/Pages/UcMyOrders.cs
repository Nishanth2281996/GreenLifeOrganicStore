using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    public partial class UcMyOrders : UserControl
    {
        private readonly int customerId;
        public UcMyOrders(int loggedInCustomerId)
        {
            InitializeComponent();
            customerId = loggedInCustomerId;
        }

        
    }
}
