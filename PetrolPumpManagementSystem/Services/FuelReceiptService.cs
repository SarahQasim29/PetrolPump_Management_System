using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using PetrolPumpManagementSystem.Models;

namespace PetrolPumpManagementSystem.Services
{
    public class FuelReceiptService
    {
        private readonly string connectionString =
            @"Server=localhost\SQLEXPRESS;
              Database=PetrolPumpDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public DataTable GetAllFuelReceipts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        R.ReceiptID,
                        R.SupplierID,
                        S.SupplierName,
                        R.FuelTypeID,
                        F.FuelName,
                        R.Quantity,
                        R.PurchasePrice,
                        R.Quantity * R.PurchasePrice AS TotalAmount,
                        R.ReceiptDate
                    FROM FuelReceipts R
                    INNER JOIN Suppliers S ON R.SupplierID = S.SupplierID
                    INNER JOIN FuelTypes F ON R.FuelTypeID = F.FuelTypeID
                    ORDER BY R.ReceiptDate DESC, R.ReceiptID DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable GetSuppliers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT SupplierID, SupplierName
                    FROM Suppliers
                    ORDER BY SupplierName";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable GetFuelTypes()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT FuelTypeID, FuelName
                    FROM FuelTypes
                    ORDER BY FuelName";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public bool SaveFuelReceipt(FuelReceipt receipt)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO FuelReceipts 
                    (SupplierID, FuelTypeID, Quantity, PurchasePrice, ReceiptDate)
                    VALUES 
                    (@SupplierID, @FuelTypeID, @Quantity, @PurchasePrice, @ReceiptDate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", receipt.SupplierID);
                    cmd.Parameters.AddWithValue("@FuelTypeID", receipt.FuelTypeID);
                    cmd.Parameters.AddWithValue("@Quantity", receipt.Quantity);
                    cmd.Parameters.AddWithValue("@PurchasePrice", receipt.PurchasePrice);
                    cmd.Parameters.AddWithValue("@ReceiptDate", receipt.ReceiptDate.Date);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateFuelReceipt(FuelReceipt receipt)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE FuelReceipts
                    SET 
                        SupplierID = @SupplierID,
                        FuelTypeID = @FuelTypeID,
                        Quantity = @Quantity,
                        PurchasePrice = @PurchasePrice,
                        ReceiptDate = @ReceiptDate
                    WHERE ReceiptID = @ReceiptID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ReceiptID", receipt.ReceiptID);
                    cmd.Parameters.AddWithValue("@SupplierID", receipt.SupplierID);
                    cmd.Parameters.AddWithValue("@FuelTypeID", receipt.FuelTypeID);
                    cmd.Parameters.AddWithValue("@Quantity", receipt.Quantity);
                    cmd.Parameters.AddWithValue("@PurchasePrice", receipt.PurchasePrice);
                    cmd.Parameters.AddWithValue("@ReceiptDate", receipt.ReceiptDate.Date);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteFuelReceipt(int receiptID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM FuelReceipts WHERE ReceiptID = @ReceiptID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ReceiptID", receiptID);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable SearchFuelReceipts(string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        R.ReceiptID,
                        R.SupplierID,
                        S.SupplierName,
                        R.FuelTypeID,
                        F.FuelName,
                        R.Quantity,
                        R.PurchasePrice,
                        R.Quantity * R.PurchasePrice AS TotalAmount,
                        R.ReceiptDate
                    FROM FuelReceipts R
                    INNER JOIN Suppliers S ON R.SupplierID = S.SupplierID
                    INNER JOIN FuelTypes F ON R.FuelTypeID = F.FuelTypeID
                    WHERE 
                        S.SupplierName LIKE @Search
                        OR F.FuelName LIKE @Search
                        OR CONVERT(VARCHAR(10), R.ReceiptDate, 120) LIKE @Search
                    ORDER BY R.ReceiptDate DESC, R.ReceiptID DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public FuelReceipt GetFuelReceiptByID(int receiptID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        R.ReceiptID,
                        R.SupplierID,
                        S.SupplierName,
                        R.FuelTypeID,
                        F.FuelName,
                        R.Quantity,
                        R.PurchasePrice,
                        R.Quantity * R.PurchasePrice AS TotalAmount,
                        R.ReceiptDate
                    FROM FuelReceipts R
                    INNER JOIN Suppliers S ON R.SupplierID = S.SupplierID
                    INNER JOIN FuelTypes F ON R.FuelTypeID = F.FuelTypeID
                    WHERE R.ReceiptID = @ReceiptID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ReceiptID", receiptID);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new FuelReceipt
                            {
                                ReceiptID = Convert.ToInt32(reader["ReceiptID"]),
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                SupplierName = reader["SupplierName"].ToString()!,
                                FuelTypeID = Convert.ToInt32(reader["FuelTypeID"]),
                                FuelName = reader["FuelName"].ToString()!,
                                Quantity = Convert.ToDecimal(reader["Quantity"]),
                                PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                ReceiptDate = Convert.ToDateTime(reader["ReceiptDate"])
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
