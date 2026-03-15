using GreenLifeOrganicStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    public partial class UcBrowseProducts : UserControl
    {
        private readonly DbHelper dbHelper = new DbHelper();

        // Store logged-in customer ID
        private readonly int customerId;

        // Product database object
        private readonly ProductDAL productDAL = new ProductDAL();

        // Cart database object
        private readonly CartDAL cartDAL = new CartDAL();
        public UcBrowseProducts(int loggedInCustomerId)
        {
            InitializeComponent();
            LoadCategories();
            LoadProducts();
            customerId = loggedInCustomerId;
        }
        private void UcBrowseProducts_Load(object sender, EventArgs e)
        {
         
            LoadCategories();
            LoadProducts();
        }

        // Load category list into ComboBox
        private void LoadCategories()
        {
            DataTable dt = productDAL.GetCategoriesForCombo();

            // Add "All" option
            DataRow row = dt.NewRow();
            row["Category_id"] = 0;
            row["Category_Name"] = "All";
            dt.Rows.InsertAt(row, 0);

            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "Category_Name";
            cmbCategory.ValueMember = "Category_id";
            cmbCategory.SelectedIndex = 0;
        }

        // Load all products at first
        private void LoadProducts()
        {
            DataTable dt = productDAL.GetFilteredProductsForCustomer(0, "");
            DisplayProducts(dt);
        }

        // Show products inside FlowLayoutPanel
        private void DisplayProducts(DataTable dt)
        {
            flpProducts.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                Panel productCard = CreateProductCard(row);
                flpProducts.Controls.Add(productCard);
            }
        }

        // Create one product card
        private Panel CreateProductCard(DataRow row)
        {
            Panel panel = new Panel();
            panel.Width = 220;
            panel.Height = 350;
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(10);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 180;
            pictureBox.Height = 120;
            pictureBox.Location = new Point(18, 15);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagePath = row["Product_Image_Path"].ToString();

            // Load image if file exists
            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }

            Label lblName = new Label();
            lblName.Text = row["Product_Name"].ToString();
            lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblName.Width = 180;
            lblName.Height = 40;
            lblName.Location = new Point(18, 145);

            Label lblCategory = new Label();
            lblCategory.Text = "Category: " + row["Category_Name"].ToString();
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(18, 190);

            Label lblStock = new Label();
            lblStock.Text = "Stock: " + row["Stock_Qty"].ToString();
            lblStock.AutoSize = true;
            lblStock.Location = new Point(18, 215);

            decimal unitPrice = Convert.ToDecimal(row["Unit_Price"]);
            decimal discountPercent = Convert.ToDecimal(row["Discount_Percent"]);
            decimal finalPrice = unitPrice - (unitPrice * discountPercent / 100);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Rs. " + finalPrice.ToString("0.00");
            lblPrice.ForeColor = Color.ForestGreen;
            lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(18, 240);

            int reviewCount = Convert.ToInt32(row["ReviewCount"]);
            decimal avgRating = Convert.ToDecimal(row["AvgRating"]);

            // Show reviews only if reviews exist
            if (reviewCount > 0)
            {
                Label lblReviews = new Label();
                lblReviews.Text = avgRating.ToString("0.0") + " ★ (" + reviewCount + " Reviews)";
                lblReviews.ForeColor = Color.DarkOrange;
                lblReviews.AutoSize = true;
                lblReviews.Location = new Point(18, 290);
                panel.Controls.Add(lblReviews);
            }

            Button btnAddToCart = new Button();
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.Width = 100;
            btnAddToCart.Height = 32;
            btnAddToCart.Location = new Point(95, 310);
            btnAddToCart.BackColor = Color.ForestGreen;
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.FlatStyle = FlatStyle.Flat;

            Label lblDiscount = new Label();
            lblDiscount.Text = "Discount: " + discountPercent.ToString("0.##") + "%";
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(18, 265);

            // Store product id inside Tag
            btnAddToCart.Tag = Convert.ToInt32(row["Product_id"]);
            btnAddToCart.Click += BtnAddToCart_Click;

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblCategory);
            panel.Controls.Add(lblStock);
            panel.Controls.Add(lblPrice);

            if(discountPercent > 0)
            {
                panel.Controls.Add(lblDiscount);
            }
           
            panel.Controls.Add(btnAddToCart);


            return panel;
        }


        // Search products when typing
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // Filter products when category changes
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // Apply category and search filters
        private void ApplyFilters()
        {
            if (cmbCategory.SelectedValue == null)
                return;

            int categoryId;
            if (!int.TryParse(cmbCategory.SelectedValue.ToString(), out categoryId))
                return;

            string keyword = txtSearch.Text.Trim();

            // Ignore placeholder text
            if (keyword == "Search Products")
            {
                keyword = "";
            }

            DataTable dt = productDAL.GetFilteredProductsForCustomer(categoryId, keyword);
            DisplayProducts(dt);
        }

        // Remove placeholder when textbox gets focus
        private void txtSearchProduct_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == " Search Products")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        // Add selected product to cart
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int productId = Convert.ToInt32(button.Tag);

            try
            {
                // Check available stock
                int stockQty = cartDAL.GetProductStock(productId);

                if (stockQty <= 0)
                {
                    MessageBox.Show("This product is out of stock.",
                        "Out of Stock",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Check how many are already in the cart
                int currentCartQty = cartDAL.GetCartQuantity(customerId, productId);

                // Prevent cart quantity from going above stock
                if (currentCartQty >= stockQty)
                {
                    MessageBox.Show("You cannot add more than available stock.",
                        "Stock Limit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Get final product price after discount
                decimal finalPrice = cartDAL.GetProductFinalPrice(productId);

                // Check whether product already exists in cart
                bool alreadyInCart = cartDAL.IsProductAlreadyInCart(customerId, productId);

                bool success;

                if (alreadyInCart)
                {
                    // Increase quantity by 1
                    success = cartDAL.IncreaseCartQuantity(customerId, productId, 1);
                }
                else
                {
                    // Insert new row with quantity 1
                    success = cartDAL.AddToCart(customerId, productId, 1, finalPrice);
                }

                if (success)
                {
                    MessageBox.Show("Product added to cart successfully.",
                        "Cart",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add product to cart.",
                        "Cart Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       




        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
    }
    }
}



