using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PetrolPumpManagementSystem.Services;
using System.Text;
using System.Linq;
using PetrolPumpManagementSystem.Models;

namespace PetrolPumpManagementSystem.Forms
{
    public partial class StockForm : Form
    {
        private readonly StockService stockService;
        private readonly FuelService fuelService;
        private readonly DipEntryService dipEntryService;
        private int selectedFuelTypeID = 0;

        public StockForm()
        {
            InitializeComponent();
            stockService = new StockService();
            fuelService = new FuelService();
            dipEntryService = new DipEntryService();

            LoadFuelTypes();
            LoadStockGrid();
            ClearForm();
        }

        private void LoadFuelTypes()
        {
            try
            {
                DataTable dt = dipEntryService.GetFuelTypes();
                cmbFuel.DataSource = dt;
                cmbFuel.DisplayMember = "FuelName";
                cmbFuel.ValueMember = "FuelTypeID";
                cmbFuel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading fuel types:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStockGrid()
        {
            try
            {
                DataTable dt = stockService.GetAllStock();
                dgvStock.DataSource = dt;
                FormatGrid();
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock data:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvStock.Columns.Count == 0) return;

            if (dgvStock.Columns.Contains("StockID"))
                dgvStock.Columns["StockID"].Visible = false;
            if (dgvStock.Columns.Contains("FuelTypeID"))
                dgvStock.Columns["FuelTypeID"].Visible = false;

            if (dgvStock.Columns.Contains("FuelName"))
            {
                dgvStock.Columns["FuelName"].HeaderText = "Fuel Type";
                dgvStock.Columns["FuelName"].Width = 150;
            }

            if (dgvStock.Columns.Contains("CurrentStock"))
            {
                dgvStock.Columns["CurrentStock"].HeaderText = "Current Stock (L)";
                dgvStock.Columns["CurrentStock"].Width = 150;
                dgvStock.Columns["CurrentStock"].DefaultCellStyle.Format = "N2";
                dgvStock.Columns["CurrentStock"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvStock.Columns.Contains("LastUpdated"))
            {
                dgvStock.Columns["LastUpdated"].HeaderText = "Last Updated";
                dgvStock.Columns["LastUpdated"].Width = 180;
                dgvStock.Columns["LastUpdated"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";
            }

            if (dgvStock.Columns.Contains("TankCapacity"))
            {
                dgvStock.Columns["TankCapacity"].HeaderText = "Capacity (L)";
                dgvStock.Columns["TankCapacity"].Width = 120;
                dgvStock.Columns["TankCapacity"].DefaultCellStyle.Format = "N0";
                dgvStock.Columns["TankCapacity"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = Color.White;
            dgvStock.BorderStyle = BorderStyle.None;
            dgvStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStock.ColumnHeadersHeight = 40;
            dgvStock.EnableHeadersVisualStyles = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.ReadOnly = true;
            dgvStock.MultiSelect = false;

            dgvStock.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStock.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvStock.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvStock.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dgvStock.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvStock.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);

            AddStatusColumn();
        }

        private void AddStatusColumn()
        {
            if (dgvStock.Columns.Contains("StockStatus"))
                dgvStock.Columns.Remove("StockStatus");

            DataGridViewTextBoxColumn statusCol = new DataGridViewTextBoxColumn
            {
                Name = "StockStatus",
                HeaderText = "Status",
                Width = 150,
                ReadOnly = true
            };
            dgvStock.Columns.Add(statusCol);

            // FIXED: Check if columns exist first
            if (dgvStock.Columns.Contains("CurrentStock") && dgvStock.Columns.Contains("TankCapacity"))
            {
                foreach (DataGridViewRow row in dgvStock.Rows)
                {
                    if (row.IsNewRow) continue;

                    // FIXED: Check for null values
                    if (row.Cells["CurrentStock"].Value != null && row.Cells["TankCapacity"].Value != null)
                    {
                        decimal currentStock = Convert.ToDecimal(row.Cells["CurrentStock"].Value);
                        decimal tankCapacity = Convert.ToDecimal(row.Cells["TankCapacity"].Value);

                        string status;
                        Color color;

                        if (currentStock <= 0)
                        {
                            status = "⚠️ Empty";
                            color = Color.Red;
                        }
                        else if (currentStock <= 1000)
                        {
                            status = "⚠️ Critical - Order Now!";
                            color = Color.Red;
                        }
                        else if (currentStock <= 3000)
                        {
                            status = "⚠️ Low";
                            color = Color.Orange;
                        }
                        else if (currentStock <= 7000)
                        {
                            status = "● Medium";
                            color = Color.Blue;
                        }
                        else
                        {
                            status = "✓ High";
                            color = Color.Green;
                        }

                        row.Cells["StockStatus"].Value = status;
                        row.Cells["StockStatus"].Style.ForeColor = color;
                        row.Cells["StockStatus"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                }
            }
        }

        private void UpdateSummary()
        {
            try
            {
                DataTable dt = dgvStock.DataSource as DataTable;

                if (dt == null || dt.Rows.Count == 0)
                {
                    lblTotalStockSummary.Text = "Total Stock: 0 L";
                    lblFuelTypes.Text = "Fuel Types: 0";
                    lblLowStock.Text = "⚠️ Low Stock Items: 0";
                    return;
                }

                decimal totalStock = 0;
                int lowStockCount = 0;

                foreach (DataRow row in dt.Rows)
                {
                    decimal currentStock = Convert.ToDecimal(row["CurrentStock"]);
                    totalStock += currentStock;

                    if (currentStock <= 3000)
                        lowStockCount++;
                }

                lblTotalStockSummary.Text = $"Total Stock: {totalStock:N0} L";
                lblFuelTypes.Text = $"Fuel Types: {dt.Rows.Count}";
                lblLowStock.Text = $"⚠️ Low Stock Items: {lowStockCount}";
                lblLowStock.ForeColor = lowStockCount > 0 ? Color.Red : Color.Green;
            }
            catch
            {
                // Silent fail
            }
        }

        private void ClearForm()
        {
            cmbFuel.SelectedIndex = -1;
            txtOpeningStock.Clear();
            txtReceivedStock.Clear();
            txtTotalStock.Clear();
            txtTodaySales.Clear();
            txtClosingStock.Clear();
            txtPhysicalDip.Clear();
            txtDifference.Clear();

            txtOpeningStock.ReadOnly = false;
            txtOpeningStock.BackColor = Color.White;

            txtReceivedStock.ReadOnly = true;
            txtReceivedStock.BackColor = Color.FromArgb(240, 240, 240);

            txtTotalStock.ReadOnly = true;
            txtTotalStock.BackColor = Color.FromArgb(240, 240, 240);

            txtTodaySales.ReadOnly = true;
            txtTodaySales.BackColor = Color.FromArgb(240, 240, 240);

            txtClosingStock.ReadOnly = true;
            txtClosingStock.BackColor = Color.FromArgb(240, 240, 240);

            txtPhysicalDip.ReadOnly = true;
            txtPhysicalDip.BackColor = Color.FromArgb(240, 240, 240);

            txtDifference.ReadOnly = true;
            txtDifference.BackColor = Color.FromArgb(240, 240, 240);

            selectedFuelTypeID = 0;
        }

        private void LoadStockDataForFuel()
        {
            try
            {
                if (cmbFuel.SelectedIndex == -1)
                {
                    ClearForm();
                    return;
                }

                int fuelTypeID = Convert.ToInt32(cmbFuel.SelectedValue);
                selectedFuelTypeID = fuelTypeID;
                DateTime today = DateTime.Today;

                decimal openingStock = stockService.GetOpeningStock(fuelTypeID);
                txtOpeningStock.Text = openingStock.ToString("N2");

                decimal receivedStock = dipEntryService.GetReceivedStock(fuelTypeID, today);
                txtReceivedStock.Text = receivedStock.ToString("N2");

                decimal totalStock = openingStock + receivedStock;
                txtTotalStock.Text = totalStock.ToString("N2");

                decimal todaySales = dipEntryService.GetDailySales(fuelTypeID, today);
                txtTodaySales.Text = todaySales.ToString("N2");

                decimal closingStock = totalStock - todaySales;
                txtClosingStock.Text = closingStock.ToString("N2");

                if (dipEntryService.HasDipEntryForDate(fuelTypeID, today))
                {
                    decimal physicalDip = dipEntryService.GetPhysicalDipStock(fuelTypeID, today);
                    txtPhysicalDip.Text = physicalDip.ToString("N2");

                    decimal difference = closingStock - physicalDip;
                    txtDifference.Text = difference.ToString("N2");

                    if (Math.Abs(difference) > 100)
                    {
                        if (difference > 0)
                        {
                            txtDifference.ForeColor = Color.Green;
                            txtDifference.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            txtDifference.ForeColor = Color.Red;
                            txtDifference.BackColor = Color.LightPink;
                        }
                    }
                    else if (difference != 0)
                    {
                        txtDifference.ForeColor = Color.Orange;
                        txtDifference.BackColor = Color.LightYellow;
                    }
                    else
                    {
                        txtDifference.ForeColor = Color.Black;
                        txtDifference.BackColor = Color.LightGreen;
                    }
                }
                else
                {
                    txtPhysicalDip.Clear();
                    txtDifference.Clear();
                    txtDifference.BackColor = Color.White;
                    txtDifference.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock data:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotals()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOpeningStock.Text) ||
                    string.IsNullOrWhiteSpace(txtReceivedStock.Text))
                {
                    txtTotalStock.Clear();
                    return;
                }

                decimal opening = decimal.Parse(txtOpeningStock.Text);
                decimal received = decimal.Parse(txtReceivedStock.Text);
                decimal total = opening + received;
                txtTotalStock.Text = total.ToString("N2");

                if (!string.IsNullOrWhiteSpace(txtTodaySales.Text))
                {
                    decimal sales = decimal.Parse(txtTodaySales.Text);
                    decimal closing = total - sales;
                    txtClosingStock.Text = closing.ToString("N2");
                }
            }
            catch
            {
                // Silent fail
            }
        }

        // FIXED: Added btnCalculate_Click method
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            LoadStockDataForFuel();
        }

        private void btnSaveOpening_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFuel.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a fuel type.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtOpeningStock.Text))
                {
                    MessageBox.Show("Please enter the opening stock value.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOpeningStock.Focus();
                    return;
                }

                if (!decimal.TryParse(txtOpeningStock.Text, out decimal openingStock))
                {
                    MessageBox.Show("Please enter a valid opening stock value.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOpeningStock.Focus();
                    return;
                }

                if (openingStock < 0)
                {
                    MessageBox.Show("Opening stock cannot be negative.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOpeningStock.Focus();
                    return;
                }

                int fuelTypeID = Convert.ToInt32(cmbFuel.SelectedValue);
                string fuelName = cmbFuel.Text;

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to set the opening stock for {fuelName}?\n\n" +
                    $"Opening Stock: {openingStock:N2} L",
                    "Confirm Opening Stock",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool updated = stockService.UpdateStock(fuelTypeID, openingStock);
                    if (updated)
                    {
                        MessageBox.Show($"✅ Opening stock set successfully!\n\n{fuelName}: {openingStock:N2} L",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadStockGrid();
                        LoadStockDataForFuel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving opening stock:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStockGrid();
            if (cmbFuel.SelectedIndex != -1)
                LoadStockDataForFuel();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void cmbFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStockDataForFuel();
        }

        private void txtOpeningStock_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvStock.Rows[e.RowIndex];
                int fuelTypeID = Convert.ToInt32(row.Cells["FuelTypeID"].Value);

                foreach (DataRowView item in cmbFuel.Items)
                {
                    if (Convert.ToInt32(item["FuelTypeID"]) == fuelTypeID)
                    {
                        cmbFuel.SelectedItem = item;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting fuel:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}