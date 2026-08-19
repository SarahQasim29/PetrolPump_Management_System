using Microsoft.Data.SqlClient;
using PetrolPumpManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PetrolPumpManagementSystem.Services
{
    internal class SupplierService
    {
        private readonly string connectionString =
           @"Server=localhost\SQLEXPRESS;
              Database=PetrolPumpDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public DataTable GetAllSuppliers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        SupplierID,
                        SupplierName,
                        ContactPerson,
                        PhoneNumber,
                        Email,
                        Address
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

        public bool SaveSupplier(Supplier supplier)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Suppliers 
                    (SupplierName, ContactPerson, PhoneNumber, Email, Address)
                    VALUES 
                    (@SupplierName, @ContactPerson, @PhoneNumber, @Email, @Address)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@ContactPerson", supplier.ContactPerson ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", supplier.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Suppliers
                    SET 
                        SupplierName = @SupplierName,
                        ContactPerson = @ContactPerson,
                        PhoneNumber = @PhoneNumber,
                        Email = @Email,
                        Address = @Address
                    WHERE SupplierID = @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@ContactPerson", supplier.ContactPerson ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", supplier.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteSupplier(int supplierID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Check if supplier has receipts
                string checkQuery = "SELECT COUNT(*) FROM FuelReceipts WHERE SupplierID = @SupplierID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    con.Open();
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    con.Close();

                    if (count > 0)
                    {
                        throw new Exception("Cannot delete supplier because they have existing fuel receipts.");
                    }
                }

                string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable SearchSuppliers(string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        SupplierID,
                        SupplierName,
                        ContactPerson,
                        PhoneNumber,
                        Email,
                        Address
                    FROM Suppliers
                    WHERE 
                        SupplierName LIKE @Search
                        OR ContactPerson LIKE @Search
                        OR PhoneNumber LIKE @Search
                        OR Email LIKE @Search
                    ORDER BY SupplierName";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public Supplier GetSupplierByID(int supplierID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        SupplierID,
                        SupplierName,
                        ContactPerson,
                        PhoneNumber,
                        Email,
                        Address
                    FROM Suppliers
                    WHERE SupplierID = @SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Supplier
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                SupplierName = reader["SupplierName"].ToString()!,
                                ContactPerson = reader["ContactPerson"].ToString()!,
                                PhoneNumber = reader["PhoneNumber"].ToString()!,
                                Email = reader["Email"].ToString()!,
                                Address = reader["Address"].ToString()!
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool SupplierExists(string supplierName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Suppliers WHERE SupplierName = @SupplierName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool SupplierExistsForUpdate(int supplierID, string supplierName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Suppliers WHERE SupplierName = @SupplierName AND SupplierID != @SupplierID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}
