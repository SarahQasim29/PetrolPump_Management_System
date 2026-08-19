namespace PetrolPumpManagementSystem.Forms
{
    partial class TransactionsForm
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
            txtPerson = new TextBox();
            txtTaken = new TextBox();
            txtReturned = new TextBox();
            txtBalance = new TextBox();
            dtDate = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblPerson = new Label();
            lblFuel = new Label();
            lblTaken = new Label();
            lblReturned = new Label();
            lblBalance = new Label();
            lblDate = new Label();
            dgvTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 39);
            label1.Name = "label1";
            label1.Size = new Size(326, 54);
            label1.TabIndex = 0;
            label1.Text = "TRANSACTIONS";
            // 
            // cmbFuel
            // 
            cmbFuel.FormattingEnabled = true;
            cmbFuel.Location = new Point(471, 164);
            cmbFuel.Name = "cmbFuel";
            cmbFuel.Size = new Size(182, 33);
            cmbFuel.TabIndex = 1;
            // 
            // txtPerson
            // 
            txtPerson.Location = new Point(471, 116);
            txtPerson.Name = "txtPerson";
            txtPerson.Size = new Size(235, 31);
            txtPerson.TabIndex = 2;
            // 
            // txtTaken
            // 
            txtTaken.Location = new Point(471, 213);
            txtTaken.Name = "txtTaken";
            txtTaken.Size = new Size(235, 31);
            txtTaken.TabIndex = 3;
            // 
            // txtReturned
            // 
            txtReturned.Location = new Point(471, 262);
            txtReturned.Name = "txtReturned";
            txtReturned.Size = new Size(235, 31);
            txtReturned.TabIndex = 4;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(471, 312);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(235, 31);
            txtBalance.TabIndex = 5;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(471, 358);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(300, 31);
            dtDate.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(253, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(434, 416);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(622, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(298, 119);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(117, 25);
            lblPerson.TabIndex = 10;
            lblPerson.Text = "Person Name";
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.Location = new Point(371, 172);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(44, 25);
            lblFuel.TabIndex = 11;
            lblFuel.Text = "Fuel";
            // 
            // lblTaken
            // 
            lblTaken.AutoSize = true;
            lblTaken.Location = new Point(299, 219);
            lblTaken.Name = "lblTaken";
            lblTaken.Size = new Size(116, 25);
            lblTaken.TabIndex = 12;
            lblTaken.Text = "Money Taken";
            // 
            // lblReturned
            // 
            lblReturned.AutoSize = true;
            lblReturned.Location = new Point(272, 265);
            lblReturned.Name = "lblReturned";
            lblReturned.Size = new Size(143, 25);
            lblReturned.TabIndex = 13;
            lblReturned.Text = "Money Returned";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.ForeColor = Color.Black;
            lblBalance.Location = new Point(344, 312);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(71, 25);
            lblBalance.TabIndex = 14;
            lblBalance.Text = "Balance";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(366, 358);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 25);
            lblDate.TabIndex = 15;
            lblDate.Text = "Date";
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(46, 471);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.Size = new Size(902, 167);
            dgvTransactions.TabIndex = 16;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(dgvTransactions);
            Controls.Add(lblDate);
            Controls.Add(lblBalance);
            Controls.Add(lblReturned);
            Controls.Add(lblTaken);
            Controls.Add(lblFuel);
            Controls.Add(lblPerson);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dtDate);
            Controls.Add(txtBalance);
            Controls.Add(txtReturned);
            Controls.Add(txtTaken);
            Controls.Add(txtPerson);
            Controls.Add(cmbFuel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionsForm";
            Text = "TransactionsForm";
            TopMost = true;
            //Load += TransactionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbFuel;
        private TextBox txtPerson;
        private TextBox txtTaken;
        private TextBox txtReturned;
        private TextBox txtBalance;
        private DateTimePicker dtDate;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblPerson;
        private Label lblFuel;
        private Label lblTaken;
        private Label lblReturned;
        private Label lblBalance;
        private Label lblDate;
        private DataGridView dgvTransactions;
    }
}