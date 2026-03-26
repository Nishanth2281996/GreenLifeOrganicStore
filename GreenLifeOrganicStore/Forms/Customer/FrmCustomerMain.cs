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

        // Store the currently selected sidebar button
        private Button activeButton = null;

        // Normal sidebar button color
        private Color normalButtonColor = Color.FromArgb(0, 64, 0);

        // Active sidebar button color
        private Color activeButtonColor = Color.ForestGreen;
        public FrmCustomerMain(int loggedInCustomerId)
        {
            InitializeComponent();
            customerId = loggedInCustomerId;

            OpenCustomerPage(new UcBrowseProducts(customerId));

        }

        private void ResetSidebarButtons()
        {
            btnCart.BackColor = normalButtonColor;
            btnProducts.BackColor = normalButtonColor;
            btnOrders.BackColor = normalButtonColor;

        }

        // Highlight the clicked button
        private void ActivateSidebarButton(Button clickedButton)
        {
            // Reset all buttons first
            ResetSidebarButtons();

            // Save the clicked button as active button
            activeButton = clickedButton;

            // Change clicked button color
            activeButton.BackColor = activeButtonColor;
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
            ActivateSidebarButton(btnCart);
            // Add Checkout User Control for Customer Panel 
            OpenCustomerPage(new UcCartCheckout(customerId));
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnOrders);
            //Add Orders User Control for Customer Panel 
            OpenCustomerPage(new UcMyOrders(customerId));
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnProducts);
            //Add Orders User Control for Customer Panel 
            OpenCustomerPage(new UcBrowseProducts(customerId));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before logout
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // If admin clicks Yes, return to login form
            if (result == DialogResult.Yes)
            {
                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();

                // Hide current admin form
                this.Hide();
            }
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCustomerPage(new UcMyProfile(customerId));
        }
    }
}

