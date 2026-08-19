using PetrolPumpManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;


namespace PetrolPumpManagementSystem.Forms
{
    public partial class DashboardHomeForm : Form
    {
        public DashboardHomeForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Load image from file  
            pictureBoxLogo.Image = Image.FromFile(@"C:\Users\PMY\Downloads\Capture.PNG");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadForm(Form childForm)
        {
            pnlContent.Controls.Clear();

            childForm.TopLevel = false;

            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);

            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
            LoadForm(new DashboardHomeForm());
        }

        private void btnFuelPrice_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnFuelPrice);
            LoadForm(new FuelPriceForm());
        }

        private void btnDipEntry_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDipEntry);
            LoadForm(new DipEntryForm());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnStock);
            LoadForm(new StockForm());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSales);
            LoadForm(new SalesForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReports);
            LoadForm(new ReportsForm());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnTransactions);
            LoadForm(new TransactionsForm());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnUsers);
            LoadForm(new UsersForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSettings);
            LoadForm(new SettingsForm());
        }



        private void btnLogoutLeft_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnLogoutLeft);
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();

                login.Show();

                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();

                login.Show();

                this.Close();
            }
        }

        private void ResetButtonColors()
        {
            foreach (Control control in pnlSidebar.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.MidnightBlue;
                    btn.ForeColor = Color.White;
                }
            }
        }

        private void SetActiveButton(Button button)
        {
            ResetButtonColors();

            button.BackColor = Color.RoyalBlue;
            button.ForeColor = Color.White;
        }

        private void DrawLogo()
        {
            // Create a bitmap
            Bitmap bmp = new Bitmap(pictureBoxLogo.Width, pictureBoxLogo.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.White);

                // === Draw Fuel Pump Icon ===
                Pen mainPen = new Pen(Color.FromArgb(44, 62, 80), 3); // Dark blue
                Pen accentPen = new Pen(Color.FromArgb(231, 76, 60), 3); // Red

                // Main body of pump
                Rectangle pumpBody = new Rectangle(15, 15, 45, 55);
                g.DrawRectangle(mainPen, pumpBody);
                g.FillRectangle(new SolidBrush(Color.FromArgb(236, 240, 241)), pumpBody);

                // Fuel gauge window
                g.FillRectangle(new SolidBrush(Color.FromArgb(52, 152, 219)), 22, 22, 10, 20);
                g.DrawRectangle(mainPen, 22, 22, 10, 20);

                // Horizontal line (fuel level marker)
                g.DrawLine(accentPen, 15, 40, 60, 40);

                // Nozzle
                g.DrawLine(accentPen, 60, 30, 80, 20);
                g.DrawEllipse(accentPen, 75, 15, 15, 10);
                g.FillEllipse(new SolidBrush(Color.FromArgb(231, 76, 60)), 78, 18, 9, 4);

                // Fuel drops
                SolidBrush dropBrush = new SolidBrush(Color.FromArgb(52, 152, 219));
                g.FillEllipse(dropBrush, 85, 30, 4, 6);
                g.FillEllipse(dropBrush, 90, 35, 3, 5);

                // === Draw Text ===
                // "PETROL" - Dark Blue
                Font titleFont1 = new Font("Arial", 20, FontStyle.Bold);
                g.DrawString("PETROL", titleFont1, new SolidBrush(Color.FromArgb(44, 62, 80)), 100, 15);

                // "PUMP" - Red
                Font titleFont2 = new Font("Arial", 20, FontStyle.Bold);
                g.DrawString("PUMP", titleFont2, new SolidBrush(Color.FromArgb(231, 76, 60)), 100, 38);

                // "Management System" - Gray
                Font subFont = new Font("Arial", 9, FontStyle.Regular);
                g.DrawString("Management System", subFont, new SolidBrush(Color.FromArgb(127, 140, 141)), 100, 62);
            }
            pictureBoxLogo.Image = bmp;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnFuelReciepts_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnFuelReciepts);
            LoadForm(new FuelReceiptForm());
        }
    }
}
