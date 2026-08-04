using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PetrolPumpManagementSystem.Forms;

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
    }
}
