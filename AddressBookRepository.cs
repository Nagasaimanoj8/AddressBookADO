﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAdo
{
    public class AddressBookRepository
    {
        public static string connectionString = "@Data Source=DESKTOP-RKMTS0O;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = null;
        public void GetAllData()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))//Creating Object And initializing to the variable
                {
                    AddressBookModel model = new AddressBookModel();
                    string query = "select * from AddressBookTable";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.PersonId = Convert.ToInt32(reader["PersonId"] == DBNull.Value ? default : reader["PersonId"]);
                            //role.EmployeeId=Convert.ToInt(reader[0]);
                            model.Firstname = reader["Firstname"] == DBNull.Value ? default : reader["Firstname"].ToString();
                            model.Lastname = reader["Lastname"] == DBNull.Value ? default : reader["Lastname"].ToString();
                            model.city = reader["city"] == DBNull.Value ? default : reader["city"].ToString();
                            model.Zip = Convert.ToInt32(reader["Zip"] == DBNull.Value ? default : reader["Zip"]);
                            //role.Phonenumber =Convert.ToDouble(reader["phone"]);
                            model.MobileNumber = reader["MobileNumber"] == DBNull.Value ? default : reader["MobileNumber"].ToString();
                            model.EmailId = reader["EmailId"] == DBNull.Value ? default : reader["EmailId"].ToString();
                            model.Address = reader["Address"] == DBNull.Value ? default : reader["Address"].ToString();
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", model.PersonId, model.Firstname, model.Lastname
                                   , model.Address, model.city, model.State, model.Zip, model.MobileNumber, model.EmailId);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }

        }
        public void InsertData(AddressBookModel model)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("dbo.spAddressBook", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonId", model.PersonId);
                    command.Parameters.AddWithValue("@FirstName", model.Firstname);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@Lastname", model.Lastname);
                    command.Parameters.AddWithValue("@MobileNumber", model.MobileNumber);
                    command.Parameters.AddWithValue("@city", model.city);
                    command.Parameters.AddWithValue("@EmailId", model.EmailId);
                    command.Parameters.AddWithValue("@Zip", model.Zip);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    
                        Console.WriteLine("Employee inserted sucessfully into table ");
                    else
                            Console.WriteLine("Not inserted");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateeData(AddressBookModel model)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("dbo.spUpdatePerson", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@city", model.city);
                    command.Parameters.AddWithValue("@FirstName", model.Firstname);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    if (result != 0)

                        Console.WriteLine("Employee Updated sucessfully into table ");
                    else
                        Console.WriteLine("Not Updated");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
