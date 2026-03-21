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
            LoadCharts();

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

        // Load all charts
        private void LoadCharts()
        {
            try
            {
                LoadLowStockChart();
                LoadPendingOrdersChart();
                LoadNewCustomersChart();
                LoadFeedbackChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message,
                    "Chart Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Load low stock chart
        private void LoadLowStockChart()
        {
            DataTable dt = dashboardDAL.GetLowStockChartData();

            chartLowStockItems.Series.Clear();

            Series series = new Series("LowStock");
            series.ChartType = SeriesChartType.Pie; // Pie chart
            series.IsValueShownAsLabel = true; // Show values on chart

            foreach (DataRow row in dt.Rows)
            {
                string productName = row["Product_Name"].ToString();
                int stockQty = Convert.ToInt32(row["Stock_Qty"]);

                series.Points.AddXY(productName, stockQty);
            }

            chartLowStockItems.Series.Add(series);
            chartLowStockItems.Legends[0].Enabled = true;
        }

        // Load pending orders chart
        private void LoadPendingOrdersChart()
        {
            DataTable dt = dashboardDAL.GetPendingOrdersChartData();

            chartPendingOrders.Series.Clear();

            Series series = new Series("PendingOrders");
            series.ChartType = SeriesChartType.Pie; // Pie chart
            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                string orderLabel = "Order " + row["Order_id"].ToString();
                decimal grandTotal = Convert.ToDecimal(row["GrandTotal"]);

                series.Points.AddXY(orderLabel, grandTotal);
            }

            chartPendingOrders.Series.Add(series);
            chartPendingOrders.Legends[0].Enabled = true;
        }

        // Load new customers chart
        private void LoadNewCustomersChart()
        {
            DataTable dt = dashboardDAL.GetNewCustomersChartData();

            chartNewCustomers.Series.Clear();

            Series series = new Series("NewCustomers");
            series.ChartType = SeriesChartType.Pie; // Pie chart
            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                string customerName = row["Full_Name"].ToString();

                // Every customer counts as 1
                series.Points.AddXY(customerName, 1);
            }

            chartNewCustomers.Series.Add(series);
            chartNewCustomers.Legends[0].Enabled = true;
        }

        // Load feedback chart
        private void LoadFeedbackChart()
        {
            DataTable dt = dashboardDAL.GetFeedbackChartData();

            chartTotalFeedback.Series.Clear();

            Series series = new Series("Feedback");
            series.ChartType = SeriesChartType.Pie; // Pie chart
            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                string ratingLabel = "Rating " + row["Rating"].ToString();
                int totalReviews = Convert.ToInt32(row["TotalReviews"]);

                series.Points.AddXY(ratingLabel, totalReviews);
            }

            chartTotalFeedback.Series.Add(series);
            chartTotalFeedback.Legends[0].Enabled = true;
        }
    }
    }

