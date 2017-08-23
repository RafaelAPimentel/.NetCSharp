using System;
using System.Data.SqlClient;
using AutoLotDAL.Models;
using System.Collections.Generic;
using System.Data;

//You will sue the SQL server
//provider; however, it woul dalso be
//permissable to use the ADO.NET
//factory pattern for greater flexability

namespace AutoLotDAL.ConnectedLayer
{
    public class InventoryDAL
    {
        //this member will be used by all methods
        private SqlConnection _sqlconnection = null;

        public void OpenConnection(string connectionString)
        {
            _sqlconnection = new SqlConnection() { ConnectionString = connectionString };
            _sqlconnection.Open();
        }

        public void CloseConnection()
        {
            _sqlconnection.Close();
        }

        public void InsertAuto(NewCar car)
        {
            //Note the placeholders in the SQL query
            string sql = $"Insert into Inventory (Make, Color, PetName) VALUES ('{car.Make}','{car.Color}','{car.PetName}')";

            //This command will have internal parameter
            using (SqlCommand command = new SqlCommand(sql, _sqlconnection))
            {
                command.ExecuteNonQuery();
            }
        }

        public string LookUpPetName(int carID)
        {
            string carPetName;

            //Establish nae of stroed proc.
            using (SqlCommand command = new SqlCommand("GetPetName", _sqlconnection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    //Input parameters
                    SqlParameter parm = new SqlParameter
                    {
                        ParameterName = "@carID",
                        SqlDbType = SqlDbType.Int,
                        Value = carID,
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(parm);

                    parm = new SqlParameter
                    {
                        ParameterName = "@petName",
                        SqlDbType = SqlDbType.Char,
                        Size = 10,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(parm);

                    //execute the stored proc
                    command.ExecuteNonQuery();

                    //return output param
                    carPetName = (string)command.Parameters["@petName"].Value;
                    return carPetName;
                }
                catch (Exception ex)
                {
                    Exception error = new Exception("Sorry couldnt look up petname!",ex);
                    throw error;
                }
            }
        }

        public void DeleteCar(int id)
        {
            string sql = $"DELETE FROM Inventory Where CarId = @carId";
            using (SqlCommand command = new SqlCommand(sql, _sqlconnection))
            {
                try
                {
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@carId",
                        Value = id,
                        SqlDbType = SqlDbType.Int
                    };
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry! That car is on order!", ex);
                    throw error;
                }
            }
        }

        public void UpdateCarPetName(int id, string newPetName)
        {
            //Update the PetName of the car with a specific CarId.
            string sql = $"UPDATE Inventory SET PetName = @petName WHERE CarId = @carId";
            using (SqlCommand command = new SqlCommand(sql, _sqlconnection))
            {
                try
                {
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@petName",
                        Value = newPetName,
                        SqlDbType = SqlDbType.Char,
                        Size = 25
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@carId",
                        Value = id,
                        SqlDbType = SqlDbType.Int
                    };
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Exception error = new Exception("Couldn't update inventory table!", ex);
                    throw error;
                }
            }
        }

        public DataTable GetAllInventoryAsDataTable()
        {
            //This will hold the records.
            DataTable dataTable = new DataTable();

            //prep command object
            string sql = $"SELECT * FROM Inventory";
            using (SqlCommand command = new SqlCommand(sql, _sqlconnection))
            {
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    //Fill the datatable with data from the reader and clean up
                    dataTable.Load(dataReader);
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    Exception error = new Exception("Sorry couldn't get inventory list", ex);
                    throw error;
                }
            }
            return dataTable;
        }



    }
}
