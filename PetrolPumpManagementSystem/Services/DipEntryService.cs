using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using PetrolPumpManagementSystem.Models;
using System.Data;


namespace PetrolPumpManagementSystem.Services
{
    internal class DipEntryService
    {
        private readonly string connectionString =
            @"Server=localhost\SQLEXPRESS;
              Database=PetrolPumpDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";
        public bool SaveDipEntry(DipEntry dip)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO DipEntries
            (
                FuelTypeID,
                UserID,
                BeforeReading,
                AfterReading,
                PhysicalDipStock,
                EntryDate
            )
            VALUES
            (
                @FuelTypeID,
                @UserID,
                @BeforeReading,
                @AfterReading,
                @PhysicalDipStock,
                @EntryDate
            )";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@FuelTypeID", SqlDbType.Int)
                        .Value = dip.FuelTypeID;

                    cmd.Parameters.Add("@UserID", SqlDbType.Int)
                        .Value = dip.UserID;

                    cmd.Parameters.Add("@BeforeReading", SqlDbType.Decimal)
                        .Value = dip.BeforeReading;

                    cmd.Parameters.Add("@AfterReading", SqlDbType.Decimal)
                        .Value = dip.AfterReading;

                    cmd.Parameters.Add("@PhysicalDipStock", SqlDbType.Decimal)
                        .Value = dip.PhysicalDipStock;

                    cmd.Parameters.Add("@EntryDate", SqlDbType.Date)
                        .Value = dip.EntryDate.Date;

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetFuelTypes()
        {
            using (SqlConnection con =
                   new SqlConnection(connectionString))
            {
                string query = @"
            SELECT
                FuelTypeID,
                FuelName
            FROM FuelTypes
            ORDER BY FuelName";

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
            }
        }

