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

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminOrders : UserControl
    {
        private readonly OrderDAL orderDAL = new OrderDAL();

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
            dgvOrders.DataSource = orderDAL.GetAllOrders();
            SetOrderGridHeaders();
        }

        // Load order status values into ComboBox
        private void LoadOrderStatuses()
        {
            DataTable table = orderDAL.GetOrderStatuses();

            // Add "All" option manually at the top
            DataRow row = table.NewRow();
            row["Order_Status_id"] = 0;
            row["Status_Name"] = "All";
            table.Rows.InsertAt(row, 0);

            cmbStatus.DataSource = table;
            cmbStatus.DisplayMember = "Status_Name";
            cmbStatus.ValueMember = "Order_Status_id";
            cmbStatus.SelectedIndex = 0;
        }

        // Set friendly column headers in grid
        private void SetOrderGridHeaders()
        {
            dgvOrders.Columns["Order_id"].HeaderText = "Order ID";
            dgvOrders.Columns["C_FullName"].HeaderText = "Customer Name";
            dgvOrders.Columns["Order_Date"].HeaderText = "Order Date";
            dgvOrders.Columns["Quantity"].HeaderText = "Quantity";
            dgvOrders.Columns["SubTotal"].HeaderText = "Subtotal";
            dgvOrders.Columns["GrandTotal"].HeaderText = "Grand Total";
            dgvOrders.Columns["Status_Name"].HeaderText = "Status";

            // Hide internal status id column from user
            if (dgvOrders.Columns["Order_Status_id"] != null)
            {
                dgvOrders.Columns["Order_Status_id"].Visible = false;
            }
        }
        // Search orders while typing
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
            }
        }

        // Filter orders when selected status changes
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Avoid errors during initial binding
            if (cmbStatus.SelectedValue == null)
                return;

            ApplyFilters();
        }

        // Apply current search and status logic
        private void ApplyFilters()
        {
            string keyword = txtSearchbox.Text.Trim();

            // If placeholder is showing, treat as empty
            if (keyword == "Search Orders")
            {
                keyword = "";
            }

            int selectedStatusId;
            if (!int.TryParse(cmbStatus.SelectedValue.ToString(), out selectedStatusId))
            {
                selectedStatusId = 0;
            }

            // If no search text and All status, load all orders
            if (string.IsNullOrWhiteSpace(keyword) && selectedStatusId == 0)
            {
                LoadOrders();
            }
            // If search text exists and status is All
            else if (!string.IsNullOrWhiteSpace(keyword) && selectedStatusId == 0)
            {
                dgvOrders.DataSource = orderDAL.SearchOrders(keyword);
                SetOrderGridHeaders();
            }
            // If no search text and specific status selected
            else if (string.IsNullOrWhiteSpace(keyword) && selectedStatusId > 0)
            {
                dgvOrders.DataSource = orderDAL.FilterOrdersByStatus(selectedStatusId);
                SetOrderGridHeaders();
            }
            else
            {
                // Simple beginner-friendly approach:
                // first filter by search result, then use DataView for status
                DataTable searchTable = orderDAL.SearchOrders(keyword);
                DataView view = searchTable.DefaultView;
                view.RowFilter = "Order_Status_id = " + selectedStatusId;
                dgvOrders.DataSource = view.ToTable();
                SetOrderGridHeaders();
            }
        }

        // Remove placeholder text when search box gets focus
        private void txtSearchOrder_Enter(object sender, EventArgs e)
        {
            if (txtSearchbox.Text == "   Search Orders")
            {
                txtSearchbox.Text = "";
                txtSearchbox.ForeColor = Color.Black;
            }
        }
    }
}
