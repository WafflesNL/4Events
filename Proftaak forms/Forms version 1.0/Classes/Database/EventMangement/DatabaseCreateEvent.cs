using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseCreateEvent
    {
        public static bool CreateEvent(Event Event)
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

                    cmd.CommandText = "INSERT INTO Event (ID, Naam, Datum, Beschrijving, Locatie, AccountID) VALUES (@ID, @Name, @Date, @Discription, @location, @AccountID)";
                    cmd.Parameters.Add(new SqlParameter("ID", ID ));
                    cmd.Parameters.Add(new SqlParameter("Name", Event.Name));
                    cmd.Parameters.Add(new SqlParameter("Date", Event.Date));
                    cmd.Parameters.Add(new SqlParameter("Discription", Event.Discription));
                    cmd.Parameters.Add(new SqlParameter("Location", Event.Location));
                    cmd.Parameters.Add(new SqlParameter("AccountID", Event.Account.ID));
                    
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

                    cmd.CommandText = "SELECT MAX(ID) AS Max FROM Event";
                    
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
