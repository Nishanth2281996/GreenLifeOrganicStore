namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    partial class UcMyOrders
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
            this.flpAllOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAllOrders = new System.Windows.Forms.ComboBox();
            this.lblOrderHistory = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblMyOrders = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flpAllOrders);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.lblSubtitle);
            this.panelMain.Controls.Add(this.lblMyOrders);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1210, 688);
            this.panelMain.TabIndex = 0;
            // 
            // flpAllOrders
            // 
            this.flpAllOrders.AutoScroll = true;
            this.flpAllOrders.BackColor = System.Drawing.Color.White;
            this.flpAllOrders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAllOrders.Location = new System.Drawing.Point(248, 113);
            this.flpAllOrders.Name = "flpAllOrders";
            this.flpAllOrders.Size = new System.Drawing.Size(706, 500);
            this.flpAllOrders.TabIndex = 3;
            this.flpAllOrders.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.cmbAllOrders);
            this.panel1.Controls.Add(this.lblOrderHistory);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(248, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 45);
            this.panel1.TabIndex = 2;
            // 
            // cmbAllOrders
            // 
            this.cmbAllOrders.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAllOrders.FormattingEnabled = true;
            this.cmbAllOrders.Location = new System.Drawing.Point(488, 9);
            this.cmbAllOrders.Name = "cmbAllOrders";
            this.cmbAllOrders.Size = new System.Drawing.Size(196, 29);
            this.cmbAllOrders.TabIndex = 3;
            this.cmbAllOrders.Text = " All Orders";
            // 
            // lblOrderHistory
            // 
            this.lblOrderHistory.AutoSize = true;
            this.lblOrderHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHistory.Location = new System.Drawing.Point(9, 9);
            this.lblOrderHistory.Name = "lblOrderHistory";
            this.lblOrderHistory.Size = new System.Drawing.Size(129, 25);
            this.lblOrderHistory.TabIndex = 3;
            this.lblOrderHistory.Text = "Order History";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubtitle.Location = new System.Drawing.Point(243, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(275, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "View and track your order history";
            // 
            // lblMyOrders
            // 
            this.lblMyOrders.AutoSize = true;
            this.lblMyOrders.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyOrders.Location = new System.Drawing.Point(241, 0);
            this.lblMyOrders.Name = "lblMyOrders";
            this.lblMyOrders.Size = new System.Drawing.Size(154, 38);
            this.lblMyOrders.TabIndex = 0;
            this.lblMyOrders.Text = "My Orders";
            // 
            // UcMyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelMain);
            this.Name = "UcMyOrders";
            this.Size = new System.Drawing.Size(1210, 688);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblMyOrders;
        private System.Windows.Forms.Label lblOrderHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpAllOrders;
        private System.Windows.Forms.ComboBox cmbAllOrders;
    }
}
