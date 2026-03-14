namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    partial class UcAdminOrders
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
            this.panelProductList = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtSearchbox = new System.Windows.Forms.TextBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panelProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProductList
            // 
            this.panelProductList.BackColor = System.Drawing.Color.White;
            this.panelProductList.Controls.Add(this.cmbStatus);
            this.panelProductList.Controls.Add(this.txtSearchbox);
            this.panelProductList.Controls.Add(this.lblOrderList);
            this.panelProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductList.Location = new System.Drawing.Point(0, 0);
            this.panelProductList.Name = "panelProductList";
            this.panelProductList.Size = new System.Drawing.Size(1122, 56);
            this.panelProductList.TabIndex = 2;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(585, 15);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(164, 28);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.Text = "   All Status";
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // txtSearchbox
            // 
            this.txtSearchbox.BackColor = System.Drawing.Color.White;
            this.txtSearchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSearchbox.Location = new System.Drawing.Point(801, 12);
            this.txtSearchbox.Name = "txtSearchbox";
            this.txtSearchbox.Size = new System.Drawing.Size(261, 31);
            this.txtSearchbox.TabIndex = 1;
            this.txtSearchbox.Text = "   Search Orders";
            this.txtSearchbox.Click += new System.EventHandler(this.txtSearchOrder_Enter);
            this.txtSearchbox.TextChanged += new System.EventHandler(this.txtSearchOrder_TextChanged);
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.Location = new System.Drawing.Point(28, 10);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(111, 30);
            this.lblOrderList.TabIndex = 1;
            this.lblOrderList.Text = "Order List";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 56);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(1122, 669);
            this.dgvOrders.TabIndex = 3;
            // 
            // UcAdminOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.panelProductList);
            this.Name = "UcAdminOrders";
            this.Size = new System.Drawing.Size(1122, 725);
            this.panelProductList.ResumeLayout(false);
            this.panelProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductList;
        private System.Windows.Forms.TextBox txtSearchbox;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}
