using GreenLifeOrganicStore.Forms.Admin.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GreenLifeOrganicStore.Forms.Admin
{
    public partial class FrmAdminMain : Form
    {

        // Store the currently selected sidebar button
        private Button activeButton = null;

        // Normal sidebar button color
        private Color normalButtonColor = Color.FromArgb(0, 64, 0);

        // Active sidebar button color
        private Color activeButtonColor = Color.ForestGreen;
        public FrmAdminMain()
        {
            InitializeComponent();

            //Load Dashboard page when the admin panel Starts
            OpenAdminPage(new UcAdminDashboard(), "Dashboard");
        }

        // Reset all sidebar buttons to normal color
        private void ResetSidebarButtons()
        {
            btnDashboard.BackColor = normalButtonColor;
            btnProducts.BackColor = normalButtonColor;
            btnCategories.BackColor = normalButtonColor;
            btnSuppliers.BackColor = normalButtonColor;
            btnCustomers.BackColor = normalButtonColor;
            btnOrders.BackColor = normalButtonColor;
            btnPayments.BackColor = normalButtonColor;
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



        //loads Usercontrol page into desktop panel
        private void OpenAdminPage(UserControl Page, string pageTitle)
        {
            panelDesktop.Controls.Clear();
            Page.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Page);
            lblPageTitle.Text = pageTitle;
        }

         private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnDashboard);

            //Add DAshboard User Control in Admin Panel
            OpenAdminPage(new UcAdminDashboard(), "Dashboard");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnProducts);
            //Add Products User Control in Admin Panel
            OpenAdminPage(new UcAdminProducts(), "Products");

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnCategories);
            //Add Catgory User Control in Admin Panel
            OpenAdminPage(new UcAdminCategories() , "Categories");
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnSuppliers);
            // Add Supplier User Control in Admin Panel
            OpenAdminPage(new UcAdminSuppliers(), "Supplier");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnCustomers);
            //Add Customer User Control in Admin Panel
            OpenAdminPage(new UcAdminCustomers(), "Customers");
        }

        private void btnOrders_Click_1(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnOrders);
            //Add Order User Control in Admin Panel
            OpenAdminPage(new UcAdminOrders(), "Orders");
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            ActivateSidebarButton(btnPayments);
            //Add Payment User Control in Admin Panel
            OpenAdminPage(new UcAdminPayments(), "Payments");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Drop down Menu in Left Mouse click
            cmsProfile.Show(btnAdmin, 0, btnAdmin.Height);


        }


        private void mnuLogout_Click(object sender, EventArgs e)
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
    }
    }


