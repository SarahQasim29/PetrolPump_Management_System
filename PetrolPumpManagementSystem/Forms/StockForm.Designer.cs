namespace PetrolPumpManagementSystem.Forms
{
    partial class StockForm
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
            txtOpening = new TextBox();
            txtSales = new TextBox();
            txtReceived = new TextBox();
            txtClosing = new TextBox();
            txtTotal = new TextBox();
            txtDip = new TextBox();
            txtDifference = new TextBox();
            btnCalculate = new Button();
            btnSave = new Button();
            dgvStock = new DataGridView();
            lblFuel = new Label();
            lblOpening = new Label();
            lblSales = new Label();
            lblReceived = new Label();
            lblClosing = new Label();
            lblTotal = new Label();
            lblDip = new Label();
            lblDifference = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 52);
            label1.Name = "label1";
            label1.Size = new Size(448, 54);
            label1.TabIndex = 0;
            label1.Text = "STOCK MANAGEMENT";
            // 
            // cmbFuel
            // 
            cmbFuel.FormattingEnabled = true;
            cmbFuel.Location = new Point(503, 132);
            cmbFuel.Name = "cmbFuel";
            cmbFuel.Size = new Size(182, 33);
            cmbFuel.TabIndex = 1;
            // 
            // txtOpening
            // 
            txtOpening.Location = new Point(252, 196);
            txtOpening.Name = "txtOpening";
            txtOpening.Size = new Size(235, 31);
            txtOpening.TabIndex = 2;
            // 
            // txtSales
            // 
            txtSales.Location = new Point(692, 194);
            txtSales.Name = "txtSales";
            txtSales.Size = new Size(235, 31);
            txtSales.TabIndex = 3;
            // 
            // txtReceived
            // 
            txtReceived.Location = new Point(252, 240);
            txtReceived.Name = "txtReceived";
            txtReceived.Size = new Size(235, 31);
            txtReceived.TabIndex = 4;
            // 
            // txtClosing
            // 
            txtClosing.Location = new Point(692, 237);
            txtClosing.Name = "txtClosing";
            txtClosing.Size = new Size(235, 31);
            txtClosing.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(252, 284);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(235, 31);
            txtTotal.TabIndex = 6;
            // 
            // txtDip
            // 
            txtDip.Location = new Point(692, 284);
            txtDip.Name = "txtDip";
            txtDip.Size = new Size(235, 31);
            txtDip.TabIndex = 7;
            // 
            // txtDifference
            // 
            txtDifference.Location = new Point(692, 331);
            txtDifference.Name = "txtDifference";
            txtDifference.Size = new Size(235, 31);
            txtDifference.TabIndex = 8;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(220, 331);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(357, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(32, 400);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 62;
            dgvStock.Size = new Size(935, 238);
            dgvStock.TabIndex = 11;
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.Location = new Point(357, 135);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(44, 25);
            lblFuel.TabIndex = 12;
            lblFuel.Text = "Fuel";
            // 
            // lblOpening
            // 
            lblOpening.AutoSize = true;
            lblOpening.Location = new Point(71, 202);
            lblOpening.Name = "lblOpening";
            lblOpening.Size = new Size(129, 25);
            lblOpening.TabIndex = 13;
            lblOpening.Text = "Opening Stock";
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Location = new Point(554, 196);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(52, 25);
            lblSales.TabIndex = 14;
            lblSales.Text = "Sales";
            // 
            // lblReceived
            // 
            lblReceived.AutoSize = true;
            lblReceived.Location = new Point(71, 246);
            lblReceived.Name = "lblReceived";
            lblReceived.Size = new Size(129, 25);
            lblReceived.TabIndex = 15;
            lblReceived.Text = "Recieved Stock";
            // 
            // lblClosing
            // 
            lblClosing.AutoSize = true;
            lblClosing.Location = new Point(554, 237);
            lblClosing.Name = "lblClosing";
            lblClosing.Size = new Size(71, 25);
            lblClosing.TabIndex = 16;
            lblClosing.Text = "Closing";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(71, 290);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 25);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total Stock";
            // 
            // lblDip
            // 
            lblDip.AutoSize = true;
            lblDip.Location = new Point(554, 284);
            lblDip.Name = "lblDip";
            lblDip.Size = new Size(40, 25);
            lblDip.TabIndex = 18;
            lblDip.Text = "Dip";
            // 
            // lblDifference
            // 
            lblDifference.AutoSize = true;
            lblDifference.Location = new Point(554, 331);
            lblDifference.Name = "lblDifference";
            lblDifference.Size = new Size(92, 25);
            lblDifference.TabIndex = 19;
            lblDifference.Text = "Difference";
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(lblDifference);
            Controls.Add(lblDip);
            Controls.Add(lblTotal);
            Controls.Add(lblClosing);
            Controls.Add(lblReceived);
            Controls.Add(lblSales);
            Controls.Add(lblOpening);
            Controls.Add(lblFuel);
            Controls.Add(dgvStock);
            Controls.Add(btnSave);
            Controls.Add(btnCalculate);
            Controls.Add(txtDifference);
            Controls.Add(txtDip);
            Controls.Add(txtTotal);
            Controls.Add(txtClosing);
            Controls.Add(txtReceived);
            Controls.Add(txtSales);
            Controls.Add(txtOpening);
            Controls.Add(cmbFuel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockForm";
            Text = "StockForm";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbFuel;
        private TextBox txtOpening;
        private TextBox txtSales;
        private TextBox txtReceived;
        private TextBox txtClosing;
        private TextBox txtTotal;
        private TextBox txtDip;
        private TextBox txtDifference;
        private Button btnCalculate;
        private Button btnSave;
        private DataGridView dgvStock;
        private Label lblFuel;
        private Label lblOpening;
        private Label lblSales;
        private Label lblReceived;
        private Label lblClosing;
        private Label lblTotal;
        private Label lblDip;
        private Label lblDifference;
    }
}