using System;
using System.Collections.Generic;
using System.Text;
using PetrolPumpManagementSystem.Models;
using Microsoft.Data.SqlClient;
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
                string query = @"INSERT INTO DipEntries
                        (FuelTypeID,UserID,DipLevel,Shift,EntryDate)
                        VALUES
                        (@FuelTypeID,@UserID,@DipLevel,@Shift,@EntryDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FuelTypeID", dip.FuelTypeID);
                cmd.Parameters.AddWithValue("@UserID", dip.UserID);
                cmd.Parameters.AddWithValue("@DipLevel", dip.DipLevel);
                cmd.Parameters.AddWithValue("@Shift", dip.Shift);
                cmd.Parameters.AddWithValue("@EntryDate", dip.EntryDate);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetAllDipEntries()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                            D.DipID,
                            F.FuelName,
                            D.DipLevel,
                            D.Shift,
                            D.EntryDate
                         FROM DipEntries D
                         INNER JOIN FuelTypes F
                         ON D.FuelTypeID = F.FuelTypeID
                         ORDER BY D.EntryDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

        public bool DeleteDipEntry(int dipID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM DipEntries WHERE DipID=@DipID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DipID", dipID);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateDipEntry(DipEntry dip)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE DipEntries
                         SET FuelTypeID=@FuelTypeID,
                             DipLevel=@DipLevel,
                             Shift=@Shift,
                             EntryDate=@EntryDate
                         WHERE DipID=@DipID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DipID", dip.DipID);
                cmd.Parameters.AddWithValue("@FuelTypeID", dip.FuelTypeID);
                cmd.Parameters.AddWithValue("@DipLevel", dip.DipLevel);
                cmd.Parameters.AddWithValue("@Shift", dip.Shift);
                cmd.Parameters.AddWithValue("@EntryDate", dip.EntryDate);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable SearchDipEntries(string fuelName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT
                            D.DipID,
                            F.FuelName,
                            D.DipLevel,
                            D.Shift,
                            D.EntryDate
                         FROM DipEntries D
                         INNER JOIN FuelTypes F
                         ON D.FuelTypeID = F.FuelTypeID
                         WHERE F.FuelName LIKE @FuelName
                         ORDER BY D.EntryDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue("@FuelName", "%" + fuelName + "%");

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

    }
}
