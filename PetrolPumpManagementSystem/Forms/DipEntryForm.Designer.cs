namespace PetrolPumpManagementSystem.Forms
{
    partial class DipEntryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            cmbFuelType = new ComboBox();
            lblFuelType = new Label();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            txtBeforeReading = new TextBox();
            txtAfterReading = new TextBox();
            txtPhysicalDip = new TextBox();
            txtDailySales = new TextBox();
            txtCashExpected = new TextBox();
            lblBeforeReading = new Label();
            lblAfterReading = new Label();
            lblPhysicalDip = new Label();
            lblDailySales = new Label();
            lblCashExpected = new Label();
            btnCalculate = new Button();
            btnSave = new Button();
            dgvDipEntries = new DataGridView();
            grpDailyReading = new GroupBox();
            grpCalculations = new GroupBox();
            txtFuelPrice = new TextBox();
            lblFuelPrice = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            grpSearch = new GroupBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            grpDipRecords = new GroupBox();
            lblOpeningStock = new Label();
            lblStockAfterSales = new Label();
            lblRecievedStock = new Label();
            txtOpeningStock = new TextBox();
            txtStockAfterSales = new TextBox();
            txtRecievedStock = new TextBox();
            txtDifference = new TextBox();
            lblDifference = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDipEntries).BeginInit();
            grpDailyReading.SuspendLayout();
            grpCalculations.SuspendLayout();
            grpSearch.SuspendLayout();
            grpDipRecords.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(430, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(517, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dip Reading Management";
            // 
            // cmbFuelType
            // 
            cmbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Location = new Point(223, 30);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(250, 33);
            cmbFuelType.TabIndex = 1;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(25, 35);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(86, 25);
            lblFuelType.TabIndex = 3;
            lblFuelType.Text = "Fuel Type";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(593, 35);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // dtDate
            // 
            dtDate.Enabled = false;
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(785, 35);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(250, 31);
            dtDate.TabIndex = 5;
            // 
            // txtBeforeReading
            // 
            txtBeforeReading.Location = new Point(223, 79);
            txtBeforeReading.Name = "txtBeforeReading";
            txtBeforeReading.Size = new Size(250, 31);
            txtBeforeReading.TabIndex = 9;
            txtBeforeReading.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAfterReading
            // 
            txtAfterReading.Location = new Point(785, 85);
            txtAfterReading.Name = "txtAfterReading";
            txtAfterReading.Size = new Size(250, 31);
            txtAfterReading.TabIndex = 10;
            txtAfterReading.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPhysicalDip
            // 
            txtPhysicalDip.Location = new Point(540, 131);
            txtPhysicalDip.Name = "txtPhysicalDip";
            txtPhysicalDip.ReadOnly = true;
            txtPhysicalDip.Size = new Size(250, 31);
            txtPhysicalDip.TabIndex = 11;
            txtPhysicalDip.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDailySales
            // 
            txtDailySales.BackColor = Color.WhiteSmoke;
            txtDailySales.Location = new Point(804, 30);
            txtDailySales.Name = "txtDailySales";
            txtDailySales.ReadOnly = true;
            txtDailySales.Size = new Size(250, 31);
            txtDailySales.TabIndex = 12;
            txtDailySales.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCashExpected
            // 
            txtCashExpected.BackColor = Color.WhiteSmoke;
            txtCashExpected.Location = new Point(540, 178);
            txtCashExpected.Name = "txtCashExpected";
            txtCashExpected.ReadOnly = true;
            txtCashExpected.Size = new Size(250, 31);
            txtCashExpected.TabIndex = 13;
            txtCashExpected.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBeforeReading
            // 
            lblBeforeReading.AutoSize = true;
            lblBeforeReading.Location = new Point(25, 85);
            lblBeforeReading.Name = "lblBeforeReading";
            lblBeforeReading.Size = new Size(155, 25);
            lblBeforeReading.TabIndex = 17;
            lblBeforeReading.Text = "Before Reading (L)";
            // 
            // lblAfterReading
            // 
            lblAfterReading.AutoSize = true;
            lblAfterReading.Location = new Point(593, 82);
            lblAfterReading.Name = "lblAfterReading";
            lblAfterReading.Size = new Size(143, 25);
            lblAfterReading.TabIndex = 18;
            lblAfterReading.Text = "After Reading (L)";
            // 
            // lblPhysicalDip
            // 
            lblPhysicalDip.AutoSize = true;
            lblPhysicalDip.Location = new Point(306, 131);
            lblPhysicalDip.Name = "lblPhysicalDip";
            lblPhysicalDip.Size = new Size(178, 25);
            lblPhysicalDip.TabIndex = 19;
            lblPhysicalDip.Text = "Physical Dip Stock (L)";
            // 
            // lblDailySales
            // 
            lblDailySales.AutoSize = true;
            lblDailySales.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDailySales.Location = new Point(596, 36);
            lblDailySales.Name = "lblDailySales";
            lblDailySales.Size = new Size(119, 25);
            lblDailySales.TabIndex = 20;
            lblDailySales.Text = "Daily Sales (L)";
            // 
            // lblCashExpected
            // 
            lblCashExpected.AutoSize = true;
            lblCashExpected.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCashExpected.Location = new Point(306, 184);
            lblCashExpected.Name = "lblCashExpected";
            lblCashExpected.Size = new Size(160, 25);
            lblCashExpected.TabIndex = 21;
            lblCashExpected.Text = "Cash Expected (Rs)";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(226, 519);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(132, 45);
            btnCalculate.TabIndex = 22;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(380, 519);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 45);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvDipEntries
            // 
            dgvDipEntries.AllowUserToAddRows = false;
            dgvDipEntries.AllowUserToDeleteRows = false;
            dgvDipEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDipEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDipEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDipEntries.Location = new Point(10, 25);
            dgvDipEntries.MultiSelect = false;
            dgvDipEntries.Name = "dgvDipEntries";
            dgvDipEntries.ReadOnly = true;
            dgvDipEntries.RowHeadersVisible = false;
            dgvDipEntries.RowHeadersWidth = 62;
            dgvDipEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDipEntries.Size = new Size(1110, 105);
            dgvDipEntries.TabIndex = 24;
            // 
            // grpDailyReading
            // 
            grpDailyReading.Controls.Add(txtPhysicalDip);
            grpDailyReading.Controls.Add(txtBeforeReading);
            grpDailyReading.Controls.Add(lblPhysicalDip);
            grpDailyReading.Controls.Add(lblBeforeReading);
            grpDailyReading.Controls.Add(txtAfterReading);
            grpDailyReading.Controls.Add(lblFuelType);
            grpDailyReading.Controls.Add(lblAfterReading);
            grpDailyReading.Controls.Add(cmbFuelType);
            grpDailyReading.Controls.Add(lblDate);
            grpDailyReading.Controls.Add(dtDate);
            grpDailyReading.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDailyReading.Location = new Point(30, 70);
            grpDailyReading.Name = "grpDailyReading";
            grpDailyReading.Size = new Size(1120, 180);
            grpDailyReading.TabIndex = 27;
            grpDailyReading.TabStop = false;
            grpDailyReading.Text = "Daily Reading";
            // 
            // grpCalculations
            // 
            grpCalculations.Controls.Add(txtDifference);
            grpCalculations.Controls.Add(lblDifference);
            grpCalculations.Controls.Add(txtRecievedStock);
            grpCalculations.Controls.Add(txtStockAfterSales);
            grpCalculations.Controls.Add(txtOpeningStock);
            grpCalculations.Controls.Add(lblStockAfterSales);
            grpCalculations.Controls.Add(txtFuelPrice);
            grpCalculations.Controls.Add(lblFuelPrice);
            grpCalculations.Controls.Add(txtCashExpected);
            grpCalculations.Controls.Add(lblCashExpected);
            grpCalculations.Controls.Add(lblRecievedStock);
            grpCalculations.Controls.Add(lblOpeningStock);
            grpCalculations.Controls.Add(txtDailySales);
            grpCalculations.Controls.Add(lblDailySales);
            grpCalculations.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpCalculations.Location = new Point(30, 265);
            grpCalculations.Name = "grpCalculations";
            grpCalculations.Size = new Size(1120, 228);
            grpCalculations.TabIndex = 30;
            grpCalculations.TabStop = false;
            grpCalculations.Text = "Calculations";
            // 
            // txtFuelPrice
            // 
            txtFuelPrice.BackColor = Color.WhiteSmoke;
            txtFuelPrice.Location = new Point(804, 133);
            txtFuelPrice.Name = "txtFuelPrice";
            txtFuelPrice.ReadOnly = true;
            txtFuelPrice.Size = new Size(250, 31);
            txtFuelPrice.TabIndex = 23;
            txtFuelPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFuelPrice
            // 
            lblFuelPrice.AutoSize = true;
            lblFuelPrice.Location = new Point(593, 133);
            lblFuelPrice.Name = "lblFuelPrice";
            lblFuelPrice.Size = new Size(135, 25);
            lblFuelPrice.TabIndex = 22;
            lblFuelPrice.Text = "Feul Price (Rs/L)";
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(534, 519);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 45);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(688, 519);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 45);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(842, 519);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 45);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(996, 519);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(132, 45);
            btnRefresh.TabIndex = 34;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(lblSearch);
            grpSearch.Location = new Point(30, 580);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(1120, 82);
            grpSearch.TabIndex = 35;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search Daily Records";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(124, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 34);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(25, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // grpDipRecords
            // 
            grpDipRecords.Controls.Add(dgvDipEntries);
            grpDipRecords.Location = new Point(33, 675);
            grpDipRecords.Name = "grpDipRecords";
            grpDipRecords.Size = new Size(1120, 140);
            grpDipRecords.TabIndex = 36;
            grpDipRecords.TabStop = false;
            grpDipRecords.Text = "Daily Dip Entry Records";
            // 
            // lblOpeningStock
            // 
            lblOpeningStock.AutoSize = true;
            lblOpeningStock.Location = new Point(25, 36);
            lblOpeningStock.Name = "lblOpeningStock";
            lblOpeningStock.Size = new Size(152, 25);
            lblOpeningStock.TabIndex = 24;
            lblOpeningStock.Text = "Opening Stock (L)";
            // 
            // lblStockAfterSales
            // 
            lblStockAfterSales.AutoSize = true;
            lblStockAfterSales.Location = new Point(593, 84);
            lblStockAfterSales.Name = "lblStockAfterSales";
            lblStockAfterSales.Size = new Size(167, 25);
            lblStockAfterSales.TabIndex = 25;
            lblStockAfterSales.Text = "Stock After Sales (L)";
            // 
            // lblRecievedStock
            // 
            lblRecievedStock.AutoSize = true;
            lblRecievedStock.Location = new Point(25, 84);
            lblRecievedStock.Name = "lblRecievedStock";
            lblRecievedStock.Size = new Size(152, 25);
            lblRecievedStock.TabIndex = 26;
            lblRecievedStock.Text = "Recieved Stock (L)";
            // 
            // txtOpeningStock
            // 
            txtOpeningStock.BackColor = Color.WhiteSmoke;
            txtOpeningStock.Location = new Point(224, 30);
            txtOpeningStock.Name = "txtOpeningStock";
            txtOpeningStock.ReadOnly = true;
            txtOpeningStock.Size = new Size(250, 31);
            txtOpeningStock.TabIndex = 38;
            txtOpeningStock.TextAlign = HorizontalAlignment.Right;
            // 
            // txtStockAfterSales
            // 
            txtStockAfterSales.BackColor = Color.WhiteSmoke;
            txtStockAfterSales.Location = new Point(804, 84);
            txtStockAfterSales.Name = "txtStockAfterSales";
            txtStockAfterSales.ReadOnly = true;
            txtStockAfterSales.Size = new Size(250, 31);
            txtStockAfterSales.TabIndex = 39;
            txtStockAfterSales.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRecievedStock
            // 
            txtRecievedStock.BackColor = Color.WhiteSmoke;
            txtRecievedStock.Location = new Point(223, 84);
            txtRecievedStock.Name = "txtRecievedStock";
            txtRecievedStock.Size = new Size(250, 31);
            txtRecievedStock.TabIndex = 40;
            // 
            // txtDifference
            // 
            txtDifference.BackColor = Color.WhiteSmoke;
            txtDifference.Location = new Point(224, 133);
            txtDifference.Name = "txtDifference";
            txtDifference.ReadOnly = true;
            txtDifference.Size = new Size(250, 31);
            txtDifference.TabIndex = 37;
            txtDifference.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDifference
            // 
            lblDifference.AutoSize = true;
            lblDifference.Location = new Point(25, 133);
            lblDifference.Name = "lblDifference";
            lblDifference.Size = new Size(115, 25);
            lblDifference.TabIndex = 38;
            lblDifference.Text = "Difference (L)";
            // 
            // DipEntryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1320, 896);
            Controls.Add(grpDipRecords);
            Controls.Add(grpSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(grpCalculations);
            Controls.Add(grpDailyReading);
            Controls.Add(btnSave);
            Controls.Add(btnCalculate);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(30, 60);
            Name = "DipEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dip Reading Management";
            WindowState = FormWindowState.Maximized;
            Load += DipEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDipEntries).EndInit();
            grpDailyReading.ResumeLayout(false);
            grpDailyReading.PerformLayout();
            grpCalculations.ResumeLayout(false);
            grpCalculations.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            grpDipRecords.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbFuelType;
        private Label lblFuelType;
        private Label lblDate;
        private DateTimePicker dtDate;
        private TextBox txtBeforeReading;
        private TextBox txtMorningClosing;
        private TextBox txtMorningWithdrawal;
        private TextBox txtAfterReading;
        private TextBox txtPhysicalDip;
        private TextBox txtDailySales;
        private TextBox txtCashExpected;
        private Label lblMorningClosing;
        private Label lblMorningWithdrawal;
        private Label lblBeforeReading;
        private Label lblAfterReading;
        private Label lblPhysicalDip;
        private Label lblDailySales;
        private Label lblCashExpected;
        private Button btnCalculate;
        private Button btnSave;
        private DataGridView dgvDipEntries;
        private GroupBox grpDailyReading;
        private GroupBox grpMorning;
        private GroupBox grpEvening;
        private GroupBox grpCalculations;
        private TextBox txtFuelPrice;
        private Label lblFuelPrice;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnRefresh;
        private GroupBox grpSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private GroupBox grpDipRecords;
        private TextBox txtRecievedStock;
        private TextBox txtStockAfterSales;
        private TextBox txtOpeningStock;
        private Label lblRecievedStock;
        private Label lblStockAfterSales;
        private Label lblOpeningStock;
        private TextBox txtDifference;
        private Label lblDifference;
    }
}