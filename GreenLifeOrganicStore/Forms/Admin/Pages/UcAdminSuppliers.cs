using GreenLifeOrganicStore.DAL;
using GreenLifeOrganicStore.Models;
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
    public partial class UcAdminSuppliers : UserControl
    {
        private readonly SupplierDAL supplierDAL = new SupplierDAL();
        public UcAdminSuppliers()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void UcAdminSuppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            ClearFields();
        }


        // Load active suppliers into the DataGridView
        private void LoadSuppliers()
        {
            try
            {
                dgvSupplierList.DataSource = supplierDAL.GetAllSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message,
                                "Load Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Clear all input fields
        private void ClearFields()
        {
            txtSupplierID.Text = "Auto-generated";
            txtSupplierName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtSupplierName.Focus();
        }

        // Validate user input before save or update
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter supplier name.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtSupplierName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter supplier email.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter supplier phone number.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter supplier address.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        // Check email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                {
                    return;
                }

                // Check duplicate email before inserting
                if (supplierDAL.SupplierEmailExists(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("This supplier email already exists.",
                                    "Duplicate Email",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                Supplier supplier = new Supplier
                {
                    Supplier_Name = txtSupplierName.Text.Trim(),
                    S_Email = txtEmail.Text.Trim(),
                    S_Phone = txtPhone.Text.Trim(),
                    S_Address = txtAddress.Text.Trim()
                };

                bool isInserted = supplierDAL.InsertSupplier(supplier);

                if (isInserted)
                {
                    MessageBox.Show("Supplier added successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LoadSuppliers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add supplier.",
                                    "Insert Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier: " + ex.Message,
                                "Insert Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierID.Text == "Auto-generated")
                {
                    MessageBox.Show("Please select a supplier to update.",
                                    "Selection Required",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInputs())
                {
                    return;
                }

                int supplierId = Convert.ToInt32(txtSupplierID.Text);

                // Check duplicate email except the current record
                if (supplierDAL.SupplierEmailExists(txtEmail.Text.Trim(), supplierId))
                {
                    MessageBox.Show("This supplier email already exists.",
                                    "Duplicate Email",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                Supplier supplier = new Supplier
                {
                    Supplier_id = supplierId,
                    Supplier_Name = txtSupplierName.Text.Trim(),
                    S_Email = txtEmail.Text.Trim(),
                    S_Phone = txtPhone.Text.Trim(),
                    S_Address = txtAddress.Text.Trim()
                };

                bool isUpdated = supplierDAL.UpdateSupplier(supplier);

                if (isUpdated)
                {
                    MessageBox.Show("Supplier updated successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LoadSuppliers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to update supplier.",
                                    "Update Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message,
                                "Update Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierID.Text == "Auto-generated")
                {
                    MessageBox.Show("Please select a supplier to delete.",
                                    "Selection Required",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int supplierId = Convert.ToInt32(txtSupplierID.Text);
                    bool isDeleted = supplierDAL.DeleteSupplier(supplierId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Supplier deleted successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        LoadSuppliers();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete supplier.",
                                        "Delete Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting supplier: " + ex.Message,
                                "Delete Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSupplierList.Rows[e.RowIndex];

                    txtSupplierID.Text = row.Cells["Supplier_id"].Value.ToString();
                    txtSupplierName.Text = row.Cells["Supplier_Name"].Value.ToString();
                    txtEmail.Text = row.Cells["S_Email"].Value.ToString();
                    txtPhone.Text = row.Cells["S_Phone"].Value.ToString();
                    txtAddress.Text = row.Cells["S_Address"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting supplier: " + ex.Message,
                                "Selection Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void txtSearchbox_Enter(object sender, EventArgs e)
        {
            if (txtSearchbox.Text == "   Search Supplier")
            {
                txtSearchbox.Text = "";
                txtSearchbox.ForeColor = Color.Black;
            }
        }

        private void txtSearchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearchbox.Text.Trim();

                // Ignore placeholder text during search
                if (keyword == "Search Supplier")
                {
                    keyword = "";
                }

                dgvSupplierList.DataSource = supplierDAL.SearchSuppliers(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching suppliers: " + ex.Message,
                                "Search Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
