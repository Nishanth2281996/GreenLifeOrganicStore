using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GreenLifeOrganicStore.DAL;

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminDashboard : UserControl
    {

        private readonly DashboardDAL dashboardDAL = new DashboardDAL();
        public UcAdminDashboard()
        {
            InitializeComponent();
            LoadDashboardData();

        }

        private void LoadDashboardData()
        {
            try
            {
                lblProductCount.Text = dashboardDAL.GetTotalProducts().ToString();
                lblTotalOrdersCount.Text = dashboardDAL.GetTotalOrders().ToString();
                lblTotalCustomersCount.Text = dashboardDAL.GetTotalCustomers().ToString();
                lblTotalMonthlyRevenue.Text = dashboardDAL.GetTotalRevenue().ToString("0.00");
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.
                    Error);
            }
        }

        private void openAdminPage(UserControl Page , string pageTitle) { }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartPendingOrders_Click(object sender, EventArgs e)
        {

        }

        private void chartTotalFeedback_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalFeedback_Click(object sender, EventArgs e)
        {

        }

        private void lblPendingOrders_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartLowStockItems_Click(object sender, EventArgs e)
        {

        }

        private void UcAdminDashboard_Load(object sender, EventArgs e)
        {

    
        }

        private void panelMonthlyRevenue_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
