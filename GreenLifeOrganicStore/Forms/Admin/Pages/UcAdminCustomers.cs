using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenLifeOrganicStore.DAL;

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminCustomers : UserControl
    {
        private readonly CustomerDAL customerDAL = new CustomerDAL();
        public UcAdminCustomers()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void UcAdminCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        // Load all customers into grid
        private void LoadCustomers()
        {
            dgvCustomers.DataSource = customerDAL.GetAllCustomers();

            // Change column headers to user-friendly names
            dgvCustomers.Columns["Users_id"].HeaderText = "Customer ID";
            dgvCustomers.Columns["Full_Name"].HeaderText = "Full Name";
            dgvCustomers.Columns["U_Email"].HeaderText = "Email";
            dgvCustomers.Columns["U_Phone"].HeaderText = "Phone";
            dgvCustomers.Columns["U_Address"].HeaderText = "Address";
            dgvCustomers.Columns["U_City"].HeaderText = "City";
            dgvCustomers.Columns["CreatedAt"].HeaderText = "Created Date";
        }
        // Search customers while typing
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchbox.Text.Trim() == "" || txtSearchbox.Text == "Search Customers")
            {
                LoadCustomers();
            }
            else
            {
                dgvCustomers.DataSource = customerDAL.SearchCustomers(txtSearchbox.Text.Trim());
            }
        }

        // Remove placeholder text when textbox gets focus
        private void txtSearchCustomer_Enter(object sender, EventArgs e)
        {
            if (txtSearchbox.Text == "   Search Customers")
            {
                txtSearchbox.Text = "";
                txtSearchbox.ForeColor = Color.Black;
            }
        }


        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
