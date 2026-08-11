namespace PetrolPumpManagementSystem.Forms
{
    partial class FuelPriceForm
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
            txtPrice = new TextBox();
            lblFuelType = new Label();
            lblPrice = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvFuelPrices = new DataGridView();
            grpFuelPrice = new GroupBox();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dtpEffectiveDate = new DateTimePicker();
            lblEffectiveDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFuelPrices).BeginInit();
            grpFuelPrice.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(535, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "FUEL PRICE MANAGEMENT";
            // 
            // cmbFuelType
            // 
            cmbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Items.AddRange(new object[] { "Petrol" });
            cmbFuelType.Location = new Point(196, 36);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(250, 33);
            cmbFuelType.TabIndex = 0;
            cmbFuelType.SelectedIndexChanged += cmbFuelType_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(196, 81);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 31);
            txtPrice.TabIndex = 1;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.KeyPress += txtPrice_KeyPress;
            txtPrice.Leave += txtPrice_Leave;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(55, 39);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(86, 25);
            lblFuelType.TabIndex = 3;
            lblFuelType.Text = "Feul Type";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(55, 81);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(116, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price Per Liter";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(130, 128);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(276, 128);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(423, 128);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(566, 128);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvFuelPrices
            // 
            dgvFuelPrices.AllowUserToAddRows = false;
            dgvFuelPrices.AllowUserToDeleteRows = false;
            dgvFuelPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuelPrices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuelPrices.Location = new Point(20, 280);
            dgvFuelPrices.MultiSelect = false;
            dgvFuelPrices.Name = "dgvFuelPrices";
            dgvFuelPrices.ReadOnly = true;
            dgvFuelPrices.RowHeadersVisible = false;
            dgvFuelPrices.RowHeadersWidth = 62;
            dgvFuelPrices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuelPrices.Size = new Size(950, 320);
            dgvFuelPrices.TabIndex = 9;
            dgvFuelPrices.CellClick += dgvFuelPrices_CellClick;
            // 
            // grpFuelPrice
            // 
            grpFuelPrice.Controls.Add(btnRefresh);
            grpFuelPrice.Controls.Add(txtSearch);
            grpFuelPrice.Controls.Add(lblSearch);
            grpFuelPrice.Controls.Add(btnClear);
            grpFuelPrice.Controls.Add(dtpEffectiveDate);
            grpFuelPrice.Controls.Add(btnDelete);
            grpFuelPrice.Controls.Add(lblEffectiveDate);
            grpFuelPrice.Controls.Add(btnUpdate);
            grpFuelPrice.Controls.Add(lblFuelType);
            grpFuelPrice.Controls.Add(btnSave);
            grpFuelPrice.Controls.Add(cmbFuelType);
            grpFuelPrice.Controls.Add(lblPrice);
            grpFuelPrice.Controls.Add(txtPrice);
            grpFuelPrice.Location = new Point(20, 70);
            grpFuelPrice.Name = "grpFuelPrice";
            grpFuelPrice.Size = new Size(950, 180);
            grpFuelPrice.TabIndex = 10;
            grpFuelPrice.TabStop = false;
            grpFuelPrice.Text = "Fuel Price Information";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(708, 128);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 40);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(641, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 31);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(507, 81);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(110, 25);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Search Fuel |";
            // 
            // dtpEffectiveDate
            // 
            dtpEffectiveDate.Format = DateTimePickerFormat.Short;
            dtpEffectiveDate.Location = new Point(641, 36);
            dtpEffectiveDate.Name = "dtpEffectiveDate";
            dtpEffectiveDate.Size = new Size(250, 31);
            dtpEffectiveDate.TabIndex = 2;
            // 
            // lblEffectiveDate
            // 
            lblEffectiveDate.AutoSize = true;
            lblEffectiveDate.Location = new Point(507, 36);
            lblEffectiveDate.Name = "lblEffectiveDate";
            lblEffectiveDate.Size = new Size(120, 25);
            lblEffectiveDate.TabIndex = 5;
            lblEffectiveDate.Text = "Effective Date";
            // 
            // FuelPriceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpFuelPrice);
            Controls.Add(dgvFuelPrices);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuelPriceForm";
            Text = "Fuel Price Management";
            TopMost = true;
            Load += FuelPriceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuelPrices).EndInit();
            grpFuelPrice.ResumeLayout(false);
            grpFuelPrice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbFuelType;
        private TextBox txtPrice;
        private Label lblFuelType;
        private Label lblPrice;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvFuelPrices;
        private GroupBox grpFuelPrice;
        private TextBox txtSearch;
        private Label lblSearch;
        private DateTimePicker dtpEffectiveDate;
        private Label lblEffectiveDate;
        private Button btnRefresh;
    }
}