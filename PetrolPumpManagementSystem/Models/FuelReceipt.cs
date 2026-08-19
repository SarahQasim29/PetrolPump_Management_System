using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolPumpManagementSystem.Models
{
    public class FuelReceipt
    {
        public int ReceiptID { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; } = string.Empty;
        public int FuelTypeID { get; set; }
        public string FuelName { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime ReceiptDate { get; set; }
    }
}
