using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolPumpManagementSystem.Models
{
    public class DipEntry
    {
        public int DipID { get; set; }

        public int FuelTypeID { get; set; }

        public int UserID { get; set; }

        public decimal DipLevel { get; set; }

        public string Shift { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
