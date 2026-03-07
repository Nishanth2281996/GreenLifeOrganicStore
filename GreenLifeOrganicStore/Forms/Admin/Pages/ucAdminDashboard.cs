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

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminDashboard : UserControl
    {
        public UcAdminDashboard()
        {
            InitializeComponent();
            this.Load += UcAdminDashboard_Load;

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
            chartLowStockItems.Series.Clear();

            Series series = new Series("Low Stock");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Broccoli", 7);
            series.Points.AddXY("Honey", 11);
            series.Points.AddXY("Almonds", 16);
            series.Points.AddXY("Quinoa", 18);
            series.Points.AddXY("Yogurt", 22);
            series.Points.AddXY("Spinach", 27);

            chartLowStockItems.Series.Add(series);
        }
    }
}
