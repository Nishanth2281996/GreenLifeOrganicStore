using GreenLifeOrganicStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    public partial class UcCartCheckout : UserControl
    {

        // Store logged-in customer ID
        private readonly int customerId;

        // Cart database object
        private readonly CartDAL cartDAL = new CartDAL();

        // Checkout database object
        private readonly CheckoutDAL checkoutDAL = new CheckoutDAL();

        // Fixed summary values for now
        private decimal shippingFee = 300;
        private decimal discountAmount = 0;
        public UcCartCheckout(int loggedInCustomerId)
        {
            InitializeComponent();

            // Save logged-in customer ID
            customerId = loggedInCustomerId;
            
        }

        private void UcCartCheckout_Load(object sender, EventArgs e)
        {

            SetupCartGrid();
            LoadPaymentMethods();
            LoadCartItems();


        }

        // Create cart grid columns in code
        private void SetupCartGrid()
        {
            dgvCart.Columns.Clear();
            dgvCart.AutoGenerateColumns = false;
            dgvCart.AllowUserToAddRows = false;
            dgvCart.ReadOnly = true;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Product column
            DataGridViewTextBoxColumn colProductName = new DataGridViewTextBoxColumn();
            colProductName.Name = "colProductName";
            colProductName.HeaderText = "Product";

            // Price column
            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = "colPrice";
            colPrice.HeaderText = "Price";

            // Minus button column
            DataGridViewButtonColumn colMinus = new DataGridViewButtonColumn();
            colMinus.Name = "colMinus";
            colMinus.HeaderText = "";
            colMinus.Text = "-";
            colMinus.UseColumnTextForButtonValue = true;

            // Quantity column
            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.Name = "colQuantity";
            colQuantity.HeaderText = "Quantity";

            // Plus button column
            DataGridViewButtonColumn colPlus = new DataGridViewButtonColumn();
            colPlus.Name = "colPlus";
            colPlus.HeaderText = "";
            colPlus.Text = "+";
            colPlus.UseColumnTextForButtonValue = true;

            // Subtotal column
            DataGridViewTextBoxColumn colSubtotal = new DataGridViewTextBoxColumn();
            colSubtotal.Name = "colSubtotal";
            colSubtotal.HeaderText = "Subtotal";

            // Remove button column
            DataGridViewButtonColumn colRemove = new DataGridViewButtonColumn();
            colRemove.Name = "colRemove";
            colRemove.HeaderText = "Remove";
            colRemove.Text = "X";
            colRemove.UseColumnTextForButtonValue = true;

            dgvCart.Columns.Add(colProductName);
            dgvCart.Columns.Add(colPrice);
            dgvCart.Columns.Add(colMinus);
            dgvCart.Columns.Add(colQuantity);
            dgvCart.Columns.Add(colPlus);
            dgvCart.Columns.Add(colSubtotal);
            dgvCart.Columns.Add(colRemove);
        }

        // Load payment methods into ComboBox
        private void LoadPaymentMethods()
        {
            DataTable dt = cartDAL.GetPaymentMethods();

            cmbPaymentMethod.DataSource = dt;
            cmbPaymentMethod.DisplayMember = "Payment_Method";
            cmbPaymentMethod.ValueMember = "Payment_Method_id";
            cmbPaymentMethod.SelectedIndex = -1;
        }

        // Load cart items into DataGridView
        private void LoadCartItems()
        {
            DataTable dt = cartDAL.GetCartItemsByUser(customerId);

            dgvCart.Rows.Clear();

            decimal subtotal = 0;

            foreach (DataRow row in dt.Rows)
            {
                int cartId = Convert.ToInt32(row["Cart_id"]);
                string productName = row["Product_Name"].ToString();
                decimal price = Convert.ToDecimal(row["Unit_Price"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal rowSubtotal = Convert.ToDecimal(row["Subtotal"]);

                int rowIndex = dgvCart.Rows.Add(
                    productName,
                    price.ToString("0.00"),
                    "-",
                    quantity,
                    "+",
                    rowSubtotal.ToString("0.00"),
                    "X"
                 );

                // Store Cart_id in row Tag
                dgvCart.Rows[rowIndex].Tag = cartId;

                subtotal += rowSubtotal;
            }

            UpdateSummary(subtotal);
        }

        // Update subtotal, shipping, discount, and total labels
        private void UpdateSummary(decimal subtotal)
        {
            decimal total = subtotal + shippingFee - discountAmount;

            lblSubtotalNumber.Text = "Rs. " + subtotal.ToString("0.00");
            lblShippingNumber.Text = "Rs. " + shippingFee.ToString("0.00");
            lblDiscountNumber.Text = "Rs. " + discountAmount.ToString("0.00");
            lblTotalNumber.Text = "Rs. " + total.ToString("0.00");
        }

        // Handle minus, plus, and remove clicks
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int cartId = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Tag);
            int currentQuantity = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["colQuantity"].Value);
            int productId = cartDAL.GetProductIdByCartId(cartId);

            // Minus button clicked
            if (dgvCart.Columns[e.ColumnIndex].Name == "colMinus")
            {
                if (currentQuantity > 1)
                {
                    bool success = cartDAL.UpdateCartQuantity(cartId, currentQuantity - 1);

                    if (success)
                    {
                        LoadCartItems();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reduce quantity.",
                            "Cart Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        "Quantity is 1. Do you want to remove this item?",
                        "Remove Item",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bool success = cartDAL.RemoveCartItem(cartId);

                        if (success)
                        {
                            LoadCartItems();
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove item.",
                                "Cart Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            
            
           }

            // Plus button clicked
            else if (dgvCart.Columns[e.ColumnIndex].Name == "colPlus")
            {
                int stockQty = cartDAL.GetProductStock(productId);

                if (currentQuantity >= stockQty)
                {
                    MessageBox.Show("You cannot add more than available stock.",
                        "Stock Limit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                bool success = cartDAL.UpdateCartQuantity(cartId, currentQuantity + 1);

                if (success)
                {
                    LoadCartItems();
                }
                else
                {
                    MessageBox.Show("Failed to increase quantity.",
                        "Cart Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            // Remove button clicked
            else if (dgvCart.Columns[e.ColumnIndex].Name == "colRemove")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove this item?",
                    "Remove Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = cartDAL.RemoveCartItem(cartId);

                    if (success)
                    {
                        LoadCartItems();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove item.",
                            "Cart Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Validate checkout inputs for now
        private void btnProceedCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty.",
                    "Checkout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtShippingAddress.Text))
            {
                MessageBox.Show("Please enter your shipping address.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to place this order?",
                "Confirm Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            int paymentMethodId = Convert.ToInt32(cmbPaymentMethod.SelectedValue);
            string shippingAddress = txtShippingAddress.Text.Trim();

            string message;
            bool success = checkoutDAL.ProcessCheckout(customerId, shippingAddress, paymentMethodId, out message);

            if (success)
            {
                MessageBox.Show(message,
                    "Checkout Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Redirect to Orders page
                Form parentForm = this.FindForm();

                if (parentForm is FrmCustomerMain mainForm)
                {
                    mainForm.LoadCustomerPage(new UcMyOrders(customerId));
                }
            }
        }



    }
    



    }
