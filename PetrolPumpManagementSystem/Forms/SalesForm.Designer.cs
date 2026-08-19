namespace PetrolPumpManagementSystem.Forms
{
    partial class SalesForm
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
            label1 = new Label();
            cmbFuel = new ComboBox();
            txtLiters = new TextBox();
            txtPrice = new TextBox();
            txtAmount = new TextBox();
            btnCalculate = new Button();
            btnSave = new Button();
            lblFuel = new Label();
            lblLiters = new Label();
            lblPrice = new Label();
            lblAmount = new Label();
            dgvSales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 57);
            label1.Name = "label1";
            label1.Size = new Size(136, 54);
            label1.TabIndex = 0;
            label1.Text = "SALES";
            // 
            // cmbFuel
            // 
            cmbFuel.FormattingEnabled = true;
            cmbFuel.Location = new Point(492, 137);
            cmbFuel.Name = "cmbFuel";
            cmbFuel.Size = new Size(234, 33);
            cmbFuel.TabIndex = 1;
            // 
            // txtLiters
            // 
            txtLiters.Location = new Point(491, 191);
            txtLiters.Name = "txtLiters";
            txtLiters.Size = new Size(235, 31);
            txtLiters.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(492, 237);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(234, 31);
            txtPrice.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(491, 287);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(234, 31);
            txtAmount.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(382, 332);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(509, 332);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.Location = new Point(336, 137);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(44, 25);
            lblFuel.TabIndex = 7;
            lblFuel.Text = "Fuel";
            // 
            // lblLiters
            // 
            lblLiters.AutoSize = true;
            lblLiters.Location = new Point(327, 194);
            lblLiters.Name = "lblLiters";
            lblLiters.Size = new Size(53, 25);
            lblLiters.TabIndex = 8;
            lblLiters.Text = "Litres";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(327, 243);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(327, 287);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 25);
            lblAmount.TabIndex = 10;
            lblAmount.Text = "Amount";
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(47, 387);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 62;
            dgvSales.Size = new Size(898, 251);
            dgvSales.TabIndex = 11;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(dgvSales);
            Controls.Add(lblAmount);
            Controls.Add(lblPrice);
            Controls.Add(lblLiters);
            Controls.Add(lblFuel);
            Controls.Add(btnSave);
            Controls.Add(btnCalculate);
            Controls.Add(txtAmount);
            Controls.Add(txtPrice);
            Controls.Add(txtLiters);
            Controls.Add(cmbFuel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbFuel;
        private TextBox txtLiters;
        private TextBox txtPrice;
        private TextBox txtAmount;
        private Button btnCalculate;
        private Button btnSave;
        private Label lblFuel;
        private Label lblLiters;
        private Label lblPrice;
        private Label lblAmount;
        private DataGridView dgvSales;
    }
}