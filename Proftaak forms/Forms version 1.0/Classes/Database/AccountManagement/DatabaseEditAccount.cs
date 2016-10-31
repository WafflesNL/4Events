using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseEditAccount
    {
        /// <summary>
        /// Changes a account 
        /// </summary>
        /// <returns>True if Database allows the changes false if not</returns>
        public static bool EditAccount(Account Account)
        {
            bool Check = false;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "UPDATE Account SET Gebruikersnaam = @UserName, Wachtwoord = @Password, Naam = @Name, Functie = @Function WHERE ID = @ID";
                    cmd.Parameters.Add(new SqlParameter("Name", Account.Name));
                    cmd.Parameters.Add(new SqlParameter("UserName", Account.Username));
                    cmd.Parameters.Add(new SqlParameter("Password", Account.Password));
                    cmd.Parameters.Add(new SqlParameter("Function", Account.Function.ToString()));
                    cmd.Parameters.Add(new SqlParameter("ID", Account.ID));
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
        /// Adds the account to an event
        /// </summary>
        /// <returns>True if Database allows the changes false if not</returns>
        public static bool UpdateEventID(Account Account, int EventID)
        {
            bool Check = false;

            if (DatabaseConnectie.OpenConnection())
            {
                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "UPDATE Account SET EventID = @EventID WHERE Account.ID = @AccountID";
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));
                    cmd.Parameters.Add(new SqlParameter("Accountid", Account.ID));            

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
