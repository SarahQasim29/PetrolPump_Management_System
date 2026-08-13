namespace PetrolPumpManagementSystem.Forms
{
    partial class UsersForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            grpUserInformation = new GroupBox();
            lblUserDescription = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            grpUserList = new GroupBox();
            blUserListDescription = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvUsers = new DataGridView();
            pnlHeader.SuspendLayout();
            grpUserInformation.SuspendLayout();
            grpUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1174, 85);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(32, -8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(406, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "User Management";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(43, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(339, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage system users and their access";
            // 
            // grpUserInformation
            // 
            grpUserInformation.BackColor = Color.White;
            grpUserInformation.Controls.Add(btnClear);
            grpUserInformation.Controls.Add(btnUpdate);
            grpUserInformation.Controls.Add(btnAdd);
            grpUserInformation.Controls.Add(cmbStatus);
            grpUserInformation.Controls.Add(lblStatus);
            grpUserInformation.Controls.Add(cmbRole);
            grpUserInformation.Controls.Add(lblRole);
            grpUserInformation.Controls.Add(txtConfirmPassword);
            grpUserInformation.Controls.Add(lblConfirmPassword);
            grpUserInformation.Controls.Add(txtPassword);
            grpUserInformation.Controls.Add(lblPassword);
            grpUserInformation.Controls.Add(txtEmail);
            grpUserInformation.Controls.Add(lblEmail);
            grpUserInformation.Controls.Add(txtPhoneNumber);
            grpUserInformation.Controls.Add(lblPhoneNumber);
            grpUserInformation.Controls.Add(txtUsername);
            grpUserInformation.Controls.Add(lblUsername);
            grpUserInformation.Controls.Add(txtFullName);
            grpUserInformation.Controls.Add(lblFullName);
            grpUserInformation.Controls.Add(lblUserDescription);
            grpUserInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUserInformation.ForeColor = Color.Black;
            grpUserInformation.Location = new Point(30, 104);
            grpUserInformation.Name = "grpUserInformation";
            grpUserInformation.Size = new Size(1050, 370);
            grpUserInformation.TabIndex = 1;
            grpUserInformation.TabStop = false;
            grpUserInformation.Text = "USER INFORMATION";
            // 
            // lblUserDescription
            // 
            lblUserDescription.AutoSize = true;
            lblUserDescription.BackColor = Color.Transparent;
            lblUserDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserDescription.ForeColor = Color.DimGray;
            lblUserDescription.Location = new Point(13, 46);
            lblUserDescription.Name = "lblUserDescription";
            lblUserDescription.Size = new Size(325, 25);
            lblUserDescription.TabIndex = 0;
            lblUserDescription.Text = "Create or update a system user account";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(23, 83);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(97, 25);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(160, 83);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 34);
            txtFullName.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(478, 74);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(678, 74);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 34);
            txtUsername.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(478, 143);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(140, 25);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtPhoneNumber.Location = new Point(678, 134);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(250, 34);
            txtPhoneNumber.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(23, 157);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(131, 25);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(160, 151);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@email.com";
            txtEmail.Size = new Size(250, 34);
            txtEmail.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(23, 215);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(92, 25);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(160, 209);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 34);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(478, 215);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(165, 25);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(678, 206);
            txtConfirmPassword.MaxLength = 255;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(250, 34);
            txtConfirmPassword.TabIndex = 12;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(23, 278);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(93, 25);
            lblRole.TabIndex = 13;
            lblRole.Text = "User Role";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(160, 272);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(250, 36);
            cmbRole.TabIndex = 14;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(478, 273);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(141, 25);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Account Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(678, 267);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 36);
            cmbStatus.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(462, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 35);
            btnAdd.TabIndex = 17;
            btnAdd.TabStop = false;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(578, 322);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 42);
            btnUpdate.TabIndex = 18;
            btnUpdate.TabStop = false;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(708, 322);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 35);
            btnClear.TabIndex = 19;
            btnClear.TabStop = false;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // grpUserList
            // 
            grpUserList.BackColor = Color.White;
            grpUserList.Controls.Add(dgvUsers);
            grpUserList.Controls.Add(txtSearch);
            grpUserList.Controls.Add(lblSearch);
            grpUserList.Controls.Add(blUserListDescription);
            grpUserList.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUserList.ForeColor = Color.Black;
            grpUserList.Location = new Point(30, 480);
            grpUserList.Name = "grpUserList";
            grpUserList.Size = new Size(920, 390);
            grpUserList.TabIndex = 2;
            grpUserList.TabStop = false;
            grpUserList.Text = "USER LIST";
            // 
            // blUserListDescription
            // 
            blUserListDescription.AutoSize = true;
            blUserListDescription.Font = new Font("Segoe UI", 9F);
            blUserListDescription.ForeColor = Color.DimGray;
            blUserListDescription.Location = new Point(25, 35);
            blUserListDescription.Name = "blUserListDescription";
            blUserListDescription.Size = new Size(390, 25);
            blUserListDescription.TabIndex = 0;
            blUserListDescription.Text = "View, search and manage existing user accounts";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(25, 65);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(120, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Users";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(25, 88);
            txtSearch.MaxLength = 100;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name, username, phone or email...";
            txtSearch.Size = new Size(840, 34);
            txtSearch.TabIndex = 2;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle8;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Location = new Point(25, 135);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = Color.White;
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(840, 220);
            dgvUsers.TabIndex = 3;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 800);
            Controls.Add(grpUserList);
            Controls.Add(grpUserInformation);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User Management";
            TopMost = true;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpUserInformation.ResumeLayout(false);
            grpUserInformation.PerformLayout();
            grpUserList.ResumeLayout(false);
            grpUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private GroupBox grpUserInformation;
        private Label lblUserDescription;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private GroupBox grpUserList;
        private Label blUserListDescription;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvUsers;
    }
}