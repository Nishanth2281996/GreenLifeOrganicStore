using GreenLifeOrganicStore.Forms.Customer.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms.Customer
{
    public partial class FrmCustomerMain : Form
    {
        private readonly int customerId;
        public FrmCustomerMain(int loggedInCustomerId)
        {
            InitializeComponent();
            customerId = loggedInCustomerId;

            OpenCustomerPage(new UcBrowseProducts(customerId));

        }

        private void OpenCustomerPage(UserControl Page)
        {

            panelDesktop.Controls.Clear();
            Page.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Page);
           
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            // Add left Click to Nav bar
            cmsNav.Show(btnUser, 0, btnUser.Height);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            // Add Checkout User Control for Customer Panel 
            OpenCustomerPage(new UcCartCheckout());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            //Add Orders User Control for Customer Panel 
            OpenCustomerPage(new UcMyOrders());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //Add Orders User Control for Customer Panel 
            OpenCustomerPage(new UcBrowseProducts(customerId));
        }
    }
}
