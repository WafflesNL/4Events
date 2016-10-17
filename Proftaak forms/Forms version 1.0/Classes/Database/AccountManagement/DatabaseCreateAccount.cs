using System;
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


    }
}
