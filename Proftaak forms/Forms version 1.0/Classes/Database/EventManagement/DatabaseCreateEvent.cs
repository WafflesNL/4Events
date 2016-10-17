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
        /// <summary>
        /// Creates a new event for the database
        /// </summary>
        /// <returns>True if Database allows the changes false if not</returns>
        public static bool CreateEvent(Event Event)
        {
            bool Check = false;
            int ID = DatabaseGetHighestID.GetHighestID("Event");

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "INSERT INTO Event (ID, Naam, Datum, Beschrijving, Locatie, Maxbezoekers, CampingID, AccountID) VALUES (@ID, @Name, @Date, @Discription, @location, @MaxVisitors, @CampingID, @AccountID)";
                    cmd.Parameters.Add(new SqlParameter("ID", ID ));
                    cmd.Parameters.Add(new SqlParameter("Name", Event.Name));
                    cmd.Parameters.Add(new SqlParameter("Date", Event.Date));
                    cmd.Parameters.Add(new SqlParameter("Discription", Event.Discription));
                    cmd.Parameters.Add(new SqlParameter("Location", Event.Location));
                    cmd.Parameters.Add(new SqlParameter("MaxVisitors", Event.MaxVisitors));
                    cmd.Parameters.Add(new SqlParameter("AccountID", Event.Account.ID));
                    if (Event.Camping == null)
                    {
                        cmd.Parameters.Add(new SqlParameter("CampingID", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("CampingID", Event.Camping.ID));
                    }                 
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
        /// Adds a camping to an event if the location of both are the same
        /// </summary>
        /// <returns>Returns a camping if this exist false if not</returns>
        public static Camping GetCamping(string Locatie)
        {
            Camping Camping = null;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Camping WHERE Locatie = @Locatie";
                    cmd.Parameters.Add(new SqlParameter("Locatie", Locatie));

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int ID = (Convert.ToInt32(reader["ID"].ToString()));
                        string Name = (reader["Naam"].ToString());
                        string Streetname = (reader["Straatnaam"].ToString());
                        string Location = (reader["Locatie"].ToString());

                        Camping = new Camping(ID, Name, Streetname, Location);
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
            return Camping;
        }


    }
}
