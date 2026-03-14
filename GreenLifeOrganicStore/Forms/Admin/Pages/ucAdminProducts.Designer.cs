namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    partial class UcAdminProducts
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
            this.SplitProducts = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProductList = new System.Windows.Forms.Panel();
            this.txtSearchbox = new System.Windows.Forms.TextBox();
            this.lblProductList = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitProducts)).BeginInit();
            this.SplitProducts.Panel1.SuspendLayout();
            this.SplitProducts.Panel2.SuspendLayout();
            this.SplitProducts.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelProductList.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitProducts
            // 
            this.SplitProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitProducts.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitProducts.Location = new System.Drawing.Point(0, 0);
            this.SplitProducts.Name = "SplitProducts";
            // 
            // SplitProducts.Panel1
            // 
            this.SplitProducts.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.SplitProducts.Panel1.Controls.Add(this.txtDescription);
            this.SplitProducts.Panel1.Controls.Add(this.txtStockQuantity);
            this.SplitProducts.Panel1.Controls.Add(this.txtPrice);
            this.SplitProducts.Panel1.Controls.Add(this.cmbSupplier);
            this.SplitProducts.Panel1.Controls.Add(this.cmbCatagory);
            this.SplitProducts.Panel1.Controls.Add(this.lblDescription);
            this.SplitProducts.Panel1.Controls.Add(this.lblStockQuantity);
            this.SplitProducts.Panel1.Controls.Add(this.lblPrice);
            this.SplitProducts.Panel1.Controls.Add(this.label2);
            this.SplitProducts.Panel1.Controls.Add(this.lblCategory);
            this.SplitProducts.Panel1.Controls.Add(this.txtProductName);
            this.SplitProducts.Panel1.Controls.Add(this.lblProductName);
            this.SplitProducts.Panel1.Controls.Add(this.txtProductID);
            this.SplitProducts.Panel1.Controls.Add(this.lblProductId);
            this.SplitProducts.Panel1.Controls.Add(this.lblProductDetails);
            this.SplitProducts.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitProducts_Panel1_Paint);
            // 
            // SplitProducts.Panel2
            // 
            this.SplitProducts.Panel2.Controls.Add(this.dgvProducts);
            this.SplitProducts.Panel2.Controls.Add(this.panelProductList);
            this.SplitProducts.Size = new System.Drawing.Size(1272, 931);
            this.SplitProducts.SplitterDistance = 300;
            this.SplitProducts.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 801);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(258, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(17, 650);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(262, 133);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQuantity.Location = new System.Drawing.Point(17, 560);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(262, 31);
            this.txtStockQuantity.TabIndex = 12;
            this.txtStockQuantity.TextChanged += new System.EventHandler(this.txtStockQuantity_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(17, 470);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(262, 31);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "Supplier 1",
            "Supplier 2 ",
            "Supplier 3"});
            this.cmbSupplier.Location = new System.Drawing.Point(17, 378);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(262, 33);
            this.cmbSupplier.TabIndex = 10;
            this.cmbSupplier.Text = "Select Supplier ";
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Items.AddRange(new object[] {
            "Carrot ",
            "Brocoli",
            "Apple"});
            this.cmbCatagory.Location = new System.Drawing.Point(17, 286);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(262, 33);
            this.cmbCatagory.TabIndex = 9;
            this.cmbCatagory.Text = "Select Category";
            this.cmbCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(14, 608);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(116, 25);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description : ";
            this.lblDescription.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQuantity.Location = new System.Drawing.Point(12, 518);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(142, 25);
            this.lblStockQuantity.TabIndex = 7;
            this.lblStockQuantity.Text = "Stock Quantity : ";
            this.lblStockQuantity.Click += new System.EventHandler(this.lblStockQuantity_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(12, 428);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 25);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price : ";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Supplier : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(12, 244);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 25);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category : ";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(17, 196);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(262, 31);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(12, 154);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(140, 25);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name : ";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.ForeColor = System.Drawing.Color.Gray;
            this.txtProductID.Location = new System.Drawing.Point(17, 106);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(262, 31);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.Text = "Auto-generated";
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(12, 64);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(111, 25);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "Product ID : ";
            this.lblProductId.Click += new System.EventHandler(this.lblProductId_Click);
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.Location = new System.Drawing.Point(56, 12);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(165, 30);
            this.lblProductDetails.TabIndex = 0;
            this.lblProductDetails.Text = "Product Details";
            this.lblProductDetails.Click += new System.EventHandler(this.lblProductDetails_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 56);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(966, 873);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panelProductList
            // 
            this.panelProductList.BackColor = System.Drawing.Color.White;
            this.panelProductList.Controls.Add(this.txtSearchbox);
            this.panelProductList.Controls.Add(this.lblProductList);
            this.panelProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductList.Location = new System.Drawing.Point(0, 0);
            this.panelProductList.Name = "panelProductList";
            this.panelProductList.Size = new System.Drawing.Size(966, 56);
            this.panelProductList.TabIndex = 0;
            this.panelProductList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProductList_Paint);
            // 
            // txtSearchbox
            // 
            this.txtSearchbox.BackColor = System.Drawing.Color.White;
            this.txtSearchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSearchbox.Location = new System.Drawing.Point(599, 13);
            this.txtSearchbox.Name = "txtSearchbox";
            this.txtSearchbox.Size = new System.Drawing.Size(261, 31);
            this.txtSearchbox.TabIndex = 1;
            this.txtSearchbox.Text = "   Search Products";
            this.txtSearchbox.TextChanged += new System.EventHandler(this.txtSearchbox_TextChanged);
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(28, 10);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(131, 30);
            this.lblProductList.TabIndex = 1;
            this.lblProductList.Text = "Product List";
            this.lblProductList.Click += new System.EventHandler(this.lblProductList_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(132, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 44);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 44);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(132, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UcAdminProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.SplitProducts);
            this.Name = "UcAdminProducts";
            this.Size = new System.Drawing.Size(1272, 931);
            this.SplitProducts.Panel1.ResumeLayout(false);
            this.SplitProducts.Panel1.PerformLayout();
            this.SplitProducts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitProducts)).EndInit();
            this.SplitProducts.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelProductList.ResumeLayout(false);
            this.panelProductList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitProducts;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panelProductList;
        private System.Windows.Forms.TextBox txtSearchbox;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}
