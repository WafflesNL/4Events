﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseGetHighestID
    {
        /// <summary>
        /// Gets Highest ID For a specific Table
        /// </summary>
        /// <param name="Tablename">Name from a table in the database</param> 
        /// <returns>If record exists return a int that is not 0 or negative</returns>
        public static int GetHighestID(string TableName)
        {
            int Check = 0;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT MAX(ID) AS Max FROM " + TableName;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Check = (reader["Max"] != DBNull.Value) ? Convert.ToInt32(reader["Max"]) : 0;

                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Query Failed: " + e.StackTrace + e.Message.ToString());

                }
                finally
                {
                    DatabaseConnectie.CloseConnection();
                }
            }
            return Check + 1;
        }

    }
}
