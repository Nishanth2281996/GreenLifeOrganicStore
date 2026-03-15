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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        // Public method so other customer pages can request page changes
        public void LoadCustomerPage(UserControl page)
        {
            panelDesktop.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(page);
        }

        private void OpenCustomerPage(UserControl page)
        {

            LoadCustomerPage(page);
        }

        // Internal helper for this form's own navigation buttons
      

        private void btnUser_Click(object sender, EventArgs e)
        {
            // Add left Click to Nav bar
            cmsNav.Show(btnUser, 0, btnUser.Height);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            // Add Checkout User Control for Customer Panel 
            OpenCustomerPage(new UcCartCheckout(customerId));
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            //Add Orders User Control for Customer Panel 
            OpenCustomerPage(new UcMyOrders(customerId));
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //Add Orders User Control for Customer Panel 
            OpenCustomerPage(new UcBrowseProducts(customerId));
        }

       
    }
}

