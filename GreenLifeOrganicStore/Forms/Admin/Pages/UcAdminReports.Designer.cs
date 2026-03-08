namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    partial class UcAdminReports
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
            this.panelReportMain = new System.Windows.Forms.Panel();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabSalesReport = new System.Windows.Forms.TabPage();
            this.tabStockReport = new System.Windows.Forms.TabPage();
            this.tabCustomerOrders = new System.Windows.Forms.TabPage();
            this.lblGenerate = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tableSalesReport = new System.Windows.Forms.TableLayoutPanel();
            this.panelTotalSales = new System.Windows.Forms.Panel();
            this.panelTotalOrders = new System.Windows.Forms.Panel();
            this.panelAverageOrderValue = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalSalesNumbers = new System.Windows.Forms.Label();
            this.lblTotalOrdersCount = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.lblAverageOrderValue = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvStockReport = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.panelReportMain.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabSalesReport.SuspendLayout();
            this.tabStockReport.SuspendLayout();
            this.tabCustomerOrders.SuspendLayout();
            this.tableSalesReport.SuspendLayout();
            this.panelTotalSales.SuspendLayout();
            this.panelTotalOrders.SuspendLayout();
            this.panelAverageOrderValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReportMain
            // 
            this.panelReportMain.Controls.Add(this.tabReports);
            this.panelReportMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportMain.Location = new System.Drawing.Point(0, 0);
            this.panelReportMain.Name = "panelReportMain";
            this.panelReportMain.Size = new System.Drawing.Size(1288, 739);
            this.panelReportMain.TabIndex = 0;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabSalesReport);
            this.tabReports.Controls.Add(this.tabStockReport);
            this.tabReports.Controls.Add(this.tabCustomerOrders);
            this.tabReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReports.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReports.Location = new System.Drawing.Point(0, 0);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(1288, 739);
            this.tabReports.TabIndex = 0;
            this.tabReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabReports_DrawItem);
            // 
            // tabSalesReport
            // 
            this.tabSalesReport.Controls.Add(this.dgvSalesReport);
            this.tabSalesReport.Controls.Add(this.tableSalesReport);
            this.tabSalesReport.Controls.Add(this.btnDownload);
            this.tabSalesReport.Controls.Add(this.lblGenerate);
            this.tabSalesReport.Controls.Add(this.lblToDate);
            this.tabSalesReport.Controls.Add(this.lblFromDate);
            this.tabSalesReport.Controls.Add(this.dateTimePicker2);
            this.tabSalesReport.Controls.Add(this.dateTimePicker1);
            this.tabSalesReport.Location = new System.Drawing.Point(4, 34);
            this.tabSalesReport.Name = "tabSalesReport";
            this.tabSalesReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesReport.Size = new System.Drawing.Size(1280, 701);
            this.tabSalesReport.TabIndex = 0;
            this.tabSalesReport.Text = "Sales Report";
            this.tabSalesReport.UseVisualStyleBackColor = true;
            // 
            // tabStockReport
            // 
            this.tabStockReport.Controls.Add(this.dgvStockReport);
            this.tabStockReport.Controls.Add(this.button2);
            this.tabStockReport.Controls.Add(this.button1);
            this.tabStockReport.Controls.Add(this.cmbCategory);
            this.tabStockReport.Controls.Add(this.lblCategory);
            this.tabStockReport.Location = new System.Drawing.Point(4, 34);
            this.tabStockReport.Name = "tabStockReport";
            this.tabStockReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabStockReport.Size = new System.Drawing.Size(1280, 701);
            this.tabStockReport.TabIndex = 1;
            this.tabStockReport.Text = "Stock Report";
            this.tabStockReport.UseVisualStyleBackColor = true;
            // 
            // tabCustomerOrders
            // 
            this.tabCustomerOrders.Controls.Add(this.dgvCustomerOrders);
            this.tabCustomerOrders.Controls.Add(this.txtCustomer);
            this.tabCustomerOrders.Controls.Add(this.lblCustomer);
            this.tabCustomerOrders.Controls.Add(this.button3);
            this.tabCustomerOrders.Controls.Add(this.button4);
            this.tabCustomerOrders.Controls.Add(this.label1);
            this.tabCustomerOrders.Controls.Add(this.label2);
            this.tabCustomerOrders.Controls.Add(this.dateTimePicker3);
            this.tabCustomerOrders.Controls.Add(this.dateTimePicker4);
            this.tabCustomerOrders.Location = new System.Drawing.Point(4, 34);
            this.tabCustomerOrders.Name = "tabCustomerOrders";
            this.tabCustomerOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerOrders.Size = new System.Drawing.Size(1280, 701);
            this.tabCustomerOrders.TabIndex = 2;
            this.tabCustomerOrders.Text = "Customer Orders";
            this.tabCustomerOrders.UseVisualStyleBackColor = true;
            // 
            // lblGenerate
            // 
            this.lblGenerate.BackColor = System.Drawing.Color.ForestGreen;
            this.lblGenerate.ForeColor = System.Drawing.Color.White;
            this.lblGenerate.Location = new System.Drawing.Point(483, 44);
            this.lblGenerate.Name = "lblGenerate";
            this.lblGenerate.Size = new System.Drawing.Size(107, 41);
            this.lblGenerate.TabIndex = 8;
            this.lblGenerate.Text = "Generate ";
            this.lblGenerate.UseVisualStyleBackColor = false;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(254, 17);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(89, 25);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "To Date : ";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(23, 17);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(113, 25);
            this.lblFromDate.TabIndex = 4;
            this.lblFromDate.Text = "From Date : ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(259, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.Firebrick;
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(1045, 44);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(196, 41);
            this.btnDownload.TabIndex = 9;
            this.btnDownload.Text = "Download Report";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // tableSalesReport
            // 
            this.tableSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableSalesReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableSalesReport.ColumnCount = 3;
            this.tableSalesReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableSalesReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableSalesReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableSalesReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSalesReport.Controls.Add(this.panelTotalSales, 0, 0);
            this.tableSalesReport.Controls.Add(this.panelAverageOrderValue, 2, 0);
            this.tableSalesReport.Controls.Add(this.panelTotalOrders, 1, 0);
            this.tableSalesReport.Location = new System.Drawing.Point(6, 137);
            this.tableSalesReport.Name = "tableSalesReport";
            this.tableSalesReport.RowCount = 1;
            this.tableSalesReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSalesReport.Size = new System.Drawing.Size(1268, 117);
            this.tableSalesReport.TabIndex = 10;
            // 
            // panelTotalSales
            // 
            this.panelTotalSales.BackColor = System.Drawing.Color.White;
            this.panelTotalSales.Controls.Add(this.lblTotalSalesNumbers);
            this.panelTotalSales.Controls.Add(this.lblTotalSales);
            this.panelTotalSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalSales.Location = new System.Drawing.Point(3, 3);
            this.panelTotalSales.Name = "panelTotalSales";
            this.panelTotalSales.Size = new System.Drawing.Size(416, 111);
            this.panelTotalSales.TabIndex = 12;
            // 
            // panelTotalOrders
            // 
            this.panelTotalOrders.BackColor = System.Drawing.Color.White;
            this.panelTotalOrders.Controls.Add(this.lblTotalOrdersCount);
            this.panelTotalOrders.Controls.Add(this.lblTotalOrders);
            this.panelTotalOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalOrders.Location = new System.Drawing.Point(425, 3);
            this.panelTotalOrders.Name = "panelTotalOrders";
            this.panelTotalOrders.Size = new System.Drawing.Size(416, 111);
            this.panelTotalOrders.TabIndex = 13;
            // 
            // panelAverageOrderValue
            // 
            this.panelAverageOrderValue.BackColor = System.Drawing.Color.White;
            this.panelAverageOrderValue.Controls.Add(this.lblAverageValue);
            this.panelAverageOrderValue.Controls.Add(this.lblAverageOrderValue);
            this.panelAverageOrderValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAverageOrderValue.Location = new System.Drawing.Point(847, 3);
            this.panelAverageOrderValue.Name = "panelAverageOrderValue";
            this.panelAverageOrderValue.Size = new System.Drawing.Size(418, 111);
            this.panelAverageOrderValue.TabIndex = 14;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(14, 23);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(114, 30);
            this.lblTotalSales.TabIndex = 13;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // lblTotalSalesNumbers
            // 
            this.lblTotalSalesNumbers.AutoSize = true;
            this.lblTotalSalesNumbers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesNumbers.ForeColor = System.Drawing.Color.Green;
            this.lblTotalSalesNumbers.Location = new System.Drawing.Point(15, 53);
            this.lblTotalSalesNumbers.Name = "lblTotalSalesNumbers";
            this.lblTotalSalesNumbers.Size = new System.Drawing.Size(113, 38);
            this.lblTotalSalesNumbers.TabIndex = 14;
            this.lblTotalSalesNumbers.Text = "454000";
            this.lblTotalSalesNumbers.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTotalOrdersCount
            // 
            this.lblTotalOrdersCount.AutoSize = true;
            this.lblTotalOrdersCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrdersCount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalOrdersCount.Location = new System.Drawing.Point(14, 53);
            this.lblTotalOrdersCount.Name = "lblTotalOrdersCount";
            this.lblTotalOrdersCount.Size = new System.Drawing.Size(81, 38);
            this.lblTotalOrdersCount.TabIndex = 16;
            this.lblTotalOrdersCount.Text = "1850";
            this.lblTotalOrdersCount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(13, 23);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(132, 30);
            this.lblTotalOrders.TabIndex = 15;
            this.lblTotalOrders.Text = "Total Orders";
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.AutoSize = true;
            this.lblAverageValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageValue.ForeColor = System.Drawing.Color.Orange;
            this.lblAverageValue.Location = new System.Drawing.Point(15, 53);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(89, 38);
            this.lblAverageValue.TabIndex = 16;
            this.lblAverageValue.Text = "24.25";
            this.lblAverageValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAverageOrderValue
            // 
            this.lblAverageOrderValue.AutoSize = true;
            this.lblAverageOrderValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageOrderValue.Location = new System.Drawing.Point(14, 23);
            this.lblAverageOrderValue.Name = "lblAverageOrderValue";
            this.lblAverageOrderValue.Size = new System.Drawing.Size(173, 30);
            this.lblAverageOrderValue.TabIndex = 15;
            this.lblAverageOrderValue.Text = "Avg Order Value";
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.AllowUserToDeleteRows = false;
            this.dgvSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(-33, 276);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersWidth = 62;
            this.dgvSalesReport.RowTemplate.Height = 28;
            this.dgvSalesReport.Size = new System.Drawing.Size(1317, 422);
            this.dgvSalesReport.TabIndex = 13;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(16, 15);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(105, 25);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category : ";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(21, 55);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(203, 33);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.Text = "All Categories";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(258, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(986, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "Download Report";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dgvStockReport
            // 
            this.dgvStockReport.AllowUserToDeleteRows = false;
            this.dgvStockReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockReport.Location = new System.Drawing.Point(-11, 117);
            this.dgvStockReport.Name = "dgvStockReport";
            this.dgvStockReport.ReadOnly = true;
            this.dgvStockReport.RowHeadersWidth = 62;
            this.dgvStockReport.RowTemplate.Height = 28;
            this.dgvStockReport.Size = new System.Drawing.Size(1295, 581);
            this.dgvStockReport.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1066, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Download Report";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(801, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Generate ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "To Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "From Date : ";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(577, 48);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker3.TabIndex = 13;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(346, 48);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker4.TabIndex = 11;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(23, 17);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(107, 25);
            this.lblCustomer.TabIndex = 16;
            this.lblCustomer.Text = "Customer : ";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCustomer.Location = new System.Drawing.Point(26, 50);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(263, 31);
            this.txtCustomer.TabIndex = 17;
            this.txtCustomer.Text = "  Search Customer : ";
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(-4, 104);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.RowHeadersWidth = 62;
            this.dgvCustomerOrders.RowTemplate.Height = 28;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(1288, 594);
            this.dgvCustomerOrders.TabIndex = 18;
            // 
            // UcAdminReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelReportMain);
            this.Name = "UcAdminReports";
            this.Size = new System.Drawing.Size(1288, 739);
            this.panelReportMain.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabSalesReport.ResumeLayout(false);
            this.tabSalesReport.PerformLayout();
            this.tabStockReport.ResumeLayout(false);
            this.tabStockReport.PerformLayout();
            this.tabCustomerOrders.ResumeLayout(false);
            this.tabCustomerOrders.PerformLayout();
            this.tableSalesReport.ResumeLayout(false);
            this.panelTotalSales.ResumeLayout(false);
            this.panelTotalSales.PerformLayout();
            this.panelTotalOrders.ResumeLayout(false);
            this.panelTotalOrders.PerformLayout();
            this.panelAverageOrderValue.ResumeLayout(false);
            this.panelAverageOrderValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReportMain;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabSalesReport;
        private System.Windows.Forms.TabPage tabStockReport;
        private System.Windows.Forms.TabPage tabCustomerOrders;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button lblGenerate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableSalesReport;
        private System.Windows.Forms.Panel panelTotalSales;
        private System.Windows.Forms.Panel panelAverageOrderValue;
        private System.Windows.Forms.Panel panelTotalOrders;
        private System.Windows.Forms.Label lblTotalSalesNumbers;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblAverageValue;
        private System.Windows.Forms.Label lblAverageOrderValue;
        private System.Windows.Forms.Label lblTotalOrdersCount;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DataGridView dgvStockReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
    }
}
