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
            ((System.ComponentModel.ISupportInitialize)dgvFuelPrices).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(238, 72);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(535, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "FUEL PRICE MANAGEMENT";
            // 
            // cmbFuelType
            // 
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Items.AddRange(new object[] { "Petrol" });
            cmbFuelType.Location = new Point(459, 153);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(182, 33);
            cmbFuelType.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(459, 233);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(185, 31);
            txtPrice.TabIndex = 2;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(304, 156);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(86, 25);
            lblFuelType.TabIndex = 3;
            lblFuelType.Text = "Feul Type";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(313, 236);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(216, 303);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(364, 303);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(514, 303);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(661, 303);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvFuelPrices
            // 
            dgvFuelPrices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuelPrices.Location = new Point(75, 391);
            dgvFuelPrices.Name = "dgvFuelPrices";
            dgvFuelPrices.RowHeadersWidth = 62;
            dgvFuelPrices.Size = new Size(847, 225);
            dgvFuelPrices.TabIndex = 9;
            // 
            // FuelPriceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(dgvFuelPrices);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblPrice);
            Controls.Add(lblFuelType);
            Controls.Add(txtPrice);
            Controls.Add(cmbFuelType);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuelPriceForm";
            Text = "FuelPriceForm";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dgvFuelPrices).EndInit();
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
    }
}