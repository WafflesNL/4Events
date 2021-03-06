﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseCreateAccount
    {
        /// <summary>
        /// Creates an account
        /// </summary>
        /// <param name="Account">Account that has to be created</param>
        /// <returns>True if Database allows the changes false if not</returns>
        public static bool CreateAccount(Account Account)
        {
            bool Check = false;
            int ID = DatabaseGetHighestID.GetHighestID("Account");

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "INSERT INTO Account (ID, Gebruikersnaam, Wachtwoord, Functie, Naam) VALUES (@ID, @UserName, @Password, @Function, @Name)";
                    cmd.Parameters.Add(new SqlParameter("Name", Account.Name));
                    cmd.Parameters.Add(new SqlParameter("UserName", Account.Username));
                    cmd.Parameters.Add(new SqlParameter("Password", Account.Password));
                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("Function", Account.Function.ToString()));                  

                    cmd.ExecuteNonQuery();

                    Check = true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Query Failed: " + e.StackTrace + e.Message.ToString());
                    Check = false;
                }
                finally
                {
                    DatabaseConnectie.CloseConnection();
                }
            }

            return Check;
        }

        /// <summary>
        /// Creates an account with RFID attached
        /// </summary>
        /// <param name="RFIDTag">Tag that has to be added to the account</param>
        /// <param name="Acccount">Account that has to be created</param>
        /// <returns>True if Database allows the changes false if not</returns>
        public static bool CreateAccountWithRFID(Account Account, string RFIDTag)
        {
            bool Check = false;
            int ID = DatabaseGetHighestID.GetHighestID("Account");

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "INSERT INTO Account (ID, Gebruikersnaam, Wachtwoord, Functie, Naam, RFID) VALUES (@ID, @UserName, @Password, @Function, @Name, @RFID)";
                    cmd.Parameters.Add(new SqlParameter("Name", Account.Name));
                    cmd.Parameters.Add(new SqlParameter("UserName", Account.Username));
                    cmd.Parameters.Add(new SqlParameter("Password", Account.Password));
                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("Function", Account.Function.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@RFID", RFIDTag));

                    cmd.ExecuteNonQuery();

                    Check = true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Query Failed: " + e.StackTrace + e.Message.ToString());
                    Check = false;
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
