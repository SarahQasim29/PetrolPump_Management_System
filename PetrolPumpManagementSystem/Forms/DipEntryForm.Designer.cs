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
            lblFuel = new Label();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            txtMorningOpening = new TextBox();
            txtMorningClosing = new TextBox();
            txtMorningWithdrawal = new TextBox();
            txtEveningOpening = new TextBox();
            txtEveningClosing = new TextBox();
            txtEveningWithdrawal = new TextBox();
            txtTotalWithdrawal = new TextBox();
            txtCashExpected = new TextBox();
            lblMorningOpening = new Label();
            lblMorningClosing = new Label();
            lblMorningWithdrawal = new Label();
            lblEveningOpening = new Label();
            lblEveningClosing = new Label();
            lblEveningWithdrawal = new Label();
            lblTotalWithdrawal = new Label();
            lblCashExpected = new Label();
            btnCalculate = new Button();
            btnSave = new Button();
            dgvDipEntries = new DataGridView();
            lblShift = new Label();
            cmbShift = new ComboBox();
            grpDipInformation = new GroupBox();
            grpMorning = new GroupBox();
            grpEvening = new GroupBox();
            grpSummary = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvDipEntries).BeginInit();
            grpDipInformation.SuspendLayout();
            grpMorning.SuspendLayout();
            grpEvening.SuspendLayout();
            grpSummary.SuspendLayout();
            grpSearch.SuspendLayout();
            grpDipRecords.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(390, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(411, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dip Entry Management\n";
            // 
            // cmbFuelType
            // 
            cmbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Location = new Point(120, 30);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(220, 33);
            cmbFuelType.TabIndex = 1;
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.Location = new Point(25, 35);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(86, 25);
            lblFuel.TabIndex = 3;
            lblFuel.Text = "Feul Type";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(715, 35);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // dtDate
            // 
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(780, 30);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(220, 31);
            dtDate.TabIndex = 5;
            // 
            // txtMorningOpening
            // 
            txtMorningOpening.Location = new Point(212, 40);
            txtMorningOpening.Name = "txtMorningOpening";
            txtMorningOpening.Size = new Size(220, 31);
            txtMorningOpening.TabIndex = 6;
            // 
            // txtMorningClosing
            // 
            txtMorningClosing.Location = new Point(212, 85);
            txtMorningClosing.Name = "txtMorningClosing";
            txtMorningClosing.Size = new Size(220, 31);
            txtMorningClosing.TabIndex = 7;
            // 
            // txtMorningWithdrawal
            // 
            txtMorningWithdrawal.BackColor = Color.WhiteSmoke;
            txtMorningWithdrawal.Location = new Point(212, 127);
            txtMorningWithdrawal.Name = "txtMorningWithdrawal";
            txtMorningWithdrawal.ReadOnly = true;
            txtMorningWithdrawal.Size = new Size(220, 31);
            txtMorningWithdrawal.TabIndex = 8;
            // 
            // txtEveningOpening
            // 
            txtEveningOpening.Location = new Point(230, 37);
            txtEveningOpening.Name = "txtEveningOpening";
            txtEveningOpening.Size = new Size(220, 31);
            txtEveningOpening.TabIndex = 9;
            // 
            // txtEveningClosing
            // 
            txtEveningClosing.Location = new Point(230, 82);
            txtEveningClosing.Name = "txtEveningClosing";
            txtEveningClosing.Size = new Size(220, 31);
            txtEveningClosing.TabIndex = 10;
            // 
            // txtEveningWithdrawal
            // 
            txtEveningWithdrawal.Location = new Point(230, 130);
            txtEveningWithdrawal.Name = "txtEveningWithdrawal";
            txtEveningWithdrawal.ReadOnly = true;
            txtEveningWithdrawal.Size = new Size(220, 31);
            txtEveningWithdrawal.TabIndex = 11;
            // 
            // txtTotalWithdrawal
            // 
            txtTotalWithdrawal.Location = new Point(189, 37);
            txtTotalWithdrawal.Name = "txtTotalWithdrawal";
            txtTotalWithdrawal.ReadOnly = true;
            txtTotalWithdrawal.Size = new Size(180, 31);
            txtTotalWithdrawal.TabIndex = 12;
            // 
            // txtCashExpected
            // 
            txtCashExpected.Location = new Point(887, 37);
            txtCashExpected.Name = "txtCashExpected";
            txtCashExpected.Size = new Size(180, 31);
            txtCashExpected.TabIndex = 13;
            // 
            // lblMorningOpening
            // 
            lblMorningOpening.AutoSize = true;
            lblMorningOpening.Location = new Point(20, 40);
            lblMorningOpening.Name = "lblMorningOpening";
            lblMorningOpening.Size = new Size(154, 25);
            lblMorningOpening.TabIndex = 14;
            lblMorningOpening.Text = "Morning Opening";
            // 
            // lblMorningClosing
            // 
            lblMorningClosing.AutoSize = true;
            lblMorningClosing.Location = new Point(20, 85);
            lblMorningClosing.Name = "lblMorningClosing";
            lblMorningClosing.Size = new Size(144, 25);
            lblMorningClosing.TabIndex = 15;
            lblMorningClosing.Text = "Morning Closing";
            // 
            // lblMorningWithdrawal
            // 
            lblMorningWithdrawal.AutoSize = true;
            lblMorningWithdrawal.Location = new Point(20, 130);
            lblMorningWithdrawal.Name = "lblMorningWithdrawal";
            lblMorningWithdrawal.Size = new Size(174, 25);
            lblMorningWithdrawal.TabIndex = 16;
            lblMorningWithdrawal.Text = "Morning Withdrawal";
            // 
            // lblEveningOpening
            // 
            lblEveningOpening.AutoSize = true;
            lblEveningOpening.Location = new Point(46, 40);
            lblEveningOpening.Name = "lblEveningOpening";
            lblEveningOpening.Size = new Size(148, 25);
            lblEveningOpening.TabIndex = 17;
            lblEveningOpening.Text = "Evening Opening";
            // 
            // lblEveningClosing
            // 
            lblEveningClosing.AutoSize = true;
            lblEveningClosing.Location = new Point(46, 85);
            lblEveningClosing.Name = "lblEveningClosing";
            lblEveningClosing.Size = new Size(138, 25);
            lblEveningClosing.TabIndex = 18;
            lblEveningClosing.Text = "Evening Closing";
            // 
            // lblEveningWithdrawal
            // 
            lblEveningWithdrawal.AutoSize = true;
            lblEveningWithdrawal.Location = new Point(46, 130);
            lblEveningWithdrawal.Name = "lblEveningWithdrawal";
            lblEveningWithdrawal.Size = new Size(168, 25);
            lblEveningWithdrawal.TabIndex = 19;
            lblEveningWithdrawal.Text = "Evening Withdrawal";
            // 
            // lblTotalWithdrawal
            // 
            lblTotalWithdrawal.AutoSize = true;
            lblTotalWithdrawal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalWithdrawal.Location = new Point(40, 40);
            lblTotalWithdrawal.Name = "lblTotalWithdrawal";
            lblTotalWithdrawal.Size = new Size(143, 25);
            lblTotalWithdrawal.TabIndex = 20;
            lblTotalWithdrawal.Text = "Total Withdrawal";
            // 
            // lblCashExpected
            // 
            lblCashExpected.AutoSize = true;
            lblCashExpected.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCashExpected.Location = new Point(755, 40);
            lblCashExpected.Name = "lblCashExpected";
            lblCashExpected.Size = new Size(126, 25);
            lblCashExpected.TabIndex = 21;
            lblCashExpected.Text = "Cash Expected";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(198, 495);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 40);
            btnCalculate.TabIndex = 22;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(338, 495);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvDipEntries
            // 
            dgvDipEntries.AllowUserToAddRows = false;
            dgvDipEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDipEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDipEntries.Dock = DockStyle.Fill;
            dgvDipEntries.Location = new Point(3, 27);
            dgvDipEntries.MultiSelect = false;
            dgvDipEntries.Name = "dgvDipEntries";
            dgvDipEntries.ReadOnly = true;
            dgvDipEntries.RowHeadersWidth = 62;
            dgvDipEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDipEntries.Size = new Size(1114, 100);
            dgvDipEntries.TabIndex = 24;
            // 
            // lblShift
            // 
            lblShift.AutoSize = true;
            lblShift.Location = new Point(380, 35);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(48, 25);
            lblShift.TabIndex = 25;
            lblShift.Text = "Shift";
            // 
            // cmbShift
            // 
            cmbShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShift.FormattingEnabled = true;
            cmbShift.Items.AddRange(new object[] { "Morning", "", "", "Evening" });
            cmbShift.Location = new Point(450, 30);
            cmbShift.Name = "cmbShift";
            cmbShift.Size = new Size(220, 33);
            cmbShift.TabIndex = 26;
            // 
            // grpDipInformation
            // 
            grpDipInformation.Controls.Add(lblFuel);
            grpDipInformation.Controls.Add(cmbShift);
            grpDipInformation.Controls.Add(cmbFuelType);
            grpDipInformation.Controls.Add(lblShift);
            grpDipInformation.Controls.Add(lblDate);
            grpDipInformation.Controls.Add(dtDate);
            grpDipInformation.Location = new Point(30, 60);
            grpDipInformation.Name = "grpDipInformation";
            grpDipInformation.Size = new Size(1120, 83);
            grpDipInformation.TabIndex = 27;
            grpDipInformation.TabStop = false;
            grpDipInformation.Text = "Dip Information";
            // 
            // grpMorning
            // 
            grpMorning.Controls.Add(lblMorningOpening);
            grpMorning.Controls.Add(txtMorningOpening);
            grpMorning.Controls.Add(lblMorningClosing);
            grpMorning.Controls.Add(txtMorningClosing);
            grpMorning.Controls.Add(lblMorningWithdrawal);
            grpMorning.Controls.Add(txtMorningWithdrawal);
            grpMorning.Location = new Point(30, 162);
            grpMorning.Name = "grpMorning";
            grpMorning.Size = new Size(540, 180);
            grpMorning.TabIndex = 28;
            grpMorning.TabStop = false;
            grpMorning.Text = "Morning Reading";
            // 
            // grpEvening
            // 
            grpEvening.Controls.Add(lblEveningOpening);
            grpEvening.Controls.Add(txtEveningOpening);
            grpEvening.Controls.Add(lblEveningClosing);
            grpEvening.Controls.Add(txtEveningClosing);
            grpEvening.Controls.Add(lblEveningWithdrawal);
            grpEvening.Controls.Add(txtEveningWithdrawal);
            grpEvening.Location = new Point(610, 162);
            grpEvening.Name = "grpEvening";
            grpEvening.Size = new Size(540, 180);
            grpEvening.TabIndex = 29;
            grpEvening.TabStop = false;
            grpEvening.Text = "Evening Reading";
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(txtFuelPrice);
            grpSummary.Controls.Add(lblFuelPrice);
            grpSummary.Controls.Add(lblTotalWithdrawal);
            grpSummary.Controls.Add(txtTotalWithdrawal);
            grpSummary.Controls.Add(lblCashExpected);
            grpSummary.Controls.Add(txtCashExpected);
            grpSummary.Location = new Point(30, 357);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(1120, 120);
            grpSummary.TabIndex = 30;
            grpSummary.TabStop = false;
            grpSummary.Text = "Daily Summary";
            // 
            // txtFuelPrice
            // 
            txtFuelPrice.Location = new Point(519, 37);
            txtFuelPrice.Name = "txtFuelPrice";
            txtFuelPrice.ReadOnly = true;
            txtFuelPrice.Size = new Size(180, 31);
            txtFuelPrice.TabIndex = 23;
            // 
            // lblFuelPrice
            // 
            lblFuelPrice.AutoSize = true;
            lblFuelPrice.Location = new Point(427, 40);
            lblFuelPrice.Name = "lblFuelPrice";
            lblFuelPrice.Size = new Size(86, 25);
            lblFuelPrice.TabIndex = 22;
            lblFuelPrice.Text = "Feul Price";
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(478, 495);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(618, 495);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(758, 495);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(898, 495);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 40);
            btnRefresh.TabIndex = 34;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(lblSearch);
            grpSearch.Location = new Point(30, 552);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(1120, 70);
            grpSearch.TabIndex = 35;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(90, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 31);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // grpDipRecords
            // 
            grpDipRecords.Controls.Add(dgvDipEntries);
            grpDipRecords.Location = new Point(30, 632);
            grpDipRecords.Name = "grpDipRecords";
            grpDipRecords.Size = new Size(1120, 130);
            grpDipRecords.TabIndex = 36;
            grpDipRecords.TabStop = false;
            grpDipRecords.Text = "Dip Entry Records";
            // 
            // DipEntryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 802);
            Controls.Add(grpDipRecords);
            Controls.Add(grpSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(grpSummary);
            Controls.Add(grpEvening);
            Controls.Add(grpMorning);
            Controls.Add(grpDipInformation);
            Controls.Add(btnSave);
            Controls.Add(btnCalculate);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(30, 60);
            Name = "DipEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dip Entry";
            WindowState = FormWindowState.Maximized;
            Load += DipEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDipEntries).EndInit();
            grpDipInformation.ResumeLayout(false);
            grpDipInformation.PerformLayout();
            grpMorning.ResumeLayout(false);
            grpMorning.PerformLayout();
            grpEvening.ResumeLayout(false);
            grpEvening.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            grpDipRecords.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbFuelType;
        private Label lblFuel;
        private Label lblDate;
        private DateTimePicker dtDate;
        private TextBox txtMorningOpening;
        private TextBox txtMorningClosing;
        private TextBox txtMorningWithdrawal;
        private TextBox txtEveningOpening;
        private TextBox txtEveningClosing;
        private TextBox txtEveningWithdrawal;
        private TextBox txtTotalWithdrawal;
        private TextBox txtCashExpected;
        private Label lblMorningOpening;
        private Label lblMorningClosing;
        private Label lblMorningWithdrawal;
        private Label lblEveningOpening;
        private Label lblEveningClosing;
        private Label lblEveningWithdrawal;
        private Label lblTotalWithdrawal;
        private Label lblCashExpected;
        private Button btnCalculate;
        private Button btnSave;
        private DataGridView dgvDipEntries;
        private Label lblShift;
        private ComboBox cmbShift;
        private GroupBox grpDipInformation;
        private GroupBox grpMorning;
        private GroupBox grpEvening;
        private GroupBox grpSummary;
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
    }
}