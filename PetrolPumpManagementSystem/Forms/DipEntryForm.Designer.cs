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
            label1 = new Label();
            cmbFuel = new ComboBox();
            lblFuel = new Label();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            txtMorningBefore = new TextBox();
            txtMorningAfter = new TextBox();
            txtMorningWithdrawn = new TextBox();
            txtNightBefore = new TextBox();
            txtNightAfter = new TextBox();
            txtNightWithdrawn = new TextBox();
            txtTotalWithdrawn = new TextBox();
            txtCashExpected = new TextBox();
            lblMorningBefore = new Label();
            lblMorningAfter = new Label();
            lblMorningWithdrawn = new Label();
            lblNightBefore = new Label();
            lblNightAfter = new Label();
            lblNightWithdrawn = new Label();
            lblTotalWithdrawn = new Label();
            lblCashExpected = new Label();
            btnCalculate = new Button();
            btnSave = new Button();
            dgvDip = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDip).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 35);
            label1.Name = "label1";
            label1.Size = new Size(228, 54);
            label1.TabIndex = 0;
            label1.Text = "DIP ENTRY";
            // 
            // cmbFuel
            // 
            cmbFuel.FormattingEnabled = true;
            cmbFuel.Location = new Point(448, 99);
            cmbFuel.Name = "cmbFuel";
            cmbFuel.Size = new Size(182, 33);
            cmbFuel.TabIndex = 1;
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.Location = new Point(332, 99);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(44, 25);
            lblFuel.TabIndex = 3;
            lblFuel.Text = "Feul";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(327, 142);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // dtDate
            // 
            dtDate.Location = new Point(448, 142);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(300, 31);
            dtDate.TabIndex = 5;
            // 
            // txtMorningBefore
            // 
            txtMorningBefore.Location = new Point(226, 205);
            txtMorningBefore.Name = "txtMorningBefore";
            txtMorningBefore.Size = new Size(235, 31);
            txtMorningBefore.TabIndex = 6;
            // 
            // txtMorningAfter
            // 
            txtMorningAfter.Location = new Point(226, 255);
            txtMorningAfter.Name = "txtMorningAfter";
            txtMorningAfter.Size = new Size(235, 31);
            txtMorningAfter.TabIndex = 7;
            // 
            // txtMorningWithdrawn
            // 
            txtMorningWithdrawn.Location = new Point(226, 302);
            txtMorningWithdrawn.Name = "txtMorningWithdrawn";
            txtMorningWithdrawn.Size = new Size(235, 31);
            txtMorningWithdrawn.TabIndex = 8;
            // 
            // txtNightBefore
            // 
            txtNightBefore.Location = new Point(694, 205);
            txtNightBefore.Name = "txtNightBefore";
            txtNightBefore.Size = new Size(235, 31);
            txtNightBefore.TabIndex = 9;
            // 
            // txtNightAfter
            // 
            txtNightAfter.Location = new Point(694, 252);
            txtNightAfter.Name = "txtNightAfter";
            txtNightAfter.Size = new Size(235, 31);
            txtNightAfter.TabIndex = 10;
            // 
            // txtNightWithdrawn
            // 
            txtNightWithdrawn.Location = new Point(694, 302);
            txtNightWithdrawn.Name = "txtNightWithdrawn";
            txtNightWithdrawn.Size = new Size(235, 31);
            txtNightWithdrawn.TabIndex = 11;
            // 
            // txtTotalWithdrawn
            // 
            txtTotalWithdrawn.Location = new Point(494, 359);
            txtTotalWithdrawn.Name = "txtTotalWithdrawn";
            txtTotalWithdrawn.Size = new Size(215, 31);
            txtTotalWithdrawn.TabIndex = 12;
            // 
            // txtCashExpected
            // 
            txtCashExpected.Location = new Point(494, 399);
            txtCashExpected.Name = "txtCashExpected";
            txtCashExpected.Size = new Size(215, 31);
            txtCashExpected.TabIndex = 13;
            // 
            // lblMorningBefore
            // 
            lblMorningBefore.AutoSize = true;
            lblMorningBefore.Location = new Point(45, 205);
            lblMorningBefore.Name = "lblMorningBefore";
            lblMorningBefore.Size = new Size(136, 25);
            lblMorningBefore.TabIndex = 14;
            lblMorningBefore.Text = "Morning Before";
            // 
            // lblMorningAfter
            // 
            lblMorningAfter.AutoSize = true;
            lblMorningAfter.Location = new Point(45, 258);
            lblMorningAfter.Name = "lblMorningAfter";
            lblMorningAfter.Size = new Size(129, 25);
            lblMorningAfter.TabIndex = 15;
            lblMorningAfter.Text = " Morning After";
            // 
            // lblMorningWithdrawn
            // 
            lblMorningWithdrawn.AutoSize = true;
            lblMorningWithdrawn.Location = new Point(45, 308);
            lblMorningWithdrawn.Name = "lblMorningWithdrawn";
            lblMorningWithdrawn.Size = new Size(171, 25);
            lblMorningWithdrawn.TabIndex = 16;
            lblMorningWithdrawn.Text = "Morning Withdrawn";
            // 
            // lblNightBefore
            // 
            lblNightBefore.AutoSize = true;
            lblNightBefore.Location = new Point(535, 208);
            lblNightBefore.Name = "lblNightBefore";
            lblNightBefore.Size = new Size(112, 25);
            lblNightBefore.TabIndex = 17;
            lblNightBefore.Text = "Night Before";
            // 
            // lblNightAfter
            // 
            lblNightAfter.AutoSize = true;
            lblNightAfter.Location = new Point(535, 255);
            lblNightAfter.Name = "lblNightAfter";
            lblNightAfter.Size = new Size(100, 25);
            lblNightAfter.TabIndex = 18;
            lblNightAfter.Text = "Night After";
            // 
            // lblNightWithdrawn
            // 
            lblNightWithdrawn.AutoSize = true;
            lblNightWithdrawn.Location = new Point(535, 308);
            lblNightWithdrawn.Name = "lblNightWithdrawn";
            lblNightWithdrawn.Size = new Size(147, 25);
            lblNightWithdrawn.TabIndex = 19;
            lblNightWithdrawn.Text = "Night Withdrawn";
            // 
            // lblTotalWithdrawn
            // 
            lblTotalWithdrawn.AutoSize = true;
            lblTotalWithdrawn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalWithdrawn.Location = new Point(277, 362);
            lblTotalWithdrawn.Name = "lblTotalWithdrawn";
            lblTotalWithdrawn.Size = new Size(170, 28);
            lblTotalWithdrawn.TabIndex = 20;
            lblTotalWithdrawn.Text = "Total Withdrawn";
            // 
            // lblCashExpected
            // 
            lblCashExpected.AutoSize = true;
            lblCashExpected.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashExpected.Location = new Point(277, 399);
            lblCashExpected.Name = "lblCashExpected";
            lblCashExpected.Size = new Size(148, 28);
            lblCashExpected.TabIndex = 21;
            lblCashExpected.Text = "Cash Expected";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(381, 445);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 22;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(518, 445);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvDip
            // 
            dgvDip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDip.Location = new Point(45, 496);
            dgvDip.Name = "dgvDip";
            dgvDip.RowHeadersWidth = 62;
            dgvDip.Size = new Size(904, 142);
            dgvDip.TabIndex = 24;
            // 
            // DipEntryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(dgvDip);
            Controls.Add(btnSave);
            Controls.Add(btnCalculate);
            Controls.Add(lblCashExpected);
            Controls.Add(lblTotalWithdrawn);
            Controls.Add(lblNightWithdrawn);
            Controls.Add(lblNightAfter);
            Controls.Add(lblNightBefore);
            Controls.Add(lblMorningWithdrawn);
            Controls.Add(lblMorningAfter);
            Controls.Add(lblMorningBefore);
            Controls.Add(txtCashExpected);
            Controls.Add(txtTotalWithdrawn);
            Controls.Add(txtNightWithdrawn);
            Controls.Add(txtNightAfter);
            Controls.Add(txtNightBefore);
            Controls.Add(txtMorningWithdrawn);
            Controls.Add(txtMorningAfter);
            Controls.Add(txtMorningBefore);
            Controls.Add(dtDate);
            Controls.Add(lblDate);
            Controls.Add(lblFuel);
            Controls.Add(cmbFuel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DipEntryForm";
            Text = "DipEntryForm";
            ((System.ComponentModel.ISupportInitialize)dgvDip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbFuel;
        private Label lblFuel;
        private Label lblDate;
        private DateTimePicker dtDate;
        private TextBox txtMorningBefore;
        private TextBox txtMorningAfter;
        private TextBox txtMorningWithdrawn;
        private TextBox txtNightBefore;
        private TextBox txtNightAfter;
        private TextBox txtNightWithdrawn;
        private TextBox txtTotalWithdrawn;
        private TextBox txtCashExpected;
        private Label lblMorningBefore;
        private Label lblMorningAfter;
        private Label lblMorningWithdrawn;
        private Label lblNightBefore;
        private Label lblNightAfter;
        private Label lblNightWithdrawn;
        private Label lblTotalWithdrawn;
        private Label lblCashExpected;
        private Button btnCalculate;
        private Button btnSave;
        private DataGridView dgvDip;
    }
}