using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseGetEvents
    {
        /// <summary>
        /// Gets every event from the database
        /// </summary>
        /// <returns>A list with all event</returns>
        public static List<Event> GetEvents()
        {
            List<Event> EventList = new List<Event>();
        
            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Event";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Name = (reader["Naam"].ToString());
                        DateTime Date = Convert.ToDateTime(reader["Datum"]);
                        string Discription = (reader["Beschrijving"].ToString());
                        string Location = (reader["Locatie"].ToString());
                        int Maxvisitors = Convert.ToInt32(reader["Maxbezoekers"]);
                        int CampingID = (reader["CampingID"] != DBNull.Value) ? Convert.ToInt32(reader["CampingID"]) : 0;
                        int AccountID = Convert.ToInt32(reader["AccountID"]);
                     
                        List<Reservation> ReservationList = DatabaseGetReservations.GetReservation(ID);                       
                        TimeLine Timeline = DatabaseGetTimeLine.GetTimeline(ID);

                        Account Account = DatabaseGetAccounts.GetSingleAccountID(AccountID); 
                        Camping Camping;

                        if (CampingID != 0)
                        {
                            Camping = DatabaseGetCamping.GetSingleCamping(CampingID);
                        }
                        else
                        {
                            Camping = null;
                        }

                        Event Event = new Event(ID, Name, Discription, Location, Maxvisitors, Date, Account, Camping, ReservationList, Timeline);
                        EventList.Add(Event);                 
                    }
                    return EventList;
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
            return EventList;
        }



    }
}
