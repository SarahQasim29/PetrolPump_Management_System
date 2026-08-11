using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolPumpManagementSystem.Models
{
    public class FuelPrice
    {
        public int PriceID { get; set; }

        public int FuelTypeID { get; set; }

        public string FuelName { get; set; } = string.Empty;

        public decimal PricePerLiter { get; set; }

        public DateTime EffectiveDate { get; set; }
    }
}
