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
    public partial class FuelReceiptForm : Form
    {
        private readonly FuelReceiptService receiptService;
        private readonly StockService stockService;
        private int selectedReceiptID = 0;

        public FuelReceiptForm()
        {
            InitializeComponent();
            receiptService = new FuelReceiptService();
            stockService = new StockService();

            LoadSuppliers();
            LoadFuelTypes();
            LoadReceipts();
            ClearForm();
        }

        private void LoadSuppliers()
        {
            try
            {
                DataTable dt = receiptService.GetSuppliers();
                cmbSupplier.DataSource = dt;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "SupplierID";
                cmbSupplier.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFuelTypes()
        {
            try
            {
                DataTable dt = receiptService.GetFuelTypes();
                cmbFuelType.DataSource = dt;
                cmbFuelType.DisplayMember = "FuelName";
                cmbFuelType.ValueMember = "FuelTypeID";
                cmbFuelType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading fuel types:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReceipts()
        {
            try
            {
                DataTable dt = receiptService.GetAllFuelReceipts();
                dgvReceipts.DataSource = dt;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading receipts:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvReceipts.Columns.Count == 0) return;

            // Hide ID columns
            if (dgvReceipts.Columns.Contains("ReceiptID"))
                dgvReceipts.Columns["ReceiptID"].Visible = false;
            if (dgvReceipts.Columns.Contains("SupplierID"))
                dgvReceipts.Columns["SupplierID"].Visible = false;
            if (dgvReceipts.Columns.Contains("FuelTypeID"))
                dgvReceipts.Columns["FuelTypeID"].Visible = false;

            // Format headers
            if (dgvReceipts.Columns.Contains("SupplierName"))
                dgvReceipts.Columns["SupplierName"].HeaderText = "Supplier";

            if (dgvReceipts.Columns.Contains("FuelName"))
                dgvReceipts.Columns["FuelName"].HeaderText = "Fuel Type";

            if (dgvReceipts.Columns.Contains("Quantity"))
            {
                dgvReceipts.Columns["Quantity"].HeaderText = "Quantity (L)";
                dgvReceipts.Columns["Quantity"].DefaultCellStyle.Format = "N2";
                dgvReceipts.Columns["Quantity"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvReceipts.Columns.Contains("PurchasePrice"))
            {
                dgvReceipts.Columns["PurchasePrice"].HeaderText = "Price (Rs/L)";
                dgvReceipts.Columns["PurchasePrice"].DefaultCellStyle.Format = "N2";
                dgvReceipts.Columns["PurchasePrice"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvReceipts.Columns.Contains("TotalAmount"))
            {
                dgvReceipts.Columns["TotalAmount"].HeaderText = "Total Amount (Rs)";
                dgvReceipts.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";
                dgvReceipts.Columns["TotalAmount"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvReceipts.Columns.Contains("ReceiptDate"))
            {
                dgvReceipts.Columns["ReceiptDate"].HeaderText = "Date";
                dgvReceipts.Columns["ReceiptDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }

            // Style the grid
            dgvReceipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReceipts.BackgroundColor = Color.White;
            dgvReceipts.BorderStyle = BorderStyle.None;
            dgvReceipts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReceipts.ColumnHeadersHeight = 40;
            dgvReceipts.EnableHeadersVisualStyles = false;
            dgvReceipts.RowHeadersVisible = false;
            dgvReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceipts.AllowUserToAddRows = false;
            dgvReceipts.AllowUserToDeleteRows = false;
            dgvReceipts.ReadOnly = true;
            dgvReceipts.MultiSelect = false;

            dgvReceipts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvReceipts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvReceipts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReceipts.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvReceipts.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvReceipts.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dgvReceipts.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvReceipts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
        }

        private void ClearForm()
        {
            cmbSupplier.SelectedIndex = -1;
            cmbFuelType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPurchasePrice.Clear();
            txtTotalAmount.Clear();
            dtpReceiptDate.Value = DateTime.Today;

            selectedReceiptID = 0;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtQuantity.Focus();
        }

        private void CalculateTotal()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                    string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
                {
                    txtTotalAmount.Clear();
                    return;
                }

                decimal quantity = decimal.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPurchasePrice.Text);
                decimal total = quantity * price;
                txtTotalAmount.Text = total.ToString("N2");
            }
            catch
            {
                txtTotalAmount.Clear();
            }
        }

        private bool ValidateInputs()
        {
            if (cmbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSupplier.Focus();
                return false;
            }

            if (cmbFuelType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a fuel type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFuelType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter the quantity.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (!decimal.TryParse(txtQuantity.Text, out decimal quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
            {
                MessageBox.Show("Please enter the purchase price.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPurchasePrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPurchasePrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid purchase price.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPurchasePrice.Focus();
                return false;
            }

            if (price <= 0)
            {
                MessageBox.Show("Purchase price must be greater than zero.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPurchasePrice.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                FuelReceipt receipt = new FuelReceipt
                {
                    SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue),
                    FuelTypeID = Convert.ToInt32(cmbFuelType.SelectedValue),
                    Quantity = decimal.Parse(txtQuantity.Text),
                    PurchasePrice = decimal.Parse(txtPurchasePrice.Text),
                    ReceiptDate = dtpReceiptDate.Value.Date
                };

                bool saved = receiptService.SaveFuelReceipt(receipt);

                if (saved)
                {
                    // Update stock - add received fuel to current stock
                    int fuelTypeID = receipt.FuelTypeID;
                    decimal currentStock = stockService.GetOpeningStock(fuelTypeID);
                    decimal newStock = currentStock + receipt.Quantity;
                    stockService.UpdateStock(fuelTypeID, newStock);

                    MessageBox.Show("✅ Fuel receipt saved and stock updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReceipts();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving receipt:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedReceiptID == 0)
            {
                MessageBox.Show("Please select a receipt first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                FuelReceipt receipt = new FuelReceipt
                {
                    ReceiptID = selectedReceiptID,
                    SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue),
                    FuelTypeID = Convert.ToInt32(cmbFuelType.SelectedValue),
                    Quantity = decimal.Parse(txtQuantity.Text),
                    PurchasePrice = decimal.Parse(txtPurchasePrice.Text),
                    ReceiptDate = dtpReceiptDate.Value.Date
                };

                bool updated = receiptService.UpdateFuelReceipt(receipt);

                if (updated)
                {
                    MessageBox.Show("✅ Fuel receipt updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReceipts();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating receipt:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedReceiptID == 0)
            {
                MessageBox.Show("Please select a receipt first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this fuel receipt?\n" +
                "This will also revert the stock update.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Get the receipt to know how much stock to revert
                    FuelReceipt receipt = receiptService.GetFuelReceiptByID(selectedReceiptID);

                    if (receipt != null)
                    {
                        // Revert stock
                        decimal currentStock = stockService.GetOpeningStock(receipt.FuelTypeID);
                        decimal newStock = currentStock - receipt.Quantity;
                        stockService.UpdateStock(receipt.FuelTypeID, newStock);
                    }

                    bool deleted = receiptService.DeleteFuelReceipt(selectedReceiptID);

                    if (deleted)
                    {
                        MessageBox.Show("✅ Fuel receipt deleted and stock reverted!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadReceipts();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting receipt:\n{ex.Message}", "Error",
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
            LoadReceipts();
            ClearForm();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadReceipts();
                    return;
                }

                DataTable dt = receiptService.SearchFuelReceipts(searchText);
                dgvReceipts.DataSource = dt;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching receipts:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReceipts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvReceipts.Rows[e.RowIndex];
                selectedReceiptID = Convert.ToInt32(row.Cells["ReceiptID"].Value);

                // Set supplier
                foreach (DataRowView item in cmbSupplier.Items)
                {
                    if (Convert.ToInt32(item["SupplierID"]) == Convert.ToInt32(row.Cells["SupplierID"].Value))
                    {
                        cmbSupplier.SelectedItem = item;
                        break;
                    }
                }

                // Set fuel type
                foreach (DataRowView item in cmbFuelType.Items)
                {
                    if (Convert.ToInt32(item["FuelTypeID"]) == Convert.ToInt32(row.Cells["FuelTypeID"].Value))
                    {
                        cmbFuelType.SelectedItem = item;
                        break;
                    }
                }

                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtPurchasePrice.Text = row.Cells["PurchasePrice"].Value.ToString();
                txtTotalAmount.Text = row.Cells["TotalAmount"].Value.ToString();
                dtpReceiptDate.Value = Convert.ToDateTime(row.Cells["ReceiptDate"].Value);

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading receipt:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
