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
            //Format and execute SQL statement
            string sql = $"Insert into Inventory (Make, Color, PetName) VALUES ('{car.Make}','{car.Color}',{car.PetName}')";

            //Execute using our connection
            using (SqlCommand command = new SqlCommand(sql, _sqlconnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Couldn't Insert into Inventory table!", ex);
                    throw error;
                }
            }
        }

        public void DeleteCar(int id)
        {
            string sql = $"DELETE FROM Inventory Where CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql, _sqlconnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry! That car is on order!", ex);
                    throw error;
                }
            }
        }

        public void UpdateCarPetName(int id,string newPetName) {
            //Update the PetName of the car with a specific CarId.
            string sql = $"UPDATE Inventory SET PetName = '{newPetName}' WHERE CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql,_sqlconnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Exception error = new Exception("Couldn't Update Inventory table!", ex);
                    throw error;
                }                
            }
        }

        public DataTable GetAllInventoryAsList()
        {
            //This will hold the records.
            DataTable dataTable = new DataTable();

            //prep command object
            string sql = $"SELECT * FROM Inventory";
            using (SqlCommand command = new SqlCommand(sql,_sqlconnection))
            {
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    //Fill the datatable with data from the reader and clean up
                    dataTable.Load(command.ExecuteReader());
                    dataReader.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Exception error = new Exception("Sorry couldn't get inventory list",ex);
                    throw error;
                }
            }
        }



    }
}
