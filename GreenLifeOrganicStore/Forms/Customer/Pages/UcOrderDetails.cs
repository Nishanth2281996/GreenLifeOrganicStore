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

namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    public partial class UcOrderDetails : UserControl
    {
        // Store selected order id
        private readonly int orderId;

        // Create DAL object
        private readonly OrderDAL orderDAL = new OrderDAL();
        private readonly ProductDAL productDAL = new ProductDAL();
        private readonly ReviewDAL reviewDAL = new ReviewDAL();

        // Store logged-in customer id
        private readonly int customerId;


        public UcOrderDetails(int selectedOrderId, int loggedInCustomerId)
        {
            InitializeComponent();

            // Save selected order id
            orderId = selectedOrderId;

            // Save customer id
            customerId = loggedInCustomerId;

            // Load order details when page opens
            LoadOrderDetails();
            LoadProductsForReview();
            LoadRatingCombo();



        }

        // Load order details from database
        private void LoadOrderDetails()
        {
            // Get selected order details for this customer
            DataTable table = orderDAL.GetCustomerOrderDetails(orderId, customerId);

            // Stop if order not found
            if (table.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Order details not found.\nOrder ID: " + orderId + "\nCustomer ID: " + customerId,
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Read first row
            DataRow row = table.Rows[0];

            // Show customer information
            lblCustomerName.Text = row["C_FullName"].ToString();
            lblCutomerID.Text = row["Customer_id"].ToString();
            lblCustomerEmail.Text = row["U_Email"].ToString();
            lblCustomerPhone.Text = row["C_Phone"].ToString();

            // Show payment and shipping information
            lblMethod.Text = row["Payment_Method"] == DBNull.Value
                ? "N/A"
                : row["Payment_Method"].ToString();

            lblAddress.Text = row["C_Address"].ToString() + ", " + row["C_City"].ToString();

            // Show totals
            lblTotalSubTotal.Text = Convert.ToDecimal(row["SubTotal"]).ToString("0.00");
            lblTotalAmount.Text = Convert.ToDecimal(row["GrandTotal"]).ToString("0.00");

            // Show order status
            btnDelivered.Text = row["Status_Name"].ToString();

            // Show payment status
            string paymentStatus = row["Payment_Status_Name"] == DBNull.Value
                ? "N/A"
                : row["Payment_Status_Name"].ToString();

            btnPaid.Text = paymentStatus;

            // Apply button colors
            ApplyStatusButtonStyle();

        }

        // Load products into review ComboBox
        private void LoadProductsForReview()
        {
            // Get active products from database
            DataTable products = productDAL.GetActiveProductsForReview();

            // Add default first option
            DataRow newRow = products.NewRow();
            newRow["Product_id"] = 0;
            newRow["Product_Name"] = "Select Your Product";
            products.Rows.InsertAt(newRow, 0);

            // Bind products to ComboBox
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Product_Name";
            cmbProduct.ValueMember = "Product_id";
        }

        // Load rating values into ComboBox
        private void LoadRatingCombo()
        {
            // Add rating options
            cmbRating.Items.Clear();
            cmbRating.Items.Add("Rating");
            cmbRating.Items.Add("1");
            cmbRating.Items.Add("2");
            cmbRating.Items.Add("3");
            cmbRating.Items.Add("4");
            cmbRating.Items.Add("5");

            // Select default item
            cmbRating.SelectedIndex = 0;
        }



        // Submit review button click
        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            // Check whether a valid product is selected
            if (cmbProduct.SelectedValue == null ||
                !int.TryParse(cmbProduct.SelectedValue.ToString(), out int productId) ||
                productId == 0)
            {
                MessageBox.Show("Please select a product.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check whether a valid rating is selected
            if (cmbRating.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a rating.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Read selected rating
            int rating = Convert.ToInt32(cmbRating.SelectedItem.ToString());

            // Read review comment
            string comment = txtReviewComment.Text.Trim();

            // Save review into database
            bool isSaved = reviewDAL.InsertReview(customerId, productId, rating, comment);

            // Show result message
            if (isSaved)
            {
                MessageBox.Show("Review submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset review fields
                cmbProduct.SelectedIndex = 0;
                cmbRating.SelectedIndex = 0;
                txtReviewComment.Clear();
            }
            else
            {
                MessageBox.Show("Failed to submit review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Apply colors to status buttons
        private void ApplyStatusButtonStyle()
        {
            // Style order status button
            if (btnDelivered.Text.Equals("Delivered", StringComparison.OrdinalIgnoreCase))
            {
                btnDelivered.BackColor = Color.LimeGreen;
                btnDelivered.ForeColor = Color.White;
            }
            else if (btnDelivered.Text.Equals("Pending", StringComparison.OrdinalIgnoreCase))
            {
                btnDelivered.BackColor = Color.DarkOrange;
                btnDelivered.ForeColor = Color.White;
            }
            else if (btnDelivered.Text.Equals("Shipped", StringComparison.OrdinalIgnoreCase))
            {
                btnDelivered.BackColor = Color.SteelBlue;
                btnDelivered.ForeColor = Color.White;
            }
            else
            {
                btnDelivered.BackColor = Color.Gray;
                btnDelivered.ForeColor = Color.White;
            }

            // Style payment status button
            if (btnPaid.Text.Equals("Paid", StringComparison.OrdinalIgnoreCase))
            {
                btnPaid.BackColor = Color.RoyalBlue;
                btnPaid.ForeColor = Color.White;
            }
            else if (btnPaid.Text.Equals("Pending", StringComparison.OrdinalIgnoreCase))
            {
                btnPaid.BackColor = Color.DarkOrange;
                btnPaid.ForeColor = Color.White;
            }
            else
            {
                btnPaid.BackColor = Color.Gray;
                btnPaid.ForeColor = Color.White;
            }
        }


       

       
        
        
    }
}

