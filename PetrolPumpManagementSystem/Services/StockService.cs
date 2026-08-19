using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using PetrolPumpManagementSystem.Models;

namespace PetrolPumpManagementSystem.Services
{
    public class StockService
    {
        private readonly string connectionString =
            @"Server=localhost\SQLEXPRESS;
              Database=PetrolPumpDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        // Get all stock with fuel type names
        public DataTable GetAllStock()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        S.StockID,
                        S.FuelTypeID,
                        F.FuelName,
                        S.CurrentStock,
                        S.LastUpdated,
                        F.TankCapacity
                    FROM Stock S
                    INNER JOIN FuelTypes F ON S.FuelTypeID = F.FuelTypeID
                    ORDER BY F.FuelName";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // Get stock for a specific fuel type
        public DataRow GetStockByFuelType(int fuelTypeID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        S.StockID,
                        S.FuelTypeID,
                        F.FuelName,
                        S.CurrentStock,
                        S.LastUpdated,
                        F.TankCapacity
                    FROM Stock S
                    INNER JOIN FuelTypes F ON S.FuelTypeID = F.FuelTypeID
                    WHERE S.FuelTypeID = @FuelTypeID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                        return null;
                    }
                }
            }
        }

        // Get opening stock (current stock)
        public decimal GetOpeningStock(int fuelTypeID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT TOP 1 CurrentStock
            FROM Stock
            WHERE FuelTypeID = @FuelTypeID
            ORDER BY LastUpdated DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
            }
        }

        // Update stock for a fuel type
        public bool UpdateStock(int fuelTypeID, decimal newStock)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Stock
                    SET CurrentStock = @CurrentStock,
                        LastUpdated = GETDATE()
                    WHERE FuelTypeID = @FuelTypeID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    cmd.Parameters.AddWithValue("@CurrentStock", newStock);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Initialize stock for a fuel type (if it doesn't exist)
        public bool InitializeStockForFuelType(int fuelTypeID, decimal initialStock)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Check if stock exists
                string checkQuery = "SELECT COUNT(*) FROM Stock WHERE FuelTypeID = @FuelTypeID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    con.Open();
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    con.Close();

                    if (count > 0)
                    {
                        // Update existing
                        return UpdateStock(fuelTypeID, initialStock);
                    }
                    else
                    {
                        // Insert new
                        string insertQuery = @"
                            INSERT INTO Stock (FuelTypeID, CurrentStock, LastUpdated)
                            VALUES (@FuelTypeID, @CurrentStock, GETDATE())";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                            cmd.Parameters.AddWithValue("@CurrentStock", initialStock);
                            con.Open();
                            return cmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
            }
        }

        // Get stock history from DipEntries (since your Stock table doesn't have history)
        public DataTable GetStockHistory(int fuelTypeID, DateTime? fromDate = null, DateTime? toDate = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        D.EntryDate,
                        F.FuelName,
                        D.BeforeReading,
                        D.AfterReading,
                        D.DailySales,
                        D.PhysicalDipStock
                    FROM DipEntries D
                    INNER JOIN FuelTypes F ON D.FuelTypeID = F.FuelTypeID
                    WHERE D.FuelTypeID = @FuelTypeID";

                if (fromDate.HasValue)
                    query += " AND D.EntryDate >= @FromDate";
                if (toDate.HasValue)
                    query += " AND D.EntryDate <= @ToDate";

                query += " ORDER BY D.EntryDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    if (fromDate.HasValue)
                        cmd.Parameters.AddWithValue("@FromDate", fromDate.Value);
                    if (toDate.HasValue)
                        cmd.Parameters.AddWithValue("@ToDate", toDate.Value);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Check if any stock record exists
        public bool HasStockRecords()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Stock";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // Get low stock threshold (from Settings or default)
        public decimal GetLowStockThreshold()
        {
            // You can later get this from Settings table
            // For now, return default
            return 1000;
        }
    }
}