        public DataTable GetAllDipEntries()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT
                D.DipID,
                D.FuelTypeID,
                F.FuelName,
                D.BeforeReading,
                D.AfterReading,
                D.DailySales,
                D.PhysicalDipStock,
                D.EntryDate
            FROM DipEntries D
            INNER JOIN FuelTypes F
                ON D.FuelTypeID = F.FuelTypeID
            ORDER BY D.EntryDate DESC, D.DipID DESC";

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
            }
        }

        public DipEntry GetDipEntryByID(int dipID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT
                DipID,
                FuelTypeID,
                UserID,
                BeforeReading,
                AfterReading,
                DailySales,
                PhysicalDipStock,
                EntryDate
            FROM DipEntries
            WHERE DipID = @DipID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@DipID", SqlDbType.Int)
                        .Value = dipID;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DipEntry
                            {
                                DipID = Convert.ToInt32(reader["DipID"]),

                                FuelTypeID = Convert.ToInt32(
                                    reader["FuelTypeID"]),

                                UserID = Convert.ToInt32(
                                    reader["UserID"]),

                                BeforeReading = Convert.ToDecimal(
                                    reader["BeforeReading"]),

                                AfterReading = Convert.ToDecimal(
                                    reader["AfterReading"]),

                                DailySales = Convert.ToDecimal(
                                    reader["DailySales"]),

                                PhysicalDipStock = Convert.ToDecimal(
                                    reader["PhysicalDipStock"]),

                                EntryDate = Convert.ToDateTime(
                                    reader["EntryDate"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool DeleteDipEntry(int dipID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            DELETE FROM DipEntries
            WHERE DipID = @DipID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@DipID", SqlDbType.Int)
                        .Value = dipID;

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateDipEntry(DipEntry dip)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE DipEntries
            SET
                FuelTypeID = @FuelTypeID,
                BeforeReading = @BeforeReading,
                AfterReading = @AfterReading,
                PhysicalDipStock = @PhysicalDipStock,
                EntryDate = @EntryDate
            WHERE DipID = @DipID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@DipID", SqlDbType.Int)
                        .Value = dip.DipID;

                    cmd.Parameters.Add("@FuelTypeID", SqlDbType.Int)
                        .Value = dip.FuelTypeID;

                    cmd.Parameters.Add("@BeforeReading", SqlDbType.Decimal)
                        .Value = dip.BeforeReading;

                    cmd.Parameters.Add("@AfterReading", SqlDbType.Decimal)
                        .Value = dip.AfterReading;

                    cmd.Parameters.Add("@PhysicalDipStock", SqlDbType.Decimal)
                        .Value = dip.PhysicalDipStock;

                    cmd.Parameters.Add("@EntryDate", SqlDbType.Date)
                        .Value = dip.EntryDate.Date;

                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable SearchDipEntries(string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT
                D.DipID,
                D.FuelTypeID,
                F.FuelName,
                D.BeforeReading,
                D.AfterReading,
                D.DailySales,
                D.PhysicalDipStock,
                D.EntryDate
            FROM DipEntries D
            INNER JOIN FuelTypes F
                ON D.FuelTypeID = F.FuelTypeID
            WHERE
                F.FuelName LIKE @Search
                OR CONVERT(VARCHAR(10), D.EntryDate, 120)
                   LIKE @Search
            ORDER BY D.EntryDate DESC, D.DipID DESC";

                using (SqlDataAdapter adapter =
                       new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.Add(
                        "@Search",
                        SqlDbType.NVarChar
                    ).Value = "%" + searchText + "%";

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
            }
        }

        public decimal GetDailySales(int fuelTypeID, DateTime entryDate)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT DailySales
            FROM DipEntries
            WHERE FuelTypeID = @FuelTypeID
              AND EntryDate = @EntryDate";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@FuelTypeID", SqlDbType.Int)
                        .Value = fuelTypeID;

                    cmd.Parameters.Add("@EntryDate", SqlDbType.Date)
                        .Value = entryDate.Date;

                    con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return 0;

                    return Convert.ToDecimal(result);
                }
            }
        }

        public decimal GetCurrentFuelPrice(int fuelTypeID, DateTime entryDate)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT TOP 1 PricePerLiter
            FROM FuelPrices
            WHERE FuelTypeID = @FuelTypeID
              AND EffectiveDate <= @EntryDate
            ORDER BY EffectiveDate DESC, PriceID DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@FuelTypeID", SqlDbType.Int)
                        .Value = fuelTypeID;

                    cmd.Parameters.Add("@EntryDate", SqlDbType.Date)
                        .Value = entryDate.Date;

                    con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return 0;

                    return Convert.ToDecimal(result);
                }
            }
        }

        public decimal GetFuelVolumeFromDip(int fuelTypeID, decimal dipHeight)
        {
            string lowerQuery = @"
        SELECT TOP 1
            DipHeightCM,
            FuelVolumeLiters
        FROM TankCalibration
        WHERE FuelTypeID = @FuelTypeID
          AND DipHeightCM <= @DipHeight
        ORDER BY DipHeightCM DESC";

            string upperQuery = @"
        SELECT TOP 1
            DipHeightCM,
            FuelVolumeLiters
        FROM TankCalibration
        WHERE FuelTypeID = @FuelTypeID
          AND DipHeightCM >= @DipHeight
        ORDER BY DipHeightCM ASC";

            decimal lowerCM = 0, lowerLiters = 0;
            decimal upperCM = 0, upperLiters = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Get lower bound
                using (SqlCommand cmd = new SqlCommand(lowerQuery, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    cmd.Parameters.AddWithValue("@DipHeight", dipHeight);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lowerCM = Convert.ToDecimal(reader["DipHeightCM"]);
                            lowerLiters = Convert.ToDecimal(reader["FuelVolumeLiters"]);
                        }
                        else
                        {
                            throw new Exception("No calibration data found below the entered height.");
                        }
                    }
                }

                // Get upper bound
                using (SqlCommand cmd = new SqlCommand(upperQuery, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    cmd.Parameters.AddWithValue("@DipHeight", dipHeight);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            upperCM = Convert.ToDecimal(reader["DipHeightCM"]);
                            upperLiters = Convert.ToDecimal(reader["FuelVolumeLiters"]);
                        }
                        else
                        {
                            throw new Exception("No calibration data found above the entered height.");
                        }
                    }
                }
            }

            // If exact match found
            if (lowerCM == upperCM)
                return lowerLiters;

            // Linear interpolation
            decimal litersPerCM = (upperLiters - lowerLiters) / (upperCM - lowerCM);
            decimal result = lowerLiters + (dipHeight - lowerCM) * litersPerCM;

            return Math.Round(result, 2);
        }

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

        public decimal GetReceivedStock(int fuelTypeID, DateTime entryDate)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT ISNULL(SUM(Quantity), 0)
            FROM FuelReceipts
            WHERE FuelTypeID = @FuelTypeID
              AND ReceiptDate = @EntryDate";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    cmd.Parameters.AddWithValue("@EntryDate", entryDate.Date);
                    con.Open();

                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
            }
        }

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

        // Check if dip entry exists for a date
        public bool HasDipEntryForDate(int fuelTypeID, DateTime entryDate)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT COUNT(*)
            FROM DipEntries
            WHERE FuelTypeID = @FuelTypeID
              AND EntryDate = @EntryDate";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    cmd.Parameters.AddWithValue("@EntryDate", entryDate.Date);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // Get physical dip stock for a date
        public decimal GetPhysicalDipStock(int fuelTypeID, DateTime entryDate)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT PhysicalDipStock
            FROM DipEntries
            WHERE FuelTypeID = @FuelTypeID
              AND EntryDate = @EntryDate";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    cmd.Parameters.AddWithValue("@EntryDate", entryDate.Date);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                }
            }
        }

        // Update dip stock for a date
        public bool UpdateDipStock(int fuelTypeID, DateTime entryDate, decimal dipStock)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE DipEntries
            SET PhysicalDipStock = @PhysicalDipStock
            WHERE FuelTypeID = @FuelTypeID
              AND EntryDate = @EntryDate";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                    cmd.Parameters.AddWithValue("@EntryDate", entryDate.Date);
                    cmd.Parameters.AddWithValue("@PhysicalDipStock", dipStock);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }



        public decimal CalculateExpectedCash(
    decimal dailySales,
    decimal fuelPrice)
        {
            return dailySales * fuelPrice;
        }

        public decimal CalculateStockAfterSales(
    decimal openingStock,
    decimal receivedStock,
    decimal dailySales)
        {
            return openingStock + receivedStock - dailySales;
        }

        public decimal CalculateDifference(
    decimal stockAfterSales,
    decimal physicalDipStock)
        {
            return stockAfterSales - physicalDipStock;
        }

        public void CalculateStockReconciliation(
    decimal openingStock,
    decimal receivedStock,
    decimal dailySales,
    decimal physicalDipStock,
    out decimal stockAfterSales,
    out decimal difference)
        {
            stockAfterSales =
                openingStock
                + receivedStock
                - dailySales;

            difference =
                stockAfterSales
                - physicalDipStock;
        }

        public bool IsValidReading(
    decimal beforeReading,
    decimal afterReading,
    decimal physicalDipStock)
        {
            if (beforeReading < 0)
                return false;

            if (afterReading < 0)
                return false;

            if (physicalDipStock < 0)
                return false;

            if (afterReading < beforeReading)
                return false;

            return true;
        }
    }
}
