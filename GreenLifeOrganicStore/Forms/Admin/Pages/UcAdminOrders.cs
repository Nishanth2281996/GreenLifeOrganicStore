using GreenLifeOrganicStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminOrders : UserControl
    {
        private readonly OrderDAL orderDAL = new OrderDAL();

        private readonly PdfExportHelper pdfExportHelper = new PdfExportHelper();

        // Store order statuses for the grid dropdown
        private DataTable orderStatusTable;
        public UcAdminOrders()
        {
            InitializeComponent();
            LoadOrders();
            LoadOrderStatuses();
        }

        private void UcAdminOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadOrderStatuses();
        }

       private void LoadOrders()
        {
            // Load all orders into grid
            dgvOrders.DataSource = orderDAL.GetAllOrders();

            // Set grid headers
            SetOrderGridHeaders();

            // Add status dropdown inside grid
            LoadGridStatusColumn();
        }

        // Load status values into the TOP FILTER combo box
        private void LoadOrderStatuses()
        {
            DataTable table = orderDAL.GetOrderStatuses();

            // Add "All" at top only for filtering
            DataRow row = table.NewRow();
            row["Order_Status_id"] = 0;
            row["Status_Name"] = "All";
            table.Rows.InsertAt(row, 0);

            cmbStatus.DataSource = table;
            cmbStatus.DisplayMember = "Status_Name";
            cmbStatus.ValueMember = "Order_Status_id";
            cmbStatus.SelectedIndex = 0;
        }

        // Add a new status dropdown column INSIDE the GRID
        private void LoadGridStatusColumn()
        {
            // Load status list without "All"
            orderStatusTable = orderDAL.GetOrderStatuses();

            // Remove old status dropdown if already exists
            if (dgvOrders.Columns.Contains("StatusCombo"))
            {
                dgvOrders.Columns.Remove("StatusCombo");
            }

            // Hide original text status column
            if (dgvOrders.Columns["Status_Name"] != null)
            {
                dgvOrders.Columns["Status_Name"].Visible = false;
            }

            // Hide internal status id column
            if (dgvOrders.Columns["Order_Status_id"] != null)
            {
                dgvOrders.Columns["Order_Status_id"].Visible = false;
            }

            // Create grid combo box column
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.Name = "StatusCombo";
            statusColumn.HeaderText = "Status";
            statusColumn.DataPropertyName = "Order_Status_id";
            statusColumn.DataSource = orderStatusTable;
            statusColumn.DisplayMember = "Status_Name";
            statusColumn.ValueMember = "Order_Status_id";
            statusColumn.FlatStyle = FlatStyle.Flat;
            statusColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;

            // Add new status dropdown to grid
            dgvOrders.Columns.Add(statusColumn);
        }

        private void SetOrderGridHeaders()
        {
            dgvOrders.Columns["Order_id"].HeaderText = "Order ID";
            dgvOrders.Columns["C_FullName"].HeaderText = "Customer Name";
            dgvOrders.Columns["Order_Date"].HeaderText = "Order Date";
            dgvOrders.Columns["Quantity"].HeaderText = "Quantity";
            dgvOrders.Columns["SubTotal"].HeaderText = "Subtotal";
            dgvOrders.Columns["GrandTotal"].HeaderText = "Grand Total";

            // Hide internal columns
            if (dgvOrders.Columns["Order_Status_id"] != null)
            {
                dgvOrders.Columns["Order_Status_id"].Visible = false;
            }

            if (dgvOrders.Columns["Status_Name"] != null)
            {
                dgvOrders.Columns["Status_Name"].Visible = false;
            }
        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchbox.Text.Trim() == "" || txtSearchbox.Text == "   Search Orders")
            {
                ApplyFilters();
            }
            else
            {
                dgvOrders.DataSource = orderDAL.SearchOrders(txtSearchbox.Text.Trim());
                SetOrderGridHeaders();
                LoadGridStatusColumn();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Top combo box is ONLY for filtering
            if (cmbStatus.SelectedValue == null)
                return;

            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string keyword = txtSearchbox.Text.Trim();

            // Ignore placeholder text
            if (keyword == "Search Orders" || keyword == "   Search Orders")
            {
                keyword = "";
            }

            int selectedStatusId;
            if (!int.TryParse(cmbStatus.SelectedValue.ToString(), out selectedStatusId))
            {
                selectedStatusId = 0;
            }

            // No search and All selected
            if (string.IsNullOrWhiteSpace(keyword) && selectedStatusId == 0)
            {
                dgvOrders.DataSource = orderDAL.GetAllOrders();
            }
            // Search only
            else if (!string.IsNullOrWhiteSpace(keyword) && selectedStatusId == 0)
            {
                dgvOrders.DataSource = orderDAL.SearchOrders(keyword);
            }
            // Status filter only
            else if (string.IsNullOrWhiteSpace(keyword) && selectedStatusId > 0)
            {
                dgvOrders.DataSource = orderDAL.FilterOrdersByStatus(selectedStatusId);
            }
            // Search + status filter
            else
            {
                DataTable searchTable = orderDAL.SearchOrders(keyword);
                DataView view = searchTable.DefaultView;
                view.RowFilter = "Order_Status_id = " + selectedStatusId;
                dgvOrders.DataSource = view.ToTable();
            }

            SetOrderGridHeaders();
            LoadGridStatusColumn();
        }

        private void txtSearchOrder_Enter(object sender, EventArgs e)
        {
            if (txtSearchbox.Text == "   Search Orders")
            {
                txtSearchbox.Text = "";
                txtSearchbox.ForeColor = Color.Black;
            }
        }

      

        private void dgvOrders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Commit combo box change immediately
            if (dgvOrders.IsCurrentCellDirty)
            {
                dgvOrders.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if change is in Status column
            if (e.RowIndex >= 0 && dgvOrders.Columns[e.ColumnIndex].Name == "StatusCombo")
            {
                try
                {
                    // Get Order ID
                    int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["Order_id"].Value);

                    // Get selected Status ID (VERY IMPORTANT: use Value, not text)
                    object value = dgvOrders.Rows[e.RowIndex].Cells["StatusCombo"].Value;

                    if (value == null) return;

                    int orderStatusId = Convert.ToInt32(value);

                    // Update database
                    bool updated = orderDAL.UpdateOrderStatus(orderId, orderStatusId);

                    if (updated)
                    {
                        // Optional message (can remove later)
                        MessageBox.Show("Status updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message);
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Orders Report";
                saveFileDialog.FileName = "OrdersReport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfExportHelper.ExportDataGridViewToPdf(
                        dgvOrders,
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
