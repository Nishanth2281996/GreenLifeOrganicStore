namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    partial class UcAdminCategories
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
            this.splitCategories = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategoryDetails = new System.Windows.Forms.Label();
            this.dgvCatagories = new System.Windows.Forms.DataGridView();
            this.panelCategoryList = new System.Windows.Forms.Panel();
            this.txtSearchbox = new System.Windows.Forms.TextBox();
            this.lblCatgoryList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitCategories)).BeginInit();
            this.splitCategories.Panel1.SuspendLayout();
            this.splitCategories.Panel2.SuspendLayout();
            this.splitCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagories)).BeginInit();
            this.panelCategoryList.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitCategories
            // 
            this.splitCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCategories.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitCategories.Location = new System.Drawing.Point(0, 0);
            this.splitCategories.Name = "splitCategories";
            // 
            // splitCategories.Panel1
            // 
            this.splitCategories.Panel1.Controls.Add(this.btnDelete);
            this.splitCategories.Panel1.Controls.Add(this.btnUpdate);
            this.splitCategories.Panel1.Controls.Add(this.btnAdd);
            this.splitCategories.Panel1.Controls.Add(this.txtCategoryName);
            this.splitCategories.Panel1.Controls.Add(this.lblCategoryName);
            this.splitCategories.Panel1.Controls.Add(this.txtCategoryID);
            this.splitCategories.Panel1.Controls.Add(this.lblCategoryID);
            this.splitCategories.Panel1.Controls.Add(this.lblCategoryDetails);
            this.splitCategories.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitCategories_Panel1_Paint);
            // 
            // splitCategories.Panel2
            // 
            this.splitCategories.Panel2.Controls.Add(this.dgvCatagories);
            this.splitCategories.Panel2.Controls.Add(this.panelCategoryList);
            this.splitCategories.Size = new System.Drawing.Size(1240, 759);
            this.splitCategories.SplitterDistance = 300;
            this.splitCategories.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(74, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(151, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(29, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(22, 202);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(260, 31);
            this.txtCategoryName.TabIndex = 2;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(17, 159);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(150, 25);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Name : ";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.Location = new System.Drawing.Point(22, 110);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(260, 31);
            this.txtCategoryID.TabIndex = 0;
            this.txtCategoryID.Text = "Auto-generated";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryID.Location = new System.Drawing.Point(17, 67);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(121, 25);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "Category ID : ";
            // 
            // lblCategoryDetails
            // 
            this.lblCategoryDetails.AutoSize = true;
            this.lblCategoryDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryDetails.Location = new System.Drawing.Point(69, 10);
            this.lblCategoryDetails.Name = "lblCategoryDetails";
            this.lblCategoryDetails.Size = new System.Drawing.Size(177, 30);
            this.lblCategoryDetails.TabIndex = 0;
            this.lblCategoryDetails.Text = "Catagory Details";
            // 
            // dgvCatagories
            // 
            this.dgvCatagories.AllowUserToAddRows = false;
            this.dgvCatagories.AllowUserToDeleteRows = false;
            this.dgvCatagories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatagories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatagories.Location = new System.Drawing.Point(0, 56);
            this.dgvCatagories.Name = "dgvCatagories";
            this.dgvCatagories.ReadOnly = true;
            this.dgvCatagories.RowHeadersWidth = 62;
            this.dgvCatagories.RowTemplate.Height = 28;
            this.dgvCatagories.Size = new System.Drawing.Size(934, 701);
            this.dgvCatagories.TabIndex = 2;
            this.dgvCatagories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatagories_CellClick);
            // 
            // panelCategoryList
            // 
            this.panelCategoryList.BackColor = System.Drawing.Color.White;
            this.panelCategoryList.Controls.Add(this.txtSearchbox);
            this.panelCategoryList.Controls.Add(this.lblCatgoryList);
            this.panelCategoryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategoryList.Location = new System.Drawing.Point(0, 0);
            this.panelCategoryList.Name = "panelCategoryList";
            this.panelCategoryList.Size = new System.Drawing.Size(934, 56);
            this.panelCategoryList.TabIndex = 1;
            this.panelCategoryList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCategoryList_Paint);
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
            this.txtSearchbox.Text = "   Search Categories";
            this.txtSearchbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchbox_MouseClick);
            this.txtSearchbox.TextChanged += new System.EventHandler(this.txtSearchbox_TextChanged);
           
            // 
            // lblCatgoryList
            // 
            this.lblCatgoryList.AutoSize = true;
            this.lblCatgoryList.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatgoryList.Location = new System.Drawing.Point(28, 10);
            this.lblCatgoryList.Name = "lblCatgoryList";
            this.lblCatgoryList.Size = new System.Drawing.Size(144, 30);
            this.lblCatgoryList.TabIndex = 1;
            this.lblCatgoryList.Text = "Category List";
            // 
            // UcAdminCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.splitCategories);
            this.Name = "UcAdminCategories";
            this.Size = new System.Drawing.Size(1240, 759);
            this.splitCategories.Panel1.ResumeLayout(false);
            this.splitCategories.Panel1.PerformLayout();
            this.splitCategories.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCategories)).EndInit();
            this.splitCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagories)).EndInit();
            this.panelCategoryList.ResumeLayout(false);
            this.panelCategoryList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCategories;
        private System.Windows.Forms.Label lblCategoryDetails;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Panel panelCategoryList;
        private System.Windows.Forms.TextBox txtSearchbox;
        private System.Windows.Forms.Label lblCatgoryList;
        private System.Windows.Forms.DataGridView dgvCatagories;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
