using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PetrolPumpManagementSystem.Models;
using PetrolPumpManagementSystem.Services;

namespace PetrolPumpManagementSystem.Forms
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierService supplierService;
        private int selectedSupplierID = 0;

        public SupplierForm()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            LoadSuppliers();
            ClearForm();
        }

        private void LoadSuppliers()
        {
            try
            {
                DataTable dt = supplierService.GetAllSuppliers();
                dgvSuppliers.DataSource = dt;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvSuppliers.Columns.Count == 0) return;

            // Hide ID column
            if (dgvSuppliers.Columns.Contains("SupplierID"))
                dgvSuppliers.Columns["SupplierID"].Visible = false;

            // Format headers
            if (dgvSuppliers.Columns.Contains("SupplierName"))
            {
                dgvSuppliers.Columns["SupplierName"].HeaderText = "Supplier Name";
                dgvSuppliers.Columns["SupplierName"].Width = 200;
            }

            if (dgvSuppliers.Columns.Contains("ContactPerson"))
            {
                dgvSuppliers.Columns["ContactPerson"].HeaderText = "Contact Person";
                dgvSuppliers.Columns["ContactPerson"].Width = 150;
            }

            if (dgvSuppliers.Columns.Contains("PhoneNumber"))
            {
                dgvSuppliers.Columns["PhoneNumber"].HeaderText = "Phone";
                dgvSuppliers.Columns["PhoneNumber"].Width = 150;
            }

            if (dgvSuppliers.Columns.Contains("Email"))
            {
                dgvSuppliers.Columns["Email"].HeaderText = "Email";
                dgvSuppliers.Columns["Email"].Width = 200;
            }

            if (dgvSuppliers.Columns.Contains("Address"))
            {
                dgvSuppliers.Columns["Address"].HeaderText = "Address";
                dgvSuppliers.Columns["Address"].Width = 250;
            }

            // Style the grid
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = Color.White;
            dgvSuppliers.BorderStyle = BorderStyle.None;
            dgvSuppliers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSuppliers.ColumnHeadersHeight = 40;
            dgvSuppliers.EnableHeadersVisualStyles = false;
            dgvSuppliers.RowHeadersVisible = false;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.MultiSelect = false;

            dgvSuppliers.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSuppliers.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvSuppliers.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvSuppliers.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dgvSuppliers.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
        }

        private void ClearForm()
        {
            txtSupplierName.Clear();
            txtContactPerson.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            selectedSupplierID = 0;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtSupplierName.Focus();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter the supplier name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierName.Focus();
                return false;
            }

            // Check for duplicate supplier name
            if (selectedSupplierID == 0)
            {
                if (supplierService.SupplierExists(txtSupplierName.Text.Trim()))
                {
                    MessageBox.Show("A supplier with this name already exists.", "Duplicate",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierName.Focus();
                    return false;
                }
            }
            else
            {
                if (supplierService.SupplierExistsForUpdate(selectedSupplierID, txtSupplierName.Text.Trim()))
                {
                    MessageBox.Show("A supplier with this name already exists.", "Duplicate",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierName.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                Supplier supplier = new Supplier
                {
                    SupplierName = txtSupplierName.Text.Trim(),
                    ContactPerson = txtContactPerson.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                bool saved = supplierService.SaveSupplier(supplier);

                if (saved)
                {
                    MessageBox.Show("✅ Supplier saved successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSuppliers();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving supplier:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSupplierID == 0)
            {
                MessageBox.Show("Please select a supplier first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                Supplier supplier = new Supplier
                {
                    SupplierID = selectedSupplierID,
                    SupplierName = txtSupplierName.Text.Trim(),
                    ContactPerson = txtContactPerson.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                bool updated = supplierService.UpdateSupplier(supplier);

                if (updated)
                {
                    MessageBox.Show("✅ Supplier updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSuppliers();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating supplier:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplierID == 0)
            {
                MessageBox.Show("Please select a supplier first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this supplier?\n\n" +
                "Note: Suppliers with existing fuel receipts cannot be deleted.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool deleted = supplierService.DeleteSupplier(selectedSupplierID);

                    if (deleted)
                    {
                        MessageBox.Show("✅ Supplier deleted successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadSuppliers();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting supplier:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadSuppliers();
                    return;
                }

                DataTable dt = supplierService.SearchSuppliers(searchText);
                dgvSuppliers.DataSource = dt;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching suppliers:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvSuppliers.Rows[e.RowIndex];
                selectedSupplierID = Convert.ToInt32(row.Cells["SupplierID"].Value);

                txtSupplierName.Text = row.Cells["SupplierName"].Value?.ToString() ?? "";
                txtContactPerson.Text = row.Cells["ContactPerson"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
