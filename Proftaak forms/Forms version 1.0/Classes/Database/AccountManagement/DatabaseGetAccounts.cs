using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseGetAccounts
    {
        /// <summary>
        /// Changes the attributes for an Event
        /// </summary>
        /// <returns>True if Database allows the changes false if not</returns>
        public static List<Account> GetAccounts()
        {
            List<Account> AccountList = new List<Account>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                       int ID = Convert.ToInt32(reader["ID"]);
                       string Username = (reader["Gebruikersnaam"].ToString());
                       string Password = (reader["Wachtwoord"].ToString());
                       string Function = (reader["Functie"].ToString());
                       string Name = (reader["Naam"].ToString());
                       int? EventID = (reader["EventID"] != DBNull.Value) ? Convert.ToInt32(reader["EventID"]) : 0;
                       if (EventID == 0)
                       {
                           EventID = null;
                       }

                        Account Account = new Account(ID, Name, Username, Password, CurrentAccount.TranslateFunction(Function), EventID);
                       AccountList.Add(Account);
                    }
                    return AccountList;
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
            return AccountList;
        }

        /// <summary>
        /// Gets a single Account
        /// </summary>
        /// <returns>If record exists return a int that is not 0 or negative</returns>
        public static Account GetSingleAccount(int ID) 
        {
            Account Account = null;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account WHERE ID = @ID";
                    cmd.Parameters.Add(new SqlParameter("ID", ID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {                      
                        string Username = (reader["Gebruikersnaam"].ToString());
                        string Password = (reader["Wachtwoord"].ToString());
                        string Function = (reader["Functie"].ToString());
                        string Name = (reader["Naam"].ToString());
                        int? EventID = (reader["EventID"] != DBNull.Value) ? Convert.ToInt32(reader["EventID"]) : 0;
                        if (EventID == 0)
                        {
                            EventID = null;
                        }

                        Account = new Account(ID, Name, Username, Password, CurrentAccount.TranslateFunction(Function), EventID);                       
                    }
                    return Account;
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
            return Account;
        }

        /// <summary>
        /// Gets a specific account list (all accounts that are on a event)
        /// </summary>
        /// <returns>Accountlist from all users who are there at the moment</returns>
        public static List<Account> GetSpecificAccounts(int EventID)
        {
            List<Account> AccountList = new List<Account>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account Where EventID = @EventID AND Functie = 'Bezoeker'";
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Username = (reader["Gebruikersnaam"].ToString());
                        string Password = (reader["Wachtwoord"].ToString());
                        string Function = (reader["Functie"].ToString());
                        string Name = (reader["Naam"].ToString());

                        Account Account = new Account(ID, Name, Username, Password, CurrentAccount.TranslateFunction(Function), EventID);
                        AccountList.Add(Account);
                    }
                    return AccountList;
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
            return AccountList;
        }

        /// <summary>
        /// Returns the RFID string with the AccountID
        /// </summary>
        /// <param name="AccountID">The AccountID int.</param>
        /// <returns></returns>
        public static string GetSpecifiedAccountRFID(int AccountID)
        {
            string RFIDTag = "N/A";

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT RFID FROM Account Where ID = @ID AND Functie = 'Bezoeker'";
                    cmd.Parameters.Add(new SqlParameter("ID", AccountID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RFIDTag = (reader["RFID"].ToString());

                    }
                    return RFIDTag;
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
            return RFIDTag;
        }

        /// <summary>
        /// Returns the Account in a list with the RFID.
        /// </summary>
        /// <param name="RFID">RFID string.</param>
        /// <returns></returns>
        public static List<Account> GetAccountRFID(string RFID)
        {
            List<Account> AccountList = new List<Account>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account Where RFID = @RFID AND Functie = 'Bezoeker'";
                    cmd.Parameters.Add(new SqlParameter("RFID", RFID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Username = (reader["Gebruikersnaam"].ToString());
                        string Password = (reader["Wachtwoord"].ToString());
                        string Function = (reader["Functie"].ToString());
                        string Name = (reader["Naam"].ToString());

                        Account Account = new Account(ID, Name, Username, Password, CurrentAccount.TranslateFunction(Function));
                        AccountList.Add(Account);
                    }
                    return AccountList;
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
            return AccountList;
        }




    }
}
