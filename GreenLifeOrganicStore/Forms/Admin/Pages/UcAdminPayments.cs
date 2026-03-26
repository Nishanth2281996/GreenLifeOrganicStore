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

        private DataTable paymentStatusTable;
        private bool isLoading = false;
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

        // Load top summary cards
        private void LoadPaymentSummary()
        {
            lblTotalPaymentsNumber.Text = paymentDAL.GetTotalPayments().ToString();
            lblCompletedTotalAmount.Text = paymentDAL.GetCompletedAmount().ToString("0.00");
        }

        // Load payments into grid
        private void LoadPayments()
        {
            isLoading = true;

            dgvPayments.DataSource = null;
            dgvPayments.Columns.Clear();

            // Bind payment data from database
            dgvPayments.DataSource = paymentDAL.GetAllPayments();

            // Load statuses for combobox
            paymentStatusTable = paymentDAL.GetPaymentStatuses();

            // Remove original text status column completely
            if (dgvPayments.Columns.Contains("Payment_Status_Name"))
            {
                dgvPayments.Columns.Remove("Payment_Status_Name");
            }

            // Add bound combobox column
            AddPaymentStatusComboBoxColumn();

            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           

            isLoading = false;
        }

        // Add one visible Payment Status combobox column
        private void AddPaymentStatusComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmbStatus = new DataGridViewComboBoxColumn();
            cmbStatus.Name = "Payment_Status_Name";
            cmbStatus.HeaderText = "Payment Status";

            // This binds the combobox column to the real data field
            cmbStatus.DataPropertyName = "Payment_Status_Name";

            // These provide the dropdown options
            cmbStatus.DataSource = paymentStatusTable;
            cmbStatus.DisplayMember = "Payment_Status_Name";
            cmbStatus.ValueMember = "Payment_Status_Name";

            cmbStatus.FlatStyle = FlatStyle.Flat;

            dgvPayments.Columns.Add(cmbStatus);

            // Put the status column in the correct place
            dgvPayments.Columns["Payment_Status_Name"].DisplayIndex = 6;
        }

        // Commit combobox value immediately
        private void dgvPayments_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPayments.IsCurrentCellDirty)
            {
                dgvPayments.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Update database when combobox value changes
        private void dgvPayments_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            if (isLoading)
            {
                return;
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvPayments.Columns[e.ColumnIndex].Name == "Payment_Status_Name")
            {
                try
                {
                    DataGridViewRow row = dgvPayments.Rows[e.RowIndex];

                    // Get payment id from selected row
                    int paymentId = Convert.ToInt32(row.Cells["Payment_id"].Value);

                    // Get selected status name from combobox
                    string selectedStatusName = row.Cells["Payment_Status_Name"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(selectedStatusName))
                    {
                        return;
                    }

                    // Find matching status id from status table
                    int paymentStatusId = 0;

                    foreach (DataRow statusRow in paymentStatusTable.Rows)
                    {
                        if (statusRow["Payment_Status_Name"].ToString() == selectedStatusName)
                        {
                            paymentStatusId = Convert.ToInt32(statusRow["Payment_Status_id"]);
                            break;
                        }
                    }

                    if (paymentStatusId == 0)
                    {
                        MessageBox.Show(
                            "Invalid payment status selected.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    // Update database
                    bool isUpdated = paymentDAL.UpdatePaymentStatus(paymentId, paymentStatusId);

                    if (isUpdated)
                    {
                        // Update hidden text column also
                        row.Cells["Payment_Status_Name"].Value = selectedStatusName;

                        // Refresh summary and colors
                        LoadPaymentSummary();
                        
                    }
                    else
                    {
                        MessageBox.Show(
                            "Payment status update failed.",
                            "Update Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error while updating payment status: " + ex.Message,
                        "Update Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                
            }
        }

        // Prevent combobox errors from crashing the form
        private void dgvPayments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

      

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Payments Report";
                saveFileDialog.FileName = "PaymentsReport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfExportHelper.ExportDataGridViewToPdf(
                        dgvPayments,
                        saveFileDialog.FileName,
                        "Payments Report");

                    MessageBox.Show(
                        "Payments report exported successfully.",
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
