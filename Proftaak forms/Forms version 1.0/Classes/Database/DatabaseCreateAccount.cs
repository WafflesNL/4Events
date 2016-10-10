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
        public static bool CreateAccount(Account Account)
        {
            bool Check = false;
            int ID = GetHighestID();

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


        private static int GetHighestID()
        {
            int Check = 0;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT MAX(ID) AS Max FROM Account";                 
                
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Check = Convert.ToInt32(reader["Max"]);                   
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
