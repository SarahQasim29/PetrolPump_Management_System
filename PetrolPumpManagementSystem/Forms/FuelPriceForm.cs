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
    public partial class FuelPriceForm : Form
    {
        private readonly FuelService fuelService = new FuelService();

        private int selectedPriceID = 0;

        public FuelPriceForm()
        {
            InitializeComponent();
        }

        private void LoadFuelTypes()
        {
            try
            {
                List<FuelType> fuelTypes =
                    fuelService.GetFuelTypes();

                cmbFuelType.DataSource = fuelTypes;

                cmbFuelType.DisplayMember = "FuelName";

                cmbFuelType.ValueMember = "FuelTypeID";

                cmbFuelType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadFuelPrices()
        {
            try
            {
                dgvFuelPrices.DataSource = fuelService.GetFuelPrices();

                dgvFuelPrices.Columns["FuelTypeID"]!.Visible = false;

                dgvFuelPrices.Columns["PriceID"]!.HeaderText = "ID";
                dgvFuelPrices.Columns["FuelName"]!.HeaderText = "Fuel Type";
                dgvFuelPrices.Columns["PricePerLiter"]!.HeaderText = "Price / Liter";
                dgvFuelPrices.Columns["EffectiveDate"]!.HeaderText = "Effective Date";

                dgvFuelPrices.Columns["PricePerLiter"]!.DefaultCellStyle.Format = "N2";
                dgvFuelPrices.Columns["EffectiveDate"]!.DefaultCellStyle.Format = "dd-MMM-yyyy";

                dgvFuelPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvFuelPrices.EnableHeadersVisualStyles = false;
                dgvFuelPrices.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);

                dgvFuelPrices.ColumnHeadersHeight = 40;

                dgvFuelPrices.ClearSelection();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "This fuel price is being used by another record and cannot be deleted.",
                        "Delete Not Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dgvFuelPrices.Rows.Count == 0)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void ClearFields()
        {
            selectedPriceID = 0;

            cmbFuelType.SelectedIndex = -1;

            txtPrice.Clear();

            txtSearch.Clear();

            dtpEffectiveDate.Value = DateTime.Today;

            dgvFuelPrices.ClearSelection();

            btnSave.Enabled = true;

            btnUpdate.Enabled = false;

            btnDelete.Enabled = false;

            txtPrice.Focus();
        }

        private bool ValidateInput()
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

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show(
                    "Please enter the price per liter.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show(
                    "Please enter a valid numeric price.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                return false;
            }

            if (price <= 0)
            {
                MessageBox.Show(
                    "Price must be greater than zero.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                return false;
            }

            if (price > 1000)
            {
                MessageBox.Show(
                    "Price seems unrealistic.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                return false;
            }

            if (dtpEffectiveDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Future dates are not allowed.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpEffectiveDate.Focus();
                return false;
            }

            return true;
        }

        private void LoadSearchResults(string searchText)
        {
            dgvFuelPrices.DataSource =
                fuelService.SearchFuelPrices(searchText);

            if (dgvFuelPrices.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            dgvFuelPrices.Columns["FuelTypeID"]!.Visible = false;

            dgvFuelPrices.Columns["PriceID"]!.HeaderText = "ID";

            dgvFuelPrices.Columns["FuelName"]!.HeaderText = "Fuel Type";

            dgvFuelPrices.Columns["PricePerLiter"]!.HeaderText = "Price / Liter";

            dgvFuelPrices.Columns["EffectiveDate"]!.HeaderText = "Effective Date";

            dgvFuelPrices.Columns["PricePerLiter"]!
                .DefaultCellStyle.Format = "N2";

            dgvFuelPrices.Columns["EffectiveDate"]!
                .DefaultCellStyle.Format = "dd-MMM-yyyy";
        }

        private void FuelPriceForm_Load(object sender, EventArgs e)
        {
            LoadFuelTypes();
            LoadFuelPrices();
            ClearFields();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFuelPrices();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (fuelService.FuelPriceExists(Convert.ToInt32(cmbFuelType.SelectedValue), dtpEffectiveDate.Value))
            {
                MessageBox.Show(
                    "A price for this fuel type already exists on the selected date.",
                    "Duplicate Record",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int fuelTypeID =
                    Convert.ToInt32(cmbFuelType.SelectedValue);

                decimal price =
                    Convert.ToDecimal(txtPrice.Text);

                DateTime effectiveDate =
                    dtpEffectiveDate.Value.Date;

                bool result = fuelService.AddFuelPrice(
                                fuelTypeID,
                                price,
                                effectiveDate);

                if (result)
                {
                    MessageBox.Show(
                        "Fuel price saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadFuelPrices();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Unable to save record.");
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "A price for this fuel type already exists for the selected date.",
                        "Duplicate Record",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' &&
                txtPrice.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void dgvFuelPrices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvFuelPrices.Rows[e.RowIndex];

            selectedPriceID = Convert.ToInt32(row.Cells["PriceID"].Value);

            cmbFuelType.Text = row.Cells["FuelName"].Value.ToString();

            txtPrice.Text = row.Cells["PricePerLiter"].Value.ToString();

            dtpEffectiveDate.Value =
                Convert.ToDateTime(row.Cells["EffectiveDate"].Value);

            btnSave.Enabled = false;

            btnUpdate.Enabled = true;

            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (fuelService.FuelPriceExistsForUpdate(selectedPriceID, Convert.ToInt32(cmbFuelType.SelectedValue), dtpEffectiveDate.Value))
            {
                MessageBox.Show(
                    "Another record already exists for this fuel type and date.",
                    "Duplicate Record",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            try
            {


                bool result =
                    fuelService.UpdateFuelPrice(
                        selectedPriceID,
                        Convert.ToInt32(cmbFuelType.SelectedValue),
                        Convert.ToDecimal(txtPrice.Text),
                        dtpEffectiveDate.Value);

                if (result)
                {
                    MessageBox.Show(
                        "Fuel price updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadFuelPrices();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show(
                        "Record not updated.");
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "A price for this fuel type already exists on the selected date.",
                        "Duplicate Record",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPriceID == 0)
            {
                MessageBox.Show(
                    "Please select a record first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this fuel price?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool deleted =
                        fuelService.DeleteFuelPrice(selectedPriceID);

                    if (deleted)
                    {
                        MessageBox.Show(
                            "Fuel price deleted successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadFuelPrices();

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Record could not be deleted.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearchResults(txtSearch.Text.Trim());
        }

        private void cmbFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = cmbFuelType.SelectedIndex != -1;
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                txtPrice.Text = price.ToString("N2");
            }
        }
    }
}
