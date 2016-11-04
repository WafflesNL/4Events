using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_version_1._0.Classes;

namespace Forms_version_1._0
{
    public static class DatabaseGetAccounts
    {
        /// <summary>
        /// Gets all account from the database
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
        /// <param name = "AccountFuntion" > The AccountFunction Function</param>
        /// <returns>A list of accounts</returns>
        public static List<Account> GetAccountsFunction(Function AccountFuntion)
        {
            List<Account> AccountList = new List<Account>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account WHERE Functie = @Functie";

                    cmd.Parameters.Add(new SqlParameter("Functie", AccountFuntion.ToString()));
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
        /// <param name = "ID" > The EventID int</param>
        /// <returns>If record exists return a int that is not 0 or negative</returns>
        public static Account GetSingleAccountID(int ID) 
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
        /// <param name = "EventID" > The EventID int</param>
        /// <returns>Accountlist from all users who are there at the moment</returns>
        public static List<Account> GetAccountsEventID(int EventID)
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
        /// Returns the Account in a list with the RFID. (bestemd voor het inchecken)
        /// </summary>
        /// <param name="RFID">RFID string.</param>
        /// <returns></returns>
        public static Account GetAccountRFID_Checkin(string RFID, int EventID)
        {
            Account account = null;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account a JOIN Account_Reservering ar ON a.ID = ar.AccountID JOIN Reservering r ON ar.ReserveringID = r.ID WHERE a.RFID = @RFID AND r.EventID = @EventID And BetalingStatus = 1";
                    cmd.Parameters.Add(new SqlParameter("RFID", RFID));
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Username = (reader["Gebruikersnaam"].ToString());
                        string Password = (reader["Wachtwoord"].ToString());
                        string Function = (reader["Functie"].ToString());
                        string Name = (reader["Naam"].ToString());

                        account = new Account(ID, Name, Username, Password, CurrentAccount.TranslateFunction(Function));
                    }
                    return account;
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
            return account;
        }

        /// <summary>
        /// Returns the Account in a list with the RFID. (bestemd voor het uitchecken)
        /// </summary>
        /// <param name="RFID">RFID string.</param>
        /// <returns></returns>
        public static Account GetAccountRFID_Checkuit(string RFID, int EventID)
        {
            Account account = null;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "Select * from account a where a.RFID = @RFID and a.EventID = @EventID";
                    cmd.Parameters.Add(new SqlParameter("RFID", RFID));
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Username = (reader["Gebruikersnaam"].ToString());
                        string Password = (reader["Wachtwoord"].ToString());
                        string Function = (reader["Functie"].ToString());
                        string Name = (reader["Naam"].ToString());

                        account = new Account(ID, Name, Username, Password, CurrentAccount.TranslateFunction(Function));
                    }
                    return account;
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
            return account;
        }

        /// <summary>
        /// Gets account from a gotten RFID
        /// </summary>
        /// <returns>account that has the same rfid</returns>
        public static Account GetAccountFromRFID(string RFID)
        {
            Account account = null;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account WHERE RFID = @RFID";
                    cmd.Parameters.Add(new SqlParameter("RFID", RFID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Username = (reader["Gebruikersnaam"].ToString());
                        string Password = (reader["Wachtwoord"].ToString());
                        string Function = (reader["Functie"].ToString());
                        string Name = (reader["Naam"].ToString());

                        account = new Account(ID, Name, Username, Password, CurrentAccount.TranslateFunction(Function));
                    }
                    return account;
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
            return account;
        }

        /// <summary>
        /// Get account that belong with a reservation
        /// </summary>
        /// <returns>A list of al accounts that are in a reservation</returns>
        public static List<Account> GetAccountsReservation(int ReservationID)
        {
            List<Account> AccountList = new List<Account>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "select * from Account_Reservering ar join Account a on ar.AccountID = a.ID where ar.ReserveringID = @ReservationID";
                    cmd.Parameters.Add(new SqlParameter("@ReservationID", ReservationID));

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
