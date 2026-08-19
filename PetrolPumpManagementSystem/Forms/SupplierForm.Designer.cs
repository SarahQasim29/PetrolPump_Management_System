namespace PetrolPumpManagementSystem.Forms
{
    partial class SupplierForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        // Main Panel
        private System.Windows.Forms.Panel pnlMain;

        // Supplier Fields
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;

        // Buttons
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;

        // Search
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        // Grid
        private System.Windows.Forms.DataGridView dgvSuppliers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlMain = new Panel();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblContactPerson = new Label();
            txtContactPerson = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            pnlActions = new Panel();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            pnlSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvSuppliers = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1250, 106);
            pnlHeader.TabIndex = 4;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(38, 15);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(556, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SUPPLIER MANAGEMENT";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(40, 65);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(203, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage fuel suppliers";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(lblSupplierName);
            pnlMain.Controls.Add(txtSupplierName);
            pnlMain.Controls.Add(lblContactPerson);
            pnlMain.Controls.Add(txtContactPerson);
            pnlMain.Controls.Add(lblPhone);
            pnlMain.Controls.Add(txtPhone);
            pnlMain.Controls.Add(lblEmail);
            pnlMain.Controls.Add(txtEmail);
            pnlMain.Controls.Add(lblAddress);
            pnlMain.Controls.Add(txtAddress);
            pnlMain.Dock = DockStyle.Top;
            pnlMain.Location = new Point(0, 106);
            pnlMain.Margin = new Padding(4, 4, 4, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1250, 288);
            pnlMain.TabIndex = 3;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSupplierName.Location = new Point(38, 25);
            lblSupplierName.Margin = new Padding(4, 0, 4, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(157, 28);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "Supplier Name:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(225, 20);
            txtSupplierName.Margin = new Padding(4, 4, 4, 4);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(499, 31);
            txtSupplierName.TabIndex = 0;
            // 
            // lblContactPerson
            // 
            lblContactPerson.AutoSize = true;
            lblContactPerson.Font = new Font("Segoe UI", 10F);
            lblContactPerson.Location = new Point(38, 81);
            lblContactPerson.Margin = new Padding(4, 0, 4, 0);
            lblContactPerson.Name = "lblContactPerson";
            lblContactPerson.Size = new Size(147, 28);
            lblContactPerson.TabIndex = 1;
            lblContactPerson.Text = "Contact Person:";
            // 
            // txtContactPerson
            // 
            txtContactPerson.Location = new Point(225, 76);
            txtContactPerson.Margin = new Padding(4, 4, 4, 4);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(499, 31);
            txtContactPerson.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(38, 138);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(148, 28);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(225, 132);
            txtPhone.Margin = new Padding(4, 4, 4, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(499, 31);
            txtPhone.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(38, 194);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(225, 189);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(499, 31);
            txtEmail.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.Location = new Point(38, 244);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(86, 28);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(225, 239);
            txtAddress.Margin = new Padding(4, 4, 4, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(499, 31);
            txtAddress.TabIndex = 4;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.Controls.Add(btnSave);
            pnlActions.Controls.Add(btnUpdate);
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnClear);
            pnlActions.Controls.Add(btnRefresh);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(0, 394);
            pnlActions.Margin = new Padding(4, 4, 4, 4);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1250, 69);
            pnlActions.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(38, 12);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(175, 12);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 44);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(312, 12);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(450, 12);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 44);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(588, 12);
            btnRefresh.Margin = new Padding(4, 4, 4, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(125, 44);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 463);
            pnlSearch.Margin = new Padding(4, 4, 4, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1250, 69);
            pnlSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.Location = new Point(38, 19);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(173, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Suppliers:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(225, 15);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(499, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeight = 34;
            dgvSuppliers.Dock = DockStyle.Fill;
            dgvSuppliers.Location = new Point(0, 532);
            dgvSuppliers.Margin = new Padding(4, 4, 4, 4);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 62;
            dgvSuppliers.Size = new Size(1250, 274);
            dgvSuppliers.TabIndex = 0;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1250, 806);
            Controls.Add(dgvSuppliers);
            Controls.Add(pnlSearch);
            Controls.Add(pnlActions);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(1250, 806);
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Supplier Management";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }
    }
}