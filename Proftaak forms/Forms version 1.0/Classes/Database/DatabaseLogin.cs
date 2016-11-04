using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Forms_version_1._0
{
    public static class DatabaseLogin
    {
        /// <summary>
        /// Check if a user exist in the database
        /// </summary>
        /// <param name="Password">Currently submitted password</param> 
        /// <param name="Username">Currently submitted Username</param> 
        /// <returns>If record exists return a int that is not 0 or negative</returns>
        public static int CheckUser(string Password, string Username)
        {
            int Check = 0;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account WHERE Wachtwoord = @Password AND GebruikersNaam = @UserName";
                    cmd.Parameters.Add(new SqlParameter("Password", Password));
                    cmd.Parameters.Add(new SqlParameter("UserName", Username));

                    //cmd.ExecuteNonQuery();             
                    //OracleDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Check = Convert.ToInt32(reader["ID"]);
                        return Check;
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
            return Check;
        }

        /// <summary>
        ///  Get string that is requested
        /// </summary>
        ///  <param name="ID">ID from account integer</param> 
        ///  <param name="Data">Data you want to get string</param> 
        /// <returns>A string</returns>
        public static string GetString(int ID, string Data)
        {
            string Check = "";

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account WHERE ID = @ID";
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                  
                    //cmd.ExecuteNonQuery();             
                    //OracleDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Check = (reader[Data].ToString());
                        return Check;
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
            return Check;
        }

        /// <summary>
        ///  Get int that is requested
        /// </summary>
        /// <param name="ID">ID from account integer</param> 
        ///  <param name="Data">Data you want to get string</param> 
        /// <returns>A string</returns>
        public static int? GetInt(int ID, string Data)
        {
            int? Check = 0;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account WHERE ID = @ID";
                    cmd.Parameters.Add(new SqlParameter("ID", ID));

                    //cmd.ExecuteNonQuery();             
                    //OracleDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Check = (reader[Data] != DBNull.Value) ? Convert.ToInt32(reader[Data]) : 0;     //convert to null                  
                        return Check;
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
            return Check;
        }



    }
}
