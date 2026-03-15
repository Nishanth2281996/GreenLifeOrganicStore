namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    partial class UcBrowseProducts
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panelFilterBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFilterBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(26, 31);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(171, 28);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.Text = "   All";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(21, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(97, 25);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category :";
            // 
            // panelFilterBar
            // 
            this.panelFilterBar.BackColor = System.Drawing.Color.White;
            this.panelFilterBar.Controls.Add(this.txtSearch);
            this.panelFilterBar.Controls.Add(this.cmbCategory);
            this.panelFilterBar.Controls.Add(this.lblCategory);
            this.panelFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterBar.Location = new System.Drawing.Point(0, 0);
            this.panelFilterBar.Name = "panelFilterBar";
            this.panelFilterBar.Size = new System.Drawing.Size(1306, 75);
            this.panelFilterBar.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(237, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = " Search Products";
            this.txtSearch.Click += new System.EventHandler(this.txtSearchProduct_Enter);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProducts.Location = new System.Drawing.Point(0, 75);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1306, 649);
            this.flpProducts.TabIndex = 2;
            // 
            // UcBrowseProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.panelFilterBar);
            this.Name = "UcBrowseProducts";
            this.Size = new System.Drawing.Size(1306, 724);
            this.panelFilterBar.ResumeLayout(false);
            this.panelFilterBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel panelFilterBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
    }
}
