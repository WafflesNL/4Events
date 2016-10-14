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









    }
}
