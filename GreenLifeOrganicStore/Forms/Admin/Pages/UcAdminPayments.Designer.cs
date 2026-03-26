namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    partial class UcAdminPayments
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.panelPaymentHistory = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblPaymentHistory = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.TableLayoutPanel();
            this.panelTotalPayments = new System.Windows.Forms.Panel();
            this.lblTotalPaymentsNumber = new System.Windows.Forms.Label();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.panelCompletedAmount = new System.Windows.Forms.Panel();
            this.lblCompletedTotalAmount = new System.Windows.Forms.Label();
            this.lblCompletedAmount = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.panelPaymentHistory.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.panelTotalPayments.SuspendLayout();
            this.panelCompletedAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.dgvPayments);
            this.panelMain.Controls.Add(this.panelPaymentHistory);
            this.panelMain.Controls.Add(this.panelPayment);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1322, 728);
            this.panelMain.TabIndex = 3;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(0, 187);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 62;
            this.dgvPayments.RowTemplate.Height = 28;
            this.dgvPayments.Size = new System.Drawing.Size(1322, 541);
            this.dgvPayments.TabIndex = 4;
            this.dgvPayments.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellValueChanged);
            this.dgvPayments.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPayments_CurrentCellDirtyStateChanged);
            // 
            // panelPaymentHistory
            // 
            this.panelPaymentHistory.BackColor = System.Drawing.Color.White;
            this.panelPaymentHistory.Controls.Add(this.btnDownload);
            this.panelPaymentHistory.Controls.Add(this.lblPaymentHistory);
            this.panelPaymentHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaymentHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPaymentHistory.Location = new System.Drawing.Point(0, 123);
            this.panelPaymentHistory.Name = "panelPaymentHistory";
            this.panelPaymentHistory.Size = new System.Drawing.Size(1322, 64);
            this.panelPaymentHistory.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.DarkRed;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDownload.Location = new System.Drawing.Point(1067, 18);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(124, 36);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblPaymentHistory
            // 
            this.lblPaymentHistory.AutoSize = true;
            this.lblPaymentHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHistory.Location = new System.Drawing.Point(20, 19);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Size = new System.Drawing.Size(177, 30);
            this.lblPaymentHistory.TabIndex = 0;
            this.lblPaymentHistory.Text = "Payment History";
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPayment.ColumnCount = 2;
            this.panelPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelPayment.Controls.Add(this.panelTotalPayments, 0, 0);
            this.panelPayment.Controls.Add(this.panelCompletedAmount, 1, 0);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPayment.Location = new System.Drawing.Point(0, 0);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.RowCount = 1;
            this.panelPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPayment.Size = new System.Drawing.Size(1322, 123);
            this.panelPayment.TabIndex = 2;
            // 
            // panelTotalPayments
            // 
            this.panelTotalPayments.BackColor = System.Drawing.Color.White;
            this.panelTotalPayments.Controls.Add(this.lblTotalPaymentsNumber);
            this.panelTotalPayments.Controls.Add(this.lblTotalPayments);
            this.panelTotalPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalPayments.Location = new System.Drawing.Point(3, 3);
            this.panelTotalPayments.Name = "panelTotalPayments";
            this.panelTotalPayments.Size = new System.Drawing.Size(655, 117);
            this.panelTotalPayments.TabIndex = 0;
            // 
            // lblTotalPaymentsNumber
            // 
            this.lblTotalPaymentsNumber.AutoSize = true;
            this.lblTotalPaymentsNumber.BackColor = System.Drawing.Color.White;
            this.lblTotalPaymentsNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentsNumber.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPaymentsNumber.Location = new System.Drawing.Point(156, 56);
            this.lblTotalPaymentsNumber.Name = "lblTotalPaymentsNumber";
            this.lblTotalPaymentsNumber.Size = new System.Drawing.Size(32, 38);
            this.lblTotalPaymentsNumber.TabIndex = 1;
            this.lblTotalPaymentsNumber.Text = "8";
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.AutoSize = true;
            this.lblTotalPayments.Location = new System.Drawing.Point(105, 14);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(157, 30);
            this.lblTotalPayments.TabIndex = 0;
            this.lblTotalPayments.Text = "Total Payments";
            // 
            // panelCompletedAmount
            // 
            this.panelCompletedAmount.BackColor = System.Drawing.Color.White;
            this.panelCompletedAmount.Controls.Add(this.lblCompletedTotalAmount);
            this.panelCompletedAmount.Controls.Add(this.lblCompletedAmount);
            this.panelCompletedAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCompletedAmount.Location = new System.Drawing.Point(664, 3);
            this.panelCompletedAmount.Name = "panelCompletedAmount";
            this.panelCompletedAmount.Size = new System.Drawing.Size(655, 117);
            this.panelCompletedAmount.TabIndex = 1;
            // 
            // lblCompletedTotalAmount
            // 
            this.lblCompletedTotalAmount.AutoSize = true;
            this.lblCompletedTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblCompletedTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTotalAmount.ForeColor = System.Drawing.Color.Green;
            this.lblCompletedTotalAmount.Location = new System.Drawing.Point(146, 56);
            this.lblCompletedTotalAmount.Name = "lblCompletedTotalAmount";
            this.lblCompletedTotalAmount.Size = new System.Drawing.Size(107, 38);
            this.lblCompletedTotalAmount.TabIndex = 3;
            this.lblCompletedTotalAmount.Text = "100000";
            // 
            // lblCompletedAmount
            // 
            this.lblCompletedAmount.AutoSize = true;
            this.lblCompletedAmount.Location = new System.Drawing.Point(115, 18);
            this.lblCompletedAmount.Name = "lblCompletedAmount";
            this.lblCompletedAmount.Size = new System.Drawing.Size(204, 30);
            this.lblCompletedAmount.TabIndex = 2;
            this.lblCompletedAmount.Text = "Completed Amount";
            // 
            // UcAdminPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "UcAdminPayments";
            this.Size = new System.Drawing.Size(1322, 728);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.panelPaymentHistory.ResumeLayout(false);
            this.panelPaymentHistory.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelTotalPayments.ResumeLayout(false);
            this.panelTotalPayments.PerformLayout();
            this.panelCompletedAmount.ResumeLayout(false);
            this.panelCompletedAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelPaymentHistory;
        private System.Windows.Forms.Label lblPaymentHistory;
        private System.Windows.Forms.TableLayoutPanel panelPayment;
        private System.Windows.Forms.Panel panelTotalPayments;
        private System.Windows.Forms.Label lblTotalPaymentsNumber;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Panel panelCompletedAmount;
        private System.Windows.Forms.Label lblCompletedTotalAmount;
        private System.Windows.Forms.Label lblCompletedAmount;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnDownload;
    }
}
