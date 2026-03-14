using GreenLifeOrganicStore.DAL;
using GreenLifeOrganicStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminPayments : UserControl
    {
        private readonly PaymentDAL paymentDAL = new PaymentDAL();
        private readonly PdfExportHelper pdfExportHelper = new PdfExportHelper();
        public UcAdminPayments()
        {
            InitializeComponent();
            LoadPaymentSummary();
            LoadPayments();
        }

        private void UcAdminPayments_Load(object sender, EventArgs e)
        {
            LoadPaymentSummary();
            LoadPayments();
        }

        // Load summary card values
        private void LoadPaymentSummary()
        {
            lblTotalPaymentsNumber.Text = paymentDAL.GetTotalPayments().ToString();
            lblCompletedTotalAmount.Text = paymentDAL.GetCompletedAmount().ToString("0.00");
           
        }

        // Load payment history into DataGridView
        private void LoadPayments()
        {
            dgvPayments.DataSource = paymentDAL.GetAllPayments();
           
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // Open save dialog for PDF file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Orders Report";
                saveFileDialog.FileName = "OrdersReport.pdf";

                // If user selects a location, export the grid
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfExportHelper.ExportDataGridViewToPdf(
                        dgvPayments,
                        saveFileDialog.FileName,
                        "Orders Report");

                    MessageBox.Show(
                        "Orders report exported successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while exporting PDF: " + ex.Message,
                    "Export Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
