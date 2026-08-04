namespace PetrolPumpManagementSystem.Forms
{
    partial class DashboardHomeForm
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
            btnLogout = new Button();
            lblWelcome = new Label();
            lblTitle = new Label();
            pnlSidebar = new Panel();
            btnTransactions = new Button();
            btnUsers = new Button();
            btnSettings = new Button();
            btnLogoutLeft = new Button();
            btnReports = new Button();
            btnSales = new Button();
            btnStock = new Button();
            btnDipEntry = new Button();
            btnFuelPrice = new Button();
            btnDashboard = new Button();
            lblCompany = new Label();
            lblLogo = new Label();
            pnlContent = new Panel();
            lblTime = new Label();
            lblDate = new Label();
            pnlHome = new Panel();
            label12 = new Label();
            label11 = new Label();
            pnlStockAlert = new Panel();
            label5 = new Label();
            lblStockAlert = new Label();
            pnlTodaySales = new Panel();
            label7 = new Label();
            lblTodaySales = new Label();
            pnlDiesel = new Panel();
            label9 = new Label();
            lblDieselPrice = new Label();
            pnlPetrol = new Panel();
            label4 = new Label();
            lblPetrolPrice = new Label();
            statusStrip1 = new StatusStrip();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlHome.SuspendLayout();
            pnlStockAlert.SuspendLayout();
            pnlTodaySales.SuspendLayout();
            pnlDiesel.SuspendLayout();
            pnlPetrol.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SteelBlue;
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1296, 70);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1137, 22);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 35);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(950, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(167, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome Admin";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(680, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PETROL PUMP MANAGEMENT SYSTEM";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.MidnightBlue;
            pnlSidebar.Controls.Add(btnTransactions);
            pnlSidebar.Controls.Add(btnUsers);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnLogoutLeft);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnSales);
            pnlSidebar.Controls.Add(btnStock);
            pnlSidebar.Controls.Add(btnDipEntry);
            pnlSidebar.Controls.Add(btnFuelPrice);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblCompany);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 70);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 651);
            pnlSidebar.TabIndex = 1;
            // 
            // btnTransactions
            // 
            btnTransactions.FlatAppearance.BorderColor = Color.White;
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatAppearance.MouseDownBackColor = Color.White;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(10, 441);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(200, 45);
            btnTransactions.TabIndex = 12;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderColor = Color.White;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatAppearance.MouseDownBackColor = Color.White;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(10, 492);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(200, 45);
            btnUsers.TabIndex = 11;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderColor = Color.White;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.White;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(10, 543);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(200, 45);
            btnSettings.TabIndex = 10;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogoutLeft
            // 
            btnLogoutLeft.FlatAppearance.BorderColor = Color.White;
            btnLogoutLeft.FlatAppearance.BorderSize = 0;
            btnLogoutLeft.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogoutLeft.FlatStyle = FlatStyle.Flat;
            btnLogoutLeft.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogoutLeft.ForeColor = Color.White;
            btnLogoutLeft.Location = new Point(10, 594);
            btnLogoutLeft.Name = "btnLogoutLeft";
            btnLogoutLeft.Size = new Size(200, 45);
            btnLogoutLeft.TabIndex = 9;
            btnLogoutLeft.Text = "Logout";
            btnLogoutLeft.UseVisualStyleBackColor = true;
            btnLogoutLeft.Click += btnLogoutLeft_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderColor = Color.White;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.White;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(10, 396);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 45);
            btnReports.TabIndex = 7;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSales
            // 
            btnSales.FlatAppearance.BorderColor = Color.White;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatAppearance.MouseDownBackColor = Color.White;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(10, 345);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(200, 45);
            btnSales.TabIndex = 6;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnStock
            // 
            btnStock.FlatAppearance.BorderColor = Color.White;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.MouseDownBackColor = Color.White;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStock.ForeColor = Color.White;
            btnStock.Location = new Point(13, 294);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(200, 45);
            btnStock.TabIndex = 5;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnDipEntry
            // 
            btnDipEntry.FlatAppearance.BorderColor = Color.White;
            btnDipEntry.FlatAppearance.BorderSize = 0;
            btnDipEntry.FlatAppearance.MouseDownBackColor = Color.White;
            btnDipEntry.FlatStyle = FlatStyle.Flat;
            btnDipEntry.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDipEntry.ForeColor = Color.White;
            btnDipEntry.Location = new Point(13, 243);
            btnDipEntry.Name = "btnDipEntry";
            btnDipEntry.Size = new Size(200, 45);
            btnDipEntry.TabIndex = 4;
            btnDipEntry.Text = "Dip Entry";
            btnDipEntry.UseVisualStyleBackColor = true;
            btnDipEntry.Click += btnDipEntry_Click;
            // 
            // btnFuelPrice
            // 
            btnFuelPrice.FlatAppearance.BorderColor = Color.White;
            btnFuelPrice.FlatAppearance.BorderSize = 0;
            btnFuelPrice.FlatAppearance.MouseDownBackColor = Color.White;
            btnFuelPrice.FlatStyle = FlatStyle.Flat;
            btnFuelPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuelPrice.ForeColor = Color.White;
            btnFuelPrice.Location = new Point(14, 197);
            btnFuelPrice.Name = "btnFuelPrice";
            btnFuelPrice.Size = new Size(200, 45);
            btnFuelPrice.TabIndex = 3;
            btnFuelPrice.Text = "Fuel Prices";
            btnFuelPrice.UseVisualStyleBackColor = true;
            btnFuelPrice.Click += btnFuelPrice_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderColor = Color.White;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.White;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(12, 146);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompany.ForeColor = Color.White;
            lblCompany.Location = new Point(33, 88);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(156, 32);
            lblCompany.TabIndex = 1;
            lblCompany.Text = "Petrol Pump";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Emoji", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(3, 3);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(210, 85);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "LOGO";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(lblTime);
            pnlContent.Controls.Add(lblDate);
            pnlContent.Controls.Add(pnlHome);
            pnlContent.Controls.Add(pnlStockAlert);
            pnlContent.Controls.Add(pnlTodaySales);
            pnlContent.Controls.Add(pnlDiesel);
            pnlContent.Controls.Add(pnlPetrol);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.ForeColor = Color.Green;
            pnlContent.Location = new Point(220, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1076, 651);
            pnlContent.TabIndex = 2;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(565, 23);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(124, 28);
            lblTime.TabIndex = 6;
            lblTime.Text = "Current Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(42, 23);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(123, 28);
            lblDate.TabIndex = 5;
            lblDate.Text = "Current Date\n";
            // 
            // pnlHome
            // 
            pnlHome.BackColor = Color.White;
            pnlHome.Controls.Add(label12);
            pnlHome.Controls.Add(label11);
            pnlHome.Location = new Point(57, 207);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(950, 420);
            pnlHome.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(47, 108);
            label12.Name = "label12";
            label12.Size = new Size(221, 192);
            label12.TabIndex = 1;
            label12.Text = "Manage Fuel Prices\r\nDaily Dip Entries\r\nStock\r\nReports\r\nTransactions\r\nUsers";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(27, 36);
            label11.Name = "label11";
            label11.Size = new Size(904, 54);
            label11.TabIndex = 0;
            label11.Text = "Welcome to Petrol Pump Management System";
            // 
            // pnlStockAlert
            // 
            pnlStockAlert.BackColor = Color.White;
            pnlStockAlert.BorderStyle = BorderStyle.FixedSingle;
            pnlStockAlert.Controls.Add(label5);
            pnlStockAlert.Controls.Add(lblStockAlert);
            pnlStockAlert.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlStockAlert.Location = new Point(823, 71);
            pnlStockAlert.Name = "pnlStockAlert";
            pnlStockAlert.Size = new Size(220, 120);
            pnlStockAlert.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 45);
            label5.Name = "label5";
            label5.Size = new Size(215, 54);
            label5.TabIndex = 1;
            label5.Text = "Rs. 270.50";
            // 
            // lblStockAlert
            // 
            lblStockAlert.AutoSize = true;
            lblStockAlert.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockAlert.ForeColor = Color.Black;
            lblStockAlert.Location = new Point(13, 15);
            lblStockAlert.Name = "lblStockAlert";
            lblStockAlert.Size = new Size(127, 30);
            lblStockAlert.TabIndex = 0;
            lblStockAlert.Text = "Stock Alert";
            // 
            // pnlTodaySales
            // 
            pnlTodaySales.BackColor = Color.White;
            pnlTodaySales.BorderStyle = BorderStyle.FixedSingle;
            pnlTodaySales.Controls.Add(label7);
            pnlTodaySales.Controls.Add(lblTodaySales);
            pnlTodaySales.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlTodaySales.Location = new Point(565, 71);
            pnlTodaySales.Name = "pnlTodaySales";
            pnlTodaySales.Size = new Size(220, 120);
            pnlTodaySales.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(4, 45);
            label7.Name = "label7";
            label7.Size = new Size(215, 54);
            label7.TabIndex = 1;
            label7.Text = "Rs. 270.50";
            // 
            // lblTodaySales
            // 
            lblTodaySales.AutoSize = true;
            lblTodaySales.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaySales.ForeColor = Color.Black;
            lblTodaySales.Location = new Point(13, 15);
            lblTodaySales.Name = "lblTodaySales";
            lblTodaySales.Size = new Size(148, 30);
            lblTodaySales.TabIndex = 0;
            lblTodaySales.Text = "Today's Sales";
            // 
            // pnlDiesel
            // 
            pnlDiesel.BackColor = Color.White;
            pnlDiesel.BorderStyle = BorderStyle.FixedSingle;
            pnlDiesel.Controls.Add(label9);
            pnlDiesel.Controls.Add(lblDieselPrice);
            pnlDiesel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlDiesel.Location = new Point(303, 71);
            pnlDiesel.Name = "pnlDiesel";
            pnlDiesel.Size = new Size(220, 120);
            pnlDiesel.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(4, 45);
            label9.Name = "label9";
            label9.Size = new Size(215, 54);
            label9.TabIndex = 1;
            label9.Text = "Rs. 270.50";
            // 
            // lblDieselPrice
            // 
            lblDieselPrice.AutoSize = true;
            lblDieselPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDieselPrice.ForeColor = Color.Black;
            lblDieselPrice.Location = new Point(13, 15);
            lblDieselPrice.Name = "lblDieselPrice";
            lblDieselPrice.Size = new Size(133, 30);
            lblDieselPrice.TabIndex = 0;
            lblDieselPrice.Text = "Diesel Price";
            // 
            // pnlPetrol
            // 
            pnlPetrol.BackColor = Color.White;
            pnlPetrol.BorderStyle = BorderStyle.FixedSingle;
            pnlPetrol.Controls.Add(label4);
            pnlPetrol.Controls.Add(lblPetrolPrice);
            pnlPetrol.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlPetrol.Location = new Point(42, 71);
            pnlPetrol.Name = "pnlPetrol";
            pnlPetrol.Size = new Size(220, 120);
            pnlPetrol.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 45);
            label4.Name = "label4";
            label4.Size = new Size(215, 54);
            label4.TabIndex = 1;
            label4.Text = "Rs. 270.50";
            label4.Click += label4_Click;
            // 
            // lblPetrolPrice
            // 
            lblPetrolPrice.AutoSize = true;
            lblPetrolPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPetrolPrice.ForeColor = Color.Black;
            lblPetrolPrice.Location = new Point(13, 15);
            lblPetrolPrice.Name = "lblPetrolPrice";
            lblPetrolPrice.Size = new Size(133, 30);
            lblPetrolPrice.TabIndex = 0;
            lblPetrolPrice.Text = "Petrol Price";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(220, 699);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1076, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "Ready";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1296, 721);
            Controls.Add(statusStrip1);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            pnlStockAlert.ResumeLayout(false);
            pnlStockAlert.PerformLayout();
            pnlTodaySales.ResumeLayout(false);
            pnlTodaySales.PerformLayout();
            pnlDiesel.ResumeLayout(false);
            pnlDiesel.PerformLayout();
            pnlPetrol.ResumeLayout(false);
            pnlPetrol.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlSidebar;
        private Label lblWelcome;
        private Label lblTitle;
        private Panel pnlContent;
        private Button btnLogout;
        private Label lblLogo;
        private Button btnDashboard;
        private Label lblCompany;
        private Button btnReports;
        private Button btnSales;
        private Button btnStock;
        private Button btnDipEntry;
        private Button btnFuelPrice;
        private Button btnUsers;
        private Button btnSettings;
        private Button btnLogoutLeft;
        private Panel pnlPetrol;
        private Label label4;
        private Label lblPetrolPrice;
        private Panel pnlHome;
        private Panel pnlStockAlert;
        private Label label5;
        private Label lblStockAlert;
        private Panel pnlTodaySales;
        private Label label7;
        private Label lblTodaySales;
        private Panel pnlDiesel;
        private Label label9;
        private Label lblDieselPrice;
        private Label label12;
        private Label label11;
        private Label lblTime;
        private Label lblDate;
        private StatusStrip statusStrip1;
        private Button btnTransactions;
    }
}