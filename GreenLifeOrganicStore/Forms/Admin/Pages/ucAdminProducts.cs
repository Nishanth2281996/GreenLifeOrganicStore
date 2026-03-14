using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GreenLifeOrganicStore.DAL;
using GreenLifeOrganicStore.Models;

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminProducts : UserControl
    {
        private readonly ProductDAL productDAL = new ProductDAL();

        public UcAdminProducts()
        {
            InitializeComponent();
            LoadCategories();
            LoadSuppliers();
            LoadProducts();

        }

        private void UcAdminProducts_Load(object sender, EventArgs e)
        {
           
            ClearFields();
        }

        // Load category list into ComboBox
        private void LoadCategories()
        {
            cmbCatagory.DataSource = productDAL.GetCategoriesForCombo();
            cmbCatagory.DisplayMember = "Category_Name";
            cmbCatagory.ValueMember = "Category_id";
            cmbCatagory.SelectedIndex = -1;
        }

        // Load supplier list into ComboBox
        private void LoadSuppliers()
        {
            cmbSupplier.DataSource = productDAL.GetSuppliersForCombo();
            cmbSupplier.DisplayMember = "Supplier_Name";
            cmbSupplier.ValueMember = "Supplier_id";
            cmbSupplier.SelectedIndex = -1;
        }

        // Load all products into grid
        private void LoadProducts()
        {
            try
            {
                dgvProducts.DataSource = productDAL.GetAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message,
                                "Load Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Clear all fields
        private void ClearFields()
        {
            txtProductID.Text = "Auto-generated";
            txtProductName.Clear();
            txtPrice.Clear();
            txtStockQuantity.Clear();
            txtProductImagePath.Clear();
            txtDiscountPercent.Text = "0";

            cmbCatagory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;

            // Remove image preview
            picProduct.Image = null;

            txtProductName.Focus();
        }

        // Validate all input values
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter product name.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }

            if (cmbCatagory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                cmbCatagory.Focus();
                return false;
            }

            if (cmbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                cmbSupplier.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please enter unit price.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Please enter a valid unit price.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStockQuantity.Text))
            {
                MessageBox.Show("Please enter stock quantity.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtStockQuantity.Focus();
                return false;
            }

            if (!int.TryParse(txtStockQuantity.Text.Trim(), out int stockQty) || stockQty < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtStockQuantity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductImagePath.Text))
            {
                MessageBox.Show("Please choose a product image.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                btnBrowseImage.Focus();
                return false;
            }

            if (!decimal.TryParse(txtDiscountPercent.Text.Trim(), out decimal discount) || discount < 0)
            {
                MessageBox.Show("Please enter a valid discount percent.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtDiscountPercent.Focus();
                return false;
            }

            return true;
        }

        // Browse image from computer and preview it
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set file dialog title
            openFileDialog.Title = "Select Product Image";

            // Allow common image formats only
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save selected file path
                txtProductImagePath.Text = openFileDialog.FileName;

                // Show selected image in PictureBox
                picProduct.Image = Image.FromFile(openFileDialog.FileName);
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

                Product product = new Product
                {
                    Category_id = Convert.ToInt32(cmbCatagory.SelectedValue),
                    Product_Name = txtProductName.Text.Trim(),
                    Product_Image_Path = txtProductImagePath.Text.Trim(),
                    Stock_Qty = Convert.ToInt32(txtStockQuantity.Text.Trim()),
                    Unit_Price = Convert.ToDecimal(txtPrice.Text.Trim()),
                    Discount_Percent = Convert.ToDecimal(txtDiscountPercent.Text.Trim())
                };

                int supplierId = Convert.ToInt32(cmbSupplier.SelectedValue);

                bool isInserted = productDAL.InsertProduct(product, supplierId);

                if (isInserted)
                {
                    MessageBox.Show("Product added successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LoadProducts();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add product.",
                                    "Insert Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message,
                                "Insert Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "Auto-generated")
                {
                    MessageBox.Show("Please select a product to update.",
                                    "Selection Required",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInputs())
                {
                    return;
                }

                Product product = new Product
                {
                    Product_id = Convert.ToInt32(txtProductID.Text),
                    Category_id = Convert.ToInt32(cmbCatagory.SelectedValue),
                    Product_Name = txtProductName.Text.Trim(),
                    Product_Image_Path = txtProductImagePath.Text.Trim(),
                    Stock_Qty = Convert.ToInt32(txtStockQuantity.Text.Trim()),
                    Unit_Price = Convert.ToDecimal(txtPrice.Text.Trim()),
                    Discount_Percent = Convert.ToDecimal(txtDiscountPercent.Text.Trim())
                };

                int supplierId = Convert.ToInt32(cmbSupplier.SelectedValue);

                bool isUpdated = productDAL.UpdateProduct(product, supplierId);

                if (isUpdated)
                {
                    MessageBox.Show("Product updated successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LoadProducts();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to update product.",
                                    "Update Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message,
                                "Update Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "Auto-generated")
                {
                    MessageBox.Show("Please select a product to delete.",
                                    "Selection Required",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int productId = Convert.ToInt32(txtProductID.Text);
                    bool isDeleted = productDAL.DeleteProduct(productId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Product deleted successfully.",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        LoadProducts();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product.",
                                        "Delete Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message,
                                "Delete Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                    txtProductID.Text = row.Cells["Product_id"].Value.ToString();
                    txtProductName.Text = row.Cells["Product_Name"].Value.ToString();
                    txtPrice.Text = row.Cells["Unit_Price"].Value.ToString();
                    txtStockQuantity.Text = row.Cells["Stock_Qty"].Value.ToString();
                    txtProductImagePath.Text = row.Cells["Product_Image_Path"].Value.ToString();
                    txtDiscountPercent.Text = row.Cells["Discount_Percent"].Value.ToString();

                    // Show category and supplier names in ComboBoxes
                    cmbCatagory.Text = row.Cells["Category_Name"].Value.ToString();
                    cmbSupplier.Text = row.Cells["Supplier_Name"].Value.ToString();

                    // Load image preview if path exists
                    if (File.Exists(txtProductImagePath.Text))
                    {
                        picProduct.Image = Image.FromFile(txtProductImagePath.Text);
                    }
                    else
                    {
                        picProduct.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting product: " + ex.Message,
                                "Selection Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void txtSearchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearchbox.Text.Trim();

                // Ignore placeholder text
                if (keyword == "Search Products")
                {
                    keyword = "";
                }

                dgvProducts.DataSource = productDAL.SearchProducts(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message,
                                "Search Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        

        private void txtSearchbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearchbox.Text == "   Search Products")
            {
                txtSearchbox.Text = "";
                txtSearchbox.ForeColor = Color.Black;
            }
        }

      
    }
}
