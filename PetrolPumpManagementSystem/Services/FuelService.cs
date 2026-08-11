using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using PetrolPumpManagementSystem.Database;
using PetrolPumpManagementSystem.Models;

namespace PetrolPumpManagementSystem.Services
{
    public class FuelService
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        public List<FuelType> GetFuelTypes()
        {
            List<FuelType> fuelTypes = new List<FuelType>();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query =
                    @"SELECT FuelTypeID,
                             FuelName,
                             TankCapacity
                      FROM FuelTypes
                      ORDER BY FuelName";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FuelType fuel = new FuelType();

                    fuel.FuelTypeID = Convert.ToInt32(reader["FuelTypeID"]);

                    fuel.FuelName = reader["FuelName"].ToString()!;

                    fuel.TankCapacity =
                        Convert.ToDecimal(reader["TankCapacity"]);

                    fuelTypes.Add(fuel);
                }
            }

            return fuelTypes;
        }

        public List<FuelPrice> GetFuelPrices()
        {
            List<FuelPrice> fuelPrices = new List<FuelPrice>();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT
                                FP.PriceID,
                                FP.FuelTypeID,
                                FT.FuelName,
                                FP.PricePerLiter,
                                FP.EffectiveDate
                            FROM FuelPrices FP
                            INNER JOIN FuelTypes FT
                                ON FP.FuelTypeID = FT.FuelTypeID
                            ORDER BY
                                FP.EffectiveDate DESC,
                                FT.FuelName";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FuelPrice fuelPrice = new FuelPrice();

                    fuelPrice.PriceID =
                        Convert.ToInt32(reader["PriceID"]);

                    fuelPrice.FuelTypeID =
                        Convert.ToInt32(reader["FuelTypeID"]);

                    fuelPrice.FuelName =
                        reader["FuelName"].ToString()!;

                    fuelPrice.PricePerLiter =
                        Convert.ToDecimal(reader["PricePerLiter"]);

                    fuelPrice.EffectiveDate =
                        Convert.ToDateTime(reader["EffectiveDate"]);

                    fuelPrices.Add(fuelPrice);
                }
            }

            return fuelPrices;
        }

        public bool AddFuelPrice(int fuelTypeID,
                         decimal pricePerLiter,
                         DateTime effectiveDate)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                            INSERT INTO FuelPrices
                            (
                                FuelTypeID,
                                PricePerLiter,
                                EffectiveDate
                            )
                            VALUES
                            (
                                @FuelTypeID,
                                @PricePerLiter,
                                @EffectiveDate
                            )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);

                cmd.Parameters.AddWithValue("@PricePerLiter", pricePerLiter);

                cmd.Parameters.AddWithValue("@EffectiveDate", effectiveDate.Date);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateFuelPrice(int priceID,
                            int fuelTypeID,
                            decimal pricePerLiter,
                            DateTime effectiveDate)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                            UPDATE FuelPrices
                            SET
                                FuelTypeID = @FuelTypeID,
                                PricePerLiter = @PricePerLiter,
                                EffectiveDate = @EffectiveDate
                            WHERE
                                PriceID = @PriceID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PriceID", priceID);
                cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                cmd.Parameters.AddWithValue("@PricePerLiter", pricePerLiter);
                cmd.Parameters.AddWithValue("@EffectiveDate", effectiveDate.Date);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteFuelPrice(int priceID)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                            DELETE FROM FuelPrices
                            WHERE PriceID = @PriceID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PriceID", priceID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<FuelPrice> SearchFuelPrices(string searchText)
        {
            List<FuelPrice> fuelPrices = new List<FuelPrice>();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                            SELECT
                                FP.PriceID,
                                FP.FuelTypeID,
                                FT.FuelName,
                                FP.PricePerLiter,
                                FP.EffectiveDate
                            FROM FuelPrices FP
                            INNER JOIN FuelTypes FT
                                ON FP.FuelTypeID = FT.FuelTypeID
                            WHERE
                                FT.FuelName LIKE @Search
                                OR
                                CAST(FP.PricePerLiter AS VARCHAR(20)) LIKE @Search
                                OR
                                CONVERT(VARCHAR(20), FP.EffectiveDate, 106) LIKE @Search
                            ORDER BY
                                FP.EffectiveDate DESC,
                                FT.FuelName";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FuelPrice fuelPrice = new FuelPrice();

                    fuelPrice.PriceID = Convert.ToInt32(reader["PriceID"]);

                    fuelPrice.FuelTypeID = Convert.ToInt32(reader["FuelTypeID"]);

                    fuelPrice.FuelName = reader["FuelName"].ToString()!;

                    fuelPrice.PricePerLiter =
                        Convert.ToDecimal(reader["PricePerLiter"]);

                    fuelPrice.EffectiveDate =
                        Convert.ToDateTime(reader["EffectiveDate"]);

                    fuelPrices.Add(fuelPrice);
                }
            }

            return fuelPrices;
        }

        public bool FuelPriceExists(int fuelTypeID,
                            DateTime effectiveDate)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                            SELECT COUNT(*)
                            FROM FuelPrices
                            WHERE FuelTypeID = @FuelTypeID
                            AND EffectiveDate = @EffectiveDate";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                cmd.Parameters.AddWithValue("@EffectiveDate", effectiveDate.Date);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        public bool FuelPriceExistsForUpdate(int priceID,
                                     int fuelTypeID,
                                     DateTime effectiveDate)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                            SELECT COUNT(*)
                            FROM FuelPrices
                            WHERE FuelTypeID = @FuelTypeID
                            AND EffectiveDate = @EffectiveDate
                            AND PriceID <> @PriceID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PriceID", priceID);
                cmd.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);
                cmd.Parameters.AddWithValue("@EffectiveDate", effectiveDate.Date);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }
    }
}
