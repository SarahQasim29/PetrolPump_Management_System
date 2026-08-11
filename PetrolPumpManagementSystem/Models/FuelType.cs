using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolPumpManagementSystem.Models
{
    public class FuelType
    {
        public int FuelTypeID { get; set; }

        public string FuelName { get; set; } = string.Empty;

        public decimal TankCapacity { get; set; }
    }
}
