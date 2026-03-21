namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    partial class UcOrderDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtReviewComment = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblShippping = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalSubTotal = new System.Windows.Forms.Label();
            this.lblShippingCost = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrderItems = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCustomerInformation = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCutomerID = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnDelivered = new System.Windows.Forms.Button();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.cmbRating);
            this.panelMain.Controls.Add(this.btnSubmit);
            this.panelMain.Controls.Add(this.txtReviewComment);
            this.panelMain.Controls.Add(this.cmbProduct);
            this.panelMain.Controls.Add(this.lblReview);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.lblSubTotal);
            this.panelMain.Controls.Add(this.lblShippping);
            this.panelMain.Controls.Add(this.lblDiscount);
            this.panelMain.Controls.Add(this.lblTotal);
            this.panelMain.Controls.Add(this.lblTotalSubTotal);
            this.panelMain.Controls.Add(this.lblShippingCost);
            this.panelMain.Controls.Add(this.lblTotalDiscount);
            this.panelMain.Controls.Add(this.lblTotalAmount);
            this.panelMain.Controls.Add(this.dgvOrderItems);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1276, 984);
            this.panelMain.TabIndex = 0;
            
            // 
            // cmbRating
            // 
            this.cmbRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRating.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(513, 798);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(175, 33);
            this.cmbRating.TabIndex = 19;
            this.cmbRating.Text = "   Rating ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(1074, 870);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(175, 42);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // txtReviewComment
            // 
            this.txtReviewComment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewComment.Location = new System.Drawing.Point(66, 846);
            this.txtReviewComment.Multiline = true;
            this.txtReviewComment.Name = "txtReviewComment";
            this.txtReviewComment.Size = new System.Drawing.Size(976, 92);
            this.txtReviewComment.TabIndex = 17;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(66, 798);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(391, 33);
            this.cmbProduct.TabIndex = 16;
            this.cmbProduct.Text = "Select Your Product";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(61, 754);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(300, 28);
            this.lblReview.TabIndex = 15;
            this.lblReview.Text = "Review your Purchase Product";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(877, 723);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 3);
            this.panel3.TabIndex = 14;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(872, 643);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(94, 25);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "SubTotal : ";
            // 
            // lblShippping
            // 
            this.lblShippping.AutoSize = true;
            this.lblShippping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippping.Location = new System.Drawing.Point(872, 668);
            this.lblShippping.Name = "lblShippping";
            this.lblShippping.Size = new System.Drawing.Size(97, 25);
            this.lblShippping.TabIndex = 12;
            this.lblShippping.Text = "Shipping : ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Green;
            this.lblDiscount.Location = new System.Drawing.Point(873, 693);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(96, 25);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Discount : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(903, 729);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total : ";
            // 
            // lblTotalSubTotal
            // 
            this.lblTotalSubTotal.AutoSize = true;
            this.lblTotalSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSubTotal.Location = new System.Drawing.Point(1085, 643);
            this.lblTotalSubTotal.Name = "lblTotalSubTotal";
            this.lblTotalSubTotal.Size = new System.Drawing.Size(52, 25);
            this.lblTotalSubTotal.TabIndex = 9;
            this.lblTotalSubTotal.Text = "5000";
            // 
            // lblShippingCost
            // 
            this.lblShippingCost.AutoSize = true;
            this.lblShippingCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingCost.Location = new System.Drawing.Point(1095, 668);
            this.lblShippingCost.Name = "lblShippingCost";
            this.lblShippingCost.Size = new System.Drawing.Size(42, 25);
            this.lblShippingCost.TabIndex = 8;
            this.lblShippingCost.Text = "300";
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.AutoSize = true;
            this.lblTotalDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.ForeColor = System.Drawing.Color.Green;
            this.lblTotalDiscount.Location = new System.Drawing.Point(1095, 693);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(42, 25);
            this.lblTotalDiscount.TabIndex = 7;
            this.lblTotalDiscount.Text = "100";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalAmount.Location = new System.Drawing.Point(1085, 729);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(52, 25);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "4500";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(136, 311);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersWidth = 62;
            this.dgvOrderItems.RowTemplate.Height = 28;
            this.dgvOrderItems.Size = new System.Drawing.Size(1028, 322);
            this.dgvOrderItems.TabIndex = 2;
            
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblOrderItems);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblShipping);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.lblCustomerInformation);
            this.panel2.Controls.Add(this.lblCustomerPhone);
            this.panel2.Controls.Add(this.lblMethod);
            this.panel2.Controls.Add(this.lblShippingAddress);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Controls.Add(this.lblCutomerID);
            this.panel2.Controls.Add(this.lblCustomerEmail);
            this.panel2.Controls.Add(this.lblPaymentMethod);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(133, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 247);
            this.panel2.TabIndex = 1;
            // 
            // lblOrderItems
            // 
            this.lblOrderItems.AutoSize = true;
            this.lblOrderItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItems.Location = new System.Drawing.Point(32, 191);
            this.lblOrderItems.Name = "lblOrderItems";
            this.lblOrderItems.Size = new System.Drawing.Size(150, 32);
            this.lblOrderItems.TabIndex = 8;
            this.lblOrderItems.Text = "Order Items";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(676, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(270, 25);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "123 , Shopping Road , Batticaloa";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.Location = new System.Drawing.Point(496, 13);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(257, 30);
            this.lblShipping.TabIndex = 4;
            this.lblShipping.Text = "Shipping and Payments";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(20, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(126, 25);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Customer ID : ";
            // 
            // lblCustomerInformation
            // 
            this.lblCustomerInformation.AutoSize = true;
            this.lblCustomerInformation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInformation.Location = new System.Drawing.Point(23, 13);
            this.lblCustomerInformation.Name = "lblCustomerInformation";
            this.lblCustomerInformation.Size = new System.Drawing.Size(242, 30);
            this.lblCustomerInformation.TabIndex = 3;
            this.lblCustomerInformation.Text = "Customer Information";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(165, 158);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(127, 25);
            this.lblCustomerPhone.TabIndex = 4;
            this.lblCustomerPhone.Text = "077 12344565";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(672, 57);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(101, 25);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "Credit Card";
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingAddress.Location = new System.Drawing.Point(496, 88);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(178, 25);
            this.lblShippingAddress.TabIndex = 6;
            this.lblShippingAddress.Text = "Shippping Address : ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(20, 158);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 25);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone : ";
            // 
            // lblCutomerID
            // 
            this.lblCutomerID.AutoSize = true;
            this.lblCutomerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutomerID.Location = new System.Drawing.Point(165, 88);
            this.lblCutomerID.Name = "lblCutomerID";
            this.lblCutomerID.Size = new System.Drawing.Size(53, 25);
            this.lblCutomerID.TabIndex = 5;
            this.lblCutomerID.Text = "C001";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(165, 122);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(148, 25);
            this.lblCustomerEmail.TabIndex = 4;
            this.lblCustomerEmail.Text = "Ajith@gmail.com";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(496, 57);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(170, 25);
            this.lblPaymentMethod.TabIndex = 3;
            this.lblPaymentMethod.Text = "Payments Method : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(20, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email : ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(165, 57);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 25);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Ajith Kumar";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnPaid);
            this.panel1.Controls.Add(this.btnDelivered);
            this.panel1.Controls.Add(this.lblOrderDetails);
            this.panel1.Location = new System.Drawing.Point(133, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 297);
            this.panel1.TabIndex = 0;
            // 
            // btnPaid
            // 
            this.btnPaid.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPaid.FlatAppearance.BorderSize = 0;
            this.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.ForeColor = System.Drawing.Color.White;
            this.btnPaid.Location = new System.Drawing.Point(881, 6);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(116, 36);
            this.btnPaid.TabIndex = 3;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = false;
            // 
            // btnDelivered
            // 
            this.btnDelivered.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelivered.FlatAppearance.BorderSize = 0;
            this.btnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivered.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivered.ForeColor = System.Drawing.Color.White;
            this.btnDelivered.Location = new System.Drawing.Point(745, 6);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(116, 36);
            this.btnDelivered.TabIndex = 2;
            this.btnDelivered.Text = "Delivered";
            this.btnDelivered.UseVisualStyleBackColor = false;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(392, 12);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(151, 30);
            this.lblOrderDetails.TabIndex = 0;
            this.lblOrderDetails.Text = "Order Details";
            // 
            // UcOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "UcOrderDetails";
            this.Size = new System.Drawing.Size(1276, 984);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Button btnDelivered;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCustomerInformation;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCutomerID;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblShippping;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalSubTotal;
        private System.Windows.Forms.Label lblShippingCost;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.TextBox txtReviewComment;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbRating;
    }
}
