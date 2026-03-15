namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    partial class UcCartCheckout
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
            this.panelCartCard = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCardTitle = new System.Windows.Forms.Label();
            this.panelCartLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShippingAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.lblDiscountNumber = new System.Windows.Forms.Label();
            this.lblShippingNumber = new System.Windows.Forms.Label();
            this.lblSubtotalNumber = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblSummarySubtoal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCartCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCartCard
            // 
            this.panelCartCard.BackColor = System.Drawing.Color.White;
            this.panelCartCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCartCard.Controls.Add(this.dgvCart);
            this.panelCartCard.Controls.Add(this.panel1);
            this.panelCartCard.Controls.Add(this.panelCartLeft);
            this.panelCartCard.Location = new System.Drawing.Point(3, 21);
            this.panelCartCard.Name = "panelCartCard";
            this.panelCartCard.Size = new System.Drawing.Size(718, 300);
            this.panelCartCard.TabIndex = 0;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colPrice,
            this.colQuantity,
            this.colSubtotal,
            this.colAction});
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(0, 52);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.RowTemplate.Height = 28;
            this.dgvCart.Size = new System.Drawing.Size(716, 246);
            this.dgvCart.TabIndex = 3;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Product";
            this.colProductName.MinimumWidth = 8;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 150;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 150;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 8;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 150;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.MinimumWidth = 8;
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.labelCardTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 52);
            this.panel1.TabIndex = 1;
            // 
            // labelCardTitle
            // 
            this.labelCardTitle.AutoSize = true;
            this.labelCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardTitle.Location = new System.Drawing.Point(14, 13);
            this.labelCardTitle.Name = "labelCardTitle";
            this.labelCardTitle.Size = new System.Drawing.Size(132, 25);
            this.labelCardTitle.TabIndex = 2;
            this.labelCardTitle.Text = "Shopping Cart";
            // 
            // panelCartLeft
            // 
            this.panelCartLeft.BackColor = System.Drawing.Color.White;
            this.panelCartLeft.Location = new System.Drawing.Point(817, 422);
            this.panelCartLeft.Name = "panelCartLeft";
            this.panelCartLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panelCartLeft.Size = new System.Drawing.Size(200, 100);
            this.panelCartLeft.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCheckout);
            this.panel2.Controls.Add(this.cmbPaymentMethod);
            this.panel2.Controls.Add(this.lblPaymentMethod);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtShippingAddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTotalNumber);
            this.panel2.Controls.Add(this.lblDiscountNumber);
            this.panel2.Controls.Add(this.lblShippingNumber);
            this.panel2.Controls.Add(this.lblSubtotalNumber);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.panelLine1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Controls.Add(this.lblShipping);
            this.panel2.Controls.Add(this.lblSummarySubtoal);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(748, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 482);
            this.panel2.TabIndex = 2;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(18, 416);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(326, 41);
            this.btnCheckout.TabIndex = 16;
            this.btnCheckout.Text = "Proceed to Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnProceedCheckout_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(25, 366);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(319, 33);
            this.cmbPaymentMethod.TabIndex = 15;
            this.cmbPaymentMethod.Text = "Select the payment Method";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(15, 329);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(174, 25);
            this.lblPaymentMethod.TabIndex = 14;
            this.lblPaymentMethod.Text = "Payment Method : ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(21, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 2);
            this.panel5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, -11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount : ";
            // 
            // txtShippingAddress
            // 
            this.txtShippingAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShippingAddress.Location = new System.Drawing.Point(19, 223);
            this.txtShippingAddress.Multiline = true;
            this.txtShippingAddress.Name = "txtShippingAddress";
            this.txtShippingAddress.Size = new System.Drawing.Size(325, 72);
            this.txtShippingAddress.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Shipping Address : ";
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumber.Location = new System.Drawing.Point(246, 157);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(52, 25);
            this.lblTotalNumber.TabIndex = 10;
            this.lblTotalNumber.Text = "1000";
            // 
            // lblDiscountNumber
            // 
            this.lblDiscountNumber.AutoSize = true;
            this.lblDiscountNumber.Location = new System.Drawing.Point(246, 119);
            this.lblDiscountNumber.Name = "lblDiscountNumber";
            this.lblDiscountNumber.Size = new System.Drawing.Size(49, 25);
            this.lblDiscountNumber.TabIndex = 9;
            this.lblDiscountNumber.Text = "-100";
            // 
            // lblShippingNumber
            // 
            this.lblShippingNumber.AutoSize = true;
            this.lblShippingNumber.Location = new System.Drawing.Point(246, 80);
            this.lblShippingNumber.Name = "lblShippingNumber";
            this.lblShippingNumber.Size = new System.Drawing.Size(47, 25);
            this.lblShippingNumber.TabIndex = 8;
            this.lblShippingNumber.Text = " 300";
            // 
            // lblSubtotalNumber
            // 
            this.lblSubtotalNumber.AutoSize = true;
            this.lblSubtotalNumber.Location = new System.Drawing.Point(246, 45);
            this.lblSubtotalNumber.Name = "lblSubtotalNumber";
            this.lblSubtotalNumber.Size = new System.Drawing.Size(52, 25);
            this.lblSubtotalNumber.TabIndex = 7;
            this.lblSubtotalNumber.Text = "1000";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(14, 157);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total : ";
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.Black;
            this.panelLine1.Location = new System.Drawing.Point(16, 147);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(459, 2);
            this.panelLine1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(191, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 1);
            this.panel4.TabIndex = 4;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(15, 119);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(96, 25);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount : ";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(14, 80);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(97, 25);
            this.lblShipping.TabIndex = 2;
            this.lblShipping.Text = "Shipping : ";
            // 
            // lblSummarySubtoal
            // 
            this.lblSummarySubtoal.AutoSize = true;
            this.lblSummarySubtoal.Location = new System.Drawing.Point(14, 45);
            this.lblSummarySubtoal.Name = "lblSummarySubtoal";
            this.lblSummarySubtoal.Size = new System.Drawing.Size(93, 25);
            this.lblSummarySubtoal.TabIndex = 1;
            this.lblSummarySubtoal.Text = "Subtotal : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 40);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Summary";
            // 
            // UcCartCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCartCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcCartCheckout";
            this.Size = new System.Drawing.Size(1158, 609);
            this.Load += new System.EventHandler(this.UcCartCheckout_Load);
            this.panelCartCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCartCard;
        private System.Windows.Forms.Panel panelCartLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCardTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblSummarySubtoal;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblShippingNumber;
        private System.Windows.Forms.Label lblSubtotalNumber;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscountNumber;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.TextBox txtShippingAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
    }
}
