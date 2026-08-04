using Microsoft.Data.SqlClient;
using PetrolPumpManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetrolPumpManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection db = new DatabaseConnection();

                SqlConnection con = db.GetConnection();

                con.Open();

                MessageBox.Show("Database Connected Successfully");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();

            SqlConnection con = db.GetConnection();

            con.Open();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Enter Username");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter Password");
                txtPassword.Focus();
                return;
            }

            string query = @"SELECT *
                     FROM Users
                     WHERE Username=@username
                     AND PasswordHash=@password";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@username", txtUsername.Text);

            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                DashboardHomeForm dashboard = new DashboardHomeForm();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
