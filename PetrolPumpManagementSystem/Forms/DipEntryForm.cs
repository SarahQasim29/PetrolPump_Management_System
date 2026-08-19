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
    public partial class DipEntryForm : Form
    {
        private readonly DipEntryService dipEntryService;
        private int selectedDipID = 0;
        public DipEntryForm()
        {
            InitializeComponent();

            dipEntryService = new DipEntryService();

            dtpEntryDate.Value = DateTime.Today;

            LoadFuelTypes();
            LoadDipEntries();
        }

        private void LoadFuelTypes()
        {
            try
            {
                DataTable dt = dipEntryService.GetFuelTypes();

                cmbFuelType.DataSource = dt;
                cmbFuelType.DisplayMember = "FuelName";
                cmbFuelType.ValueMember = "FuelTypeID";

                cmbFuelType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading fuel types:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormatDipGrid()
        {
            if (dgvDipEntries.Columns.Count == 0)
                return;

            if (dgvDipEntries.Columns.Contains("DipID"))
                dgvDipEntries.Columns["DipID"]!.Visible = false;

            if (dgvDipEntries.Columns.Contains("FuelTypeID"))
                dgvDipEntries.Columns["FuelTypeID"]!.Visible = false;

            if (dgvDipEntries.Columns.Contains("FuelName"))
                dgvDipEntries.Columns["FuelName"]!.HeaderText = "Fuel Type";

            if (dgvDipEntries.Columns.Contains("BeforeReading"))
                dgvDipEntries.Columns["BeforeReading"]!.HeaderText = "BEFORE Reading (L)";

            if (dgvDipEntries.Columns.Contains("AfterReading"))
                dgvDipEntries.Columns["AfterReading"]!.HeaderText = "AFTER Reading (L)";

            if (dgvDipEntries.Columns.Contains("DailySales"))
                dgvDipEntries.Columns["DailySales"]!.HeaderText = "Daily Sales (L)";

            if (dgvDipEntries.Columns.Contains("PhysicalDipStock"))
                dgvDipEntries.Columns["PhysicalDipStock"]!.HeaderText = "Physical Dip (L)";

            if (dgvDipEntries.Columns.Contains("EntryDate"))
                dgvDipEntries.Columns["EntryDate"]!.HeaderText = "Date";
        }

        private void LoadDipEntries()
        {
            try
            {
                DataTable dt = dipEntryService.GetAllDipEntries();

                dgvDipEntries.DataSource = dt;

                FormatDipGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading dip records:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (cmbFuelType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a fuel type.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbFuelType.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtBeforeReading.Text.Trim(),
                out decimal beforeReading))
            {
                MessageBox.Show(
                    "Please enter a valid BEFORE reading.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBeforeReading.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtAfterReading.Text.Trim(),
                out decimal afterReading))
            {
                MessageBox.Show(
                    "Please enter a valid AFTER reading.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAfterReading.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtPhysicalDipStock.Text.Trim(),
                out decimal physicalDip))
            {
                MessageBox.Show(
                    "Please enter a valid physical dip stock.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhysicalDipStock.Focus();
                return false;
            }

            if (!dipEntryService.IsValidReading(
                beforeReading,
                afterReading,
                physicalDip))
            {
                MessageBox.Show(
                    "Invalid dip readings.\n\n" +
                    "Make sure all readings are zero or greater " +
                    "and AFTER reading is not less than BEFORE reading.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void CalculateAll()
        {
            if (cmbFuelType.SelectedIndex != -1)
            {
                // Calculate daily sales
                if (decimal.TryParse(txtBeforeReading.Text, out decimal before) &&
                    decimal.TryParse(txtAfterReading.Text, out decimal after))
                {
                    txtDailySales.Text = (after - before).ToString("N2");
                }

                // Calculate stock reconciliation
                CalculateStockReconciliation();
            }
        }


        private void DipEntryForm_Load(object sender, EventArgs e)
        {
            txtDipHeight.TextChanged += (s, ev) => {
                if (!string.IsNullOrWhiteSpace(txtDipHeight.Text))
                    btnCalculateDip.PerformClick();
            };

            cmbFuelType.SelectedIndexChanged += (s, ev) => {
                if (cmbFuelType.SelectedIndex != -1)
                    CalculateStockReconciliation();
            };

            txtBeforeReading.TextChanged += (s, ev) => CalculateAll();
            txtAfterReading.TextChanged += (s, ev) => CalculateAll();
            txtPhysicalDipStock.TextChanged += (s, ev) => CalculateAll();
            txtOpeningStock.TextChanged += (s, ev) => CalculateAll();
            txtRecievedStock.TextChanged += (s, ev) => CalculateAll();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                decimal beforeReading =
                    decimal.Parse(
                        txtBeforeReading.Text.Trim());

                decimal afterReading =
                    decimal.Parse(
                        txtAfterReading.Text.Trim());

                decimal physicalDip =
                    decimal.Parse(
                        txtPhysicalDipStock.Text.Trim());

                // --------------------------------
                // 1. DAILY SALES
                // --------------------------------

                decimal dailySales =
                    afterReading - beforeReading;

                txtDailySales.Text =
                    dailySales.ToString("N2");


                // --------------------------------
                // 2. FUEL PRICE
                // --------------------------------

                int fuelTypeID =
                    Convert.ToInt32(
                        cmbFuelType.SelectedValue);

                DateTime entryDate =
                    dtpEntryDate.Value.Date;

                decimal fuelPrice =
                    dipEntryService.GetCurrentFuelPrice(
                        fuelTypeID,
                        entryDate);

                txtFuelPrice.Text =
                    fuelPrice.ToString("N2");


                // --------------------------------
                // 3. EXPECTED CASH
                // --------------------------------

                decimal expectedCash =
                    dipEntryService.CalculateExpectedCash(
                        dailySales,
                        fuelPrice);

                txtCashExpected.Text =
                    expectedCash.ToString("N2");


                // --------------------------------
                // 4. STOCK RECONCILIATION
                // --------------------------------
                //
                // Opening Stock and Received Stock
                // will be loaded from Stock Management.
                //
                // Do NOT use hard-coded values here.
                //


                MessageBox.Show(
                    "Daily sales and expected cash calculated successfully.",
                    "Calculation Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error calculating dip reading:\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            cmbFuelType.SelectedIndex = -1;

            txtBeforeReading.Clear();
            txtAfterReading.Clear();
            txtPhysicalDipStock.Clear();

            txtDailySales.Clear();
            txtOpeningStock.Clear();
            txtRecievedStock.Clear();
            txtStockAfterSales.Clear();
            txtDifference.Clear();
            txtFuelPrice.Clear();
            txtCashExpected.Clear();

            dtpEntryDate.Value = DateTime.Today;

            selectedDipID = 0;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private int GetCurrentUserID()
        {
            return 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                int fuelTypeID = Convert.ToInt32(cmbFuelType.SelectedValue);
                int userID = GetCurrentUserID();

                decimal beforeReading = decimal.Parse(txtBeforeReading.Text.Trim());
                decimal afterReading = decimal.Parse(txtAfterReading.Text.Trim());
                decimal physicalDip = decimal.Parse(txtPhysicalDipStock.Text.Trim());

                DipEntry dip = new DipEntry
                {
                    FuelTypeID = fuelTypeID,
                    UserID = userID,
                    BeforeReading = beforeReading,
                    AfterReading = afterReading,
                    PhysicalDipStock = physicalDip,
                    EntryDate = dtpEntryDate.Value.Date
                };

                bool saved = dipEntryService.SaveDipEntry(dip);

                if (saved)
                {
                    // Update stock with the physical dip stock (reconciled value)
                    dipEntryService.UpdateStock(fuelTypeID, physicalDip);

                    MessageBox.Show("Dip reading saved and stock updated successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDipEntries();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving dip reading:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText =
                    txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadDipEntries();
                    return;
                }

                DataTable dt =
                    dipEntryService.SearchDipEntries(searchText);

                dgvDipEntries.DataSource = dt;

                FormatDipGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error searching records:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvDipEntries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row =
                    dgvDipEntries.Rows[e.RowIndex];

                selectedDipID =
                    Convert.ToInt32(
                        row.Cells["DipID"].Value);

                DipEntry dip =
                    dipEntryService.GetDipEntryByID(
                        selectedDipID);

                if (dip == null)
                    return;

                cmbFuelType.SelectedValue =
                    dip.FuelTypeID;

                dtpEntryDate.Value =
                    dip.EntryDate;

                txtBeforeReading.Text =
                    dip.BeforeReading.ToString("N2");

                txtAfterReading.Text =
                    dip.AfterReading.ToString("N2");

                txtDailySales.Text =
                    dip.DailySales.ToString("N2");

                txtPhysicalDipStock.Text =
                    dip.PhysicalDipStock.ToString("N2");

                decimal fuelPrice =
                    dipEntryService.GetCurrentFuelPrice(
                        dip.FuelTypeID,
                        dip.EntryDate);

                txtFuelPrice.Text =
                    fuelPrice.ToString("N2");

                txtCashExpected.Text =
                    dipEntryService
                        .CalculateExpectedCash(
                            dip.DailySales,
                            fuelPrice)
                        .ToString("N2");

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading selected record:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDipID == 0)
            {
                MessageBox.Show(
                    "Please select a record first.",
                    "Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                DipEntry dip = new DipEntry
                {
                    DipID = selectedDipID,

                    FuelTypeID =
                        Convert.ToInt32(
                            cmbFuelType.SelectedValue),

                    UserID =
                        GetCurrentUserID(),

                    BeforeReading =
                        decimal.Parse(
                            txtBeforeReading.Text.Trim()),

                    AfterReading =
                        decimal.Parse(
                            txtAfterReading.Text.Trim()),

                    PhysicalDipStock =
                        decimal.Parse(
                            txtPhysicalDipStock.Text.Trim()),

                    EntryDate =
                        dtpEntryDate.Value.Date
                };

                bool updated =
                    dipEntryService.UpdateDipEntry(dip);

                if (updated)
                {
                    MessageBox.Show(
                        "Dip reading updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDipEntries();

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating dip reading:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDipID == 0)
            {
                MessageBox.Show(
                    "Please select a record first.",
                    "Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this dip reading?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                bool deleted =
                    dipEntryService.DeleteDipEntry(
                        selectedDipID);

                if (deleted)
                {
                    MessageBox.Show(
                        "Dip reading deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDipEntries();

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting dip reading:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // new method for stocks coneection with dip entry

        private void CalculateStockReconciliation()
        {
            try
            {
                // Auto-load opening stock if not entered
                if (string.IsNullOrWhiteSpace(txtOpeningStock.Text) || txtOpeningStock.Text == "0.00")
                {
                    if (cmbFuelType.SelectedIndex != -1)
                    {
                        int fuelTypeID = Convert.ToInt32(cmbFuelType.SelectedValue);
                        decimal openingStockk = dipEntryService.GetOpeningStock(fuelTypeID);
                        txtOpeningStock.Text = openingStockk.ToString("N2");
                    }
                }

                // Auto-load received stock if not entered
                if (string.IsNullOrWhiteSpace(txtRecievedStock.Text) || txtRecievedStock.Text == "0.00")
                {
                    if (cmbFuelType.SelectedIndex != -1)
                    {
                        int fuelTypeID = Convert.ToInt32(cmbFuelType.SelectedValue);
                        DateTime entryDate = dtpEntryDate.Value.Date;
                        decimal receivedStockk = dipEntryService.GetReceivedStock(fuelTypeID, entryDate);
                        txtRecievedStock.Text = receivedStockk.ToString("N2");
                    }
                }

                if (!decimal.TryParse(txtOpeningStock.Text.Trim(), out decimal openingStock))
                {
                    txtStockAfterSales.Clear();
                    txtDifference.Clear();
                    return;
                }

                if (!decimal.TryParse(txtRecievedStock.Text.Trim(), out decimal receivedStock))
                {
                    txtStockAfterSales.Clear();
                    txtDifference.Clear();
                    return;
                }

                if (!decimal.TryParse(txtDailySales.Text.Trim(), out decimal dailySales))
                {
                    txtStockAfterSales.Clear();
                    txtDifference.Clear();
                    return;
                }

                if (!decimal.TryParse(txtPhysicalDipStock.Text.Trim(), out decimal physicalDipStock))
                {
                    txtStockAfterSales.Clear();
                    txtDifference.Clear();
                    return;
                }

                decimal stockAfterSales;
                decimal difference;

                dipEntryService.CalculateStockReconciliation(
                    openingStock,
                    receivedStock,
                    dailySales,
                    physicalDipStock,
                    out stockAfterSales,
                    out difference);

                txtStockAfterSales.Text = stockAfterSales.ToString("N2");
                txtDifference.Text = difference.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating stock reconciliation:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhysicalDip_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculateDip_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFuelType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a fuel type first.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbFuelType.Focus();
                    return;
                }

                if (!decimal.TryParse(txtDipHeight.Text.Trim(), out decimal dipHeight))
                {
                    MessageBox.Show("Please enter a valid dip height in centimeters.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDipHeight.Focus();
                    return;
                }

                if (dipHeight < 0)
                {
                    MessageBox.Show("Dip height cannot be negative.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDipHeight.Focus();
                    return;
                }

                int fuelTypeID = Convert.ToInt32(cmbFuelType.SelectedValue);
                decimal physicalStock = dipEntryService.GetFuelVolumeFromDip(fuelTypeID, dipHeight);

                txtPhysicalDipStock.Text = physicalStock.ToString("N2");

                // Auto-calculate stock reconciliation
                CalculateStockReconciliation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating physical dip stock:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
