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

        /// <summary>
        /// Gets a single Account
        /// </summary>
        /// <returns>If record exists return a int that is not 0 or negative</returns>
        public static Account GetSingleAccount(int ID) //kun ook where (hier ID kan een variabele worden)
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

                         Account = new Account(ID, Name, Username, Password, CurrentAccount.TranslateFunction(Function));                       
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

                    cmd.CommandText = "SELECT * FROM Account Where EventID = @EventID";
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));

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
