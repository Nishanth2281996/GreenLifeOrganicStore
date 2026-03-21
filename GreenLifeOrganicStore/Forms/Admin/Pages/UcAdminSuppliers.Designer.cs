namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    partial class UcAdminSuppliers
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
            this.splitSupplier = new System.Windows.Forms.SplitContainer();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupppierId = new System.Windows.Forms.Label();
            this.lblSupplierDetails = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.dgvSupplierList = new System.Windows.Forms.DataGridView();
            this.panelSupplierList = new System.Windows.Forms.Panel();
            this.txtSearchbox = new System.Windows.Forms.TextBox();
            this.lblSupplierList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitSupplier)).BeginInit();
            this.splitSupplier.Panel1.SuspendLayout();
            this.splitSupplier.Panel2.SuspendLayout();
            this.splitSupplier.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).BeginInit();
            this.panelSupplierList.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitSupplier
            // 
            this.splitSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSupplier.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitSupplier.Location = new System.Drawing.Point(0, 0);
            this.splitSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitSupplier.Name = "splitSupplier";
            // 
            // splitSupplier.Panel1
            // 
            this.splitSupplier.Panel1.Controls.Add(this.txtPhone);
            this.splitSupplier.Panel1.Controls.Add(this.txtEmail);
            this.splitSupplier.Panel1.Controls.Add(this.lblDescription);
            this.splitSupplier.Panel1.Controls.Add(this.lblPhone);
            this.splitSupplier.Panel1.Controls.Add(this.lblEmail);
            this.splitSupplier.Panel1.Controls.Add(this.txtSupplierName);
            this.splitSupplier.Panel1.Controls.Add(this.lblSupplierName);
            this.splitSupplier.Panel1.Controls.Add(this.lblSupppierId);
            this.splitSupplier.Panel1.Controls.Add(this.lblSupplierDetails);
            this.splitSupplier.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitSupplier.Panel1.Controls.Add(this.txtAddress);
            this.splitSupplier.Panel1.Controls.Add(this.txtSupplierID);
            // 
            // splitSupplier.Panel2
            // 
            this.splitSupplier.Panel2.Controls.Add(this.dgvSupplierList);
            this.splitSupplier.Panel2.Controls.Add(this.panelSupplierList);
            this.splitSupplier.Size = new System.Drawing.Size(1453, 648);
            this.splitSupplier.SplitterDistance = 300;
            this.splitSupplier.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(24, 328);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(262, 31);
            this.txtPhone.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(24, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 31);
            this.txtEmail.TabIndex = 28;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(21, 368);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 25);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Address : ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(19, 294);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(151, 25);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone Number  : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(19, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 25);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email  : ";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(21, 168);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(262, 31);
            this.txtSupplierName.TabIndex = 20;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(16, 134);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(143, 25);
            this.lblSupplierName.TabIndex = 19;
            this.lblSupplierName.Text = "Supplier Name : ";
            // 
            // lblSupppierId
            // 
            this.lblSupppierId.AutoSize = true;
            this.lblSupppierId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupppierId.Location = new System.Drawing.Point(16, 60);
            this.lblSupppierId.Name = "lblSupppierId";
            this.lblSupppierId.Size = new System.Drawing.Size(114, 25);
            this.lblSupppierId.TabIndex = 18;
            this.lblSupppierId.Text = "Supplier ID : ";
            // 
            // lblSupplierDetails
            // 
            this.lblSupplierDetails.AutoSize = true;
            this.lblSupplierDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierDetails.Location = new System.Drawing.Point(70, 10);
            this.lblSupplierDetails.Name = "lblSupplierDetails";
            this.lblSupplierDetails.Size = new System.Drawing.Size(170, 30);
            this.lblSupplierDetails.TabIndex = 15;
            this.lblSupplierDetails.Text = "Supplier Details";
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 509);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(258, 100);
            this.tableLayoutPanel2.TabIndex = 17;
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
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 44);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(132, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 44);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(24, 402);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 71);
            this.txtAddress.TabIndex = 30;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierID.ForeColor = System.Drawing.Color.Gray;
            this.txtSupplierID.Location = new System.Drawing.Point(21, 94);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(262, 31);
            this.txtSupplierID.TabIndex = 16;
            this.txtSupplierID.Text = "Auto-generated";
            // 
            // dgvSupplierList
            // 
            this.dgvSupplierList.AllowUserToAddRows = false;
            this.dgvSupplierList.AllowUserToDeleteRows = false;
            this.dgvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplierList.Location = new System.Drawing.Point(0, 56);
            this.dgvSupplierList.Name = "dgvSupplierList";
            this.dgvSupplierList.ReadOnly = true;
            this.dgvSupplierList.RowHeadersWidth = 62;
            this.dgvSupplierList.RowTemplate.Height = 28;
            this.dgvSupplierList.Size = new System.Drawing.Size(1147, 590);
            this.dgvSupplierList.TabIndex = 2;
            this.dgvSupplierList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierList_CellClick);
            // 
            // panelSupplierList
            // 
            this.panelSupplierList.BackColor = System.Drawing.Color.White;
            this.panelSupplierList.Controls.Add(this.txtSearchbox);
            this.panelSupplierList.Controls.Add(this.lblSupplierList);
            this.panelSupplierList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupplierList.Location = new System.Drawing.Point(0, 0);
            this.panelSupplierList.Name = "panelSupplierList";
            this.panelSupplierList.Size = new System.Drawing.Size(1147, 56);
            this.panelSupplierList.TabIndex = 1;
            // 
            // txtSearchbox
            // 
            this.txtSearchbox.BackColor = System.Drawing.Color.White;
            this.txtSearchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSearchbox.Location = new System.Drawing.Point(557, 12);
            this.txtSearchbox.Name = "txtSearchbox";
            this.txtSearchbox.Size = new System.Drawing.Size(261, 31);
            this.txtSearchbox.TabIndex = 1;
            this.txtSearchbox.Text = "   Search Supplier";
            this.txtSearchbox.Click += new System.EventHandler(this.txtSearchbox_Enter);
            this.txtSearchbox.TextChanged += new System.EventHandler(this.txtSearchbox_TextChanged);
            // 
            // lblSupplierList
            // 
            this.lblSupplierList.AutoSize = true;
            this.lblSupplierList.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierList.Location = new System.Drawing.Point(28, 10);
            this.lblSupplierList.Name = "lblSupplierList";
            this.lblSupplierList.Size = new System.Drawing.Size(136, 30);
            this.lblSupplierList.TabIndex = 1;
            this.lblSupplierList.Text = "Supplier List";
            // 
            // UcAdminSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.splitSupplier);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcAdminSuppliers";
            this.Size = new System.Drawing.Size(1453, 648);
            this.splitSupplier.Panel1.ResumeLayout(false);
            this.splitSupplier.Panel1.PerformLayout();
            this.splitSupplier.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSupplier)).EndInit();
            this.splitSupplier.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).EndInit();
            this.panelSupplierList.ResumeLayout(false);
            this.panelSupplierList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitSupplier;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupppierId;
        private System.Windows.Forms.Label lblSupplierDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.DataGridView dgvSupplierList;
        private System.Windows.Forms.Panel panelSupplierList;
        private System.Windows.Forms.TextBox txtSearchbox;
        private System.Windows.Forms.Label lblSupplierList;
        private System.Windows.Forms.Button btnCancel;
    }
}
