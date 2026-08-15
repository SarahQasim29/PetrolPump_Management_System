namespace PetrolPumpManagementSystem.Forms
{
    partial class SettingsForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            grpGeneralSettings = new GroupBox();
            grpSystemSettings = new Label();
            lblGeneralDescription = new Label();
            lblPumpName = new Label();
            txtPumpName = new TextBox();
            lblPumpPhone = new Label();
            txtPumpPhone = new TextBox();
            lblPumpAddress = new Label();
            txtPumpAddress = new TextBox();
            lblPumpEmail = new Label();
            txtPumpEmail = new TextBox();
            groupBox1 = new GroupBox();
            lblSystemDescription = new Label();
            lblCurrency = new Label();
            cmbCurrency = new ComboBox();
            lblOpeningDipTime = new Label();
            dtpOpeningDipTime = new DateTimePicker();
            lblDateFormat = new Label();
            cmbDateFormat = new ComboBox();
            lblLowStockAlert = new Label();
            txtLowStockAlert = new TextBox();
            btnSave = new Button();
            btnReset = new Button();
            lblStatusMessage = new Label();
            pnlHeader.SuspendLayout();
            grpGeneralSettings.SuspendLayout();
            groupBox1.SuspendLayout();
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
            pnlHeader.Size = new Size(1000, 120);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(30, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(354, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "System Settings";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(39, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(383, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Configure petrol pump system preferences";
            // 
            // grpGeneralSettings
            // 
            grpGeneralSettings.BackColor = Color.White;
            grpGeneralSettings.Controls.Add(txtPumpEmail);
            grpGeneralSettings.Controls.Add(lblPumpEmail);
            grpGeneralSettings.Controls.Add(txtPumpAddress);
            grpGeneralSettings.Controls.Add(lblPumpAddress);
            grpGeneralSettings.Controls.Add(txtPumpPhone);
            grpGeneralSettings.Controls.Add(lblPumpPhone);
            grpGeneralSettings.Controls.Add(txtPumpName);
            grpGeneralSettings.Controls.Add(lblPumpName);
            grpGeneralSettings.Controls.Add(lblGeneralDescription);
            grpGeneralSettings.Controls.Add(grpSystemSettings);
            grpGeneralSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpGeneralSettings.ForeColor = Color.Black;
            grpGeneralSettings.Location = new Point(12, 145);
            grpGeneralSettings.Name = "grpGeneralSettings";
            grpGeneralSettings.Size = new Size(920, 230);
            grpGeneralSettings.TabIndex = 1;
            grpGeneralSettings.TabStop = false;
            grpGeneralSettings.Text = "GENERAL SETTINGS";
            grpGeneralSettings.Enter += grpGeneralSettings_Enter;
            // 
            // grpSystemSettings
            // 
            grpSystemSettings.AutoSize = true;
            grpSystemSettings.Location = new Point(30, 355);
            grpSystemSettings.Name = "grpSystemSettings";
            grpSystemSettings.Size = new Size(187, 28);
            grpSystemSettings.TabIndex = 0;
            grpSystemSettings.Text = "SYSTEM SETTINGS";
            // 
            // lblGeneralDescription
            // 
            lblGeneralDescription.AutoSize = true;
            lblGeneralDescription.BackColor = Color.Transparent;
            lblGeneralDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGeneralDescription.ForeColor = Color.DimGray;
            lblGeneralDescription.Location = new Point(25, 35);
            lblGeneralDescription.Name = "lblGeneralDescription";
            lblGeneralDescription.Size = new Size(347, 25);
            lblGeneralDescription.TabIndex = 1;
            lblGeneralDescription.Text = "Basic information about your petrol pump";
            lblGeneralDescription.Click += label1_Click;
            // 
            // lblPumpName
            // 
            lblPumpName.AutoSize = true;
            lblPumpName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPumpName.Location = new Point(25, 65);
            lblPumpName.Name = "lblPumpName";
            lblPumpName.Size = new Size(116, 25);
            lblPumpName.TabIndex = 2;
            lblPumpName.Text = "Pump Name";
            // 
            // txtPumpName
            // 
            txtPumpName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPumpName.Location = new Point(210, 65);
            txtPumpName.MaxLength = 100;
            txtPumpName.Name = "txtPumpName";
            txtPumpName.Size = new Size(200, 34);
            txtPumpName.TabIndex = 3;
            txtPumpName.TextChanged += txtPumpName_TextChanged;
            // 
            // lblPumpPhone
            // 
            lblPumpPhone.AutoSize = true;
            lblPumpPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPumpPhone.Location = new Point(464, 65);
            lblPumpPhone.Name = "lblPumpPhone";
            lblPumpPhone.Size = new Size(140, 25);
            lblPumpPhone.TabIndex = 4;
            lblPumpPhone.Text = "Phone Number";
            // 
            // txtPumpPhone
            // 
            txtPumpPhone.Location = new Point(681, 59);
            txtPumpPhone.Name = "txtPumpPhone";
            txtPumpPhone.Size = new Size(200, 34);
            txtPumpPhone.TabIndex = 5;
            // 
            // lblPumpAddress
            // 
            lblPumpAddress.AutoSize = true;
            lblPumpAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPumpAddress.Location = new Point(27, 132);
            lblPumpAddress.Name = "lblPumpAddress";
            lblPumpAddress.Size = new Size(134, 25);
            lblPumpAddress.TabIndex = 6;
            lblPumpAddress.Text = "Pump Address";
            // 
            // txtPumpAddress
            // 
            txtPumpAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPumpAddress.Location = new Point(210, 129);
            txtPumpAddress.MaxLength = 250;
            txtPumpAddress.Name = "txtPumpAddress";
            txtPumpAddress.Size = new Size(200, 34);
            txtPumpAddress.TabIndex = 7;
            // 
            // lblPumpEmail
            // 
            lblPumpEmail.AutoSize = true;
            lblPumpEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPumpEmail.Location = new Point(464, 138);
            lblPumpEmail.Name = "lblPumpEmail";
            lblPumpEmail.Size = new Size(131, 25);
            lblPumpEmail.TabIndex = 8;
            lblPumpEmail.Text = "Email Address";
            // 
            // txtPumpEmail
            // 
            txtPumpEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPumpEmail.Location = new Point(681, 132);
            txtPumpEmail.MaxLength = 100;
            txtPumpEmail.Name = "txtPumpEmail";
            txtPumpEmail.PlaceholderText = "example@email.com";
            txtPumpEmail.Size = new Size(200, 34);
            txtPumpEmail.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtLowStockAlert);
            groupBox1.Controls.Add(lblLowStockAlert);
            groupBox1.Controls.Add(cmbDateFormat);
            groupBox1.Controls.Add(lblDateFormat);
            groupBox1.Controls.Add(dtpOpeningDipTime);
            groupBox1.Controls.Add(lblOpeningDipTime);
            groupBox1.Controls.Add(cmbCurrency);
            groupBox1.Controls.Add(lblCurrency);
            groupBox1.Controls.Add(lblSystemDescription);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(21, 391);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 230);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "SYSTEM SETTINGS";
            // 
            // lblSystemDescription
            // 
            lblSystemDescription.AutoSize = true;
            lblSystemDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSystemDescription.ForeColor = Color.DimGray;
            lblSystemDescription.Location = new Point(25, 35);
            lblSystemDescription.Name = "lblSystemDescription";
            lblSystemDescription.Size = new Size(371, 25);
            lblSystemDescription.TabIndex = 0;
            lblSystemDescription.Text = "Configure operational settings for the system";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrency.Location = new Point(25, 65);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(88, 25);
            lblCurrency.TabIndex = 1;
            lblCurrency.Text = "Currency";
            // 
            // cmbCurrency
            // 
            cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrency.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCurrency.FormattingEnabled = true;
            cmbCurrency.Location = new Point(201, 63);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(200, 36);
            cmbCurrency.TabIndex = 2;
            // 
            // lblOpeningDipTime
            // 
            lblOpeningDipTime.AutoSize = true;
            lblOpeningDipTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpeningDipTime.Location = new Point(455, 69);
            lblOpeningDipTime.Name = "lblOpeningDipTime";
            lblOpeningDipTime.Size = new Size(166, 25);
            lblOpeningDipTime.TabIndex = 3;
            lblOpeningDipTime.Text = "Opening Dip Time";
            // 
            // dtpOpeningDipTime
            // 
            dtpOpeningDipTime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpOpeningDipTime.Format = DateTimePickerFormat.Time;
            dtpOpeningDipTime.Location = new Point(672, 65);
            dtpOpeningDipTime.Name = "dtpOpeningDipTime";
            dtpOpeningDipTime.ShowUpDown = true;
            dtpOpeningDipTime.Size = new Size(200, 34);
            dtpOpeningDipTime.TabIndex = 4;
            // 
            // lblDateFormat
            // 
            lblDateFormat.AutoSize = true;
            lblDateFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateFormat.Location = new Point(25, 132);
            lblDateFormat.Name = "lblDateFormat";
            lblDateFormat.Size = new Size(117, 25);
            lblDateFormat.TabIndex = 5;
            lblDateFormat.Text = "Date Format";
            // 
            // cmbDateFormat
            // 
            cmbDateFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDateFormat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDateFormat.FormattingEnabled = true;
            cmbDateFormat.Location = new Point(201, 140);
            cmbDateFormat.Name = "cmbDateFormat";
            cmbDateFormat.Size = new Size(200, 36);
            cmbDateFormat.TabIndex = 6;
            // 
            // lblLowStockAlert
            // 
            lblLowStockAlert.AutoSize = true;
            lblLowStockAlert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockAlert.Location = new Point(455, 140);
            lblLowStockAlert.Name = "lblLowStockAlert";
            lblLowStockAlert.Size = new Size(211, 25);
            lblLowStockAlert.TabIndex = 7;
            lblLowStockAlert.Text = "Low Stock Alert (Liters)";
            // 
            // txtLowStockAlert
            // 
            txtLowStockAlert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLowStockAlert.Location = new Point(672, 137);
            txtLowStockAlert.MaxLength = 10;
            txtLowStockAlert.Name = "txtLowStockAlert";
            txtLowStockAlert.Size = new Size(200, 31);
            txtLowStockAlert.TabIndex = 8;
            txtLowStockAlert.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(476, 636);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 45);
            btnSave.TabIndex = 3;
            btnSave.TabStop = false;
            btnSave.Text = "Save Settings";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(657, 636);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 45);
            btnReset.TabIndex = 4;
            btnReset.TabStop = false;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.ForeColor = Color.DimGray;
            lblStatusMessage.Location = new Point(476, 728);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(296, 25);
            lblStatusMessage.TabIndex = 5;
            lblStatusMessage.Text = "Settings are ready to be configured.";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 800);
            Controls.Add(lblStatusMessage);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(grpGeneralSettings);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "System Settings";
            TopMost = true;
            Load += SettingsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpGeneralSettings.ResumeLayout(false);
            grpGeneralSettings.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private GroupBox grpGeneralSettings;
        private Label grpSystemSettings;
        private Label lblGeneralDescription;
        private Label lblPumpName;
        private TextBox txtPumpName;
        private Label lblPumpPhone;
        private TextBox txtPumpPhone;
        private Label lblPumpAddress;
        private TextBox txtPumpAddress;
        private Label lblPumpEmail;
        private TextBox txtPumpEmail;
        private GroupBox groupBox1;
        private Label lblSystemDescription;
        private Label lblCurrency;
        private ComboBox cmbCurrency;
        private Label lblOpeningDipTime;
        private DateTimePicker dtpOpeningDipTime;
        private Label lblDateFormat;
        private ComboBox cmbDateFormat;
        private Label lblLowStockAlert;
        private TextBox txtLowStockAlert;
        private Button btnSave;
        private Button btnReset;
        private Label lblStatusMessage;
    }
}