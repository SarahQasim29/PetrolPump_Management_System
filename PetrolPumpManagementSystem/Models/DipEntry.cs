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

        public decimal BeforeReading { get; set; }

        public decimal AfterReading { get; set; }

        public decimal DailySales { get; set; }

        public decimal PhysicalDipStock { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
