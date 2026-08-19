using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolPumpManagementSystem.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        public int FuelTypeID { get; set; }
        public string FuelName { get; set; } = string.Empty;
        public decimal CurrentStock { get; set; }
        public DateTime LastUpdated { get; set; }
        public decimal TankCapacity { get; set; }

        // Calculated properties
        public decimal PercentageFull => TankCapacity > 0 ? (CurrentStock / TankCapacity) * 100 : 0;

        public string StockStatus
        {
            get
            {
                if (CurrentStock <= 0) return "Empty";
                if (CurrentStock <= 1000) return "⚠️ Critical - Order Now!";
                if (CurrentStock <= 3000) return "⚠️ Low";
                if (CurrentStock <= 7000) return "Medium";
                return "✓ High";
            }
        }

        public string StatusColor
        {
            get
            {
                if (CurrentStock <= 0 || CurrentStock <= 1000) return "Red";
                if (CurrentStock <= 3000) return "Orange";
                if (CurrentStock <= 7000) return "Blue";
                return "Green";
            }
        }
    }
}
