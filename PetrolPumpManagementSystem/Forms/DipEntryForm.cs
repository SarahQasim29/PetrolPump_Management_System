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
        private readonly DipEntryService dipEntryService = new DipEntryService();
        private readonly FuelService fuelTypeService = new FuelService();
        public DipEntryForm()
        {
            InitializeComponent();
        }

        private void LoadFuelTypes()
        {
            cmbFuelType.DataSource = fuelTypeService.GetFuelTypes();

            cmbFuelType.DisplayMember = "FuelName";

            cmbFuelType.ValueMember = "FuelTypeID";

            cmbFuelType.SelectedIndex = -1;
        }

        private void LoadDipEntries()
        {
            dgvDipEntries.DataSource = dipEntryService.GetAllDipEntries();
        }


        private void DipEntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
