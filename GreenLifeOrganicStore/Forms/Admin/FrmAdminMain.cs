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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GreenLifeOrganicStore.Forms.Admin
{
    public partial class FrmAdminMain : Form
    {
        public FrmAdminMain()
        {
            InitializeComponent();

            //Load Dashboard page when the admin panel Starts
            OpenAdminPage(new UcAdminDashboard(), "Dashboard");
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
            //Add DAshboard User Control in Admin Panel
            OpenAdminPage(new UcAdminDashboard(), "Dashboard");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //Add Products User Control in Admin Panel
            OpenAdminPage(new UcAdminProducts(), "Products");

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            //Add Catgory User Control in Admin Panel
            OpenAdminPage(new UcAdminCategories() , "Categories");
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            // Add Supplier User Control in Admin Panel
            OpenAdminPage(new UcAdminSuppliers(), "Supplier");
        }



        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Drop down Menu in Left Mouse click
            cmsProfile.Show(btnAdmin, 0, btnAdmin.Height);


        }

       

        private void lblAdminPanel_Click(object sender, EventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdminMain_Load(object sender, EventArgs e)
        {

        }

        
    }
}
