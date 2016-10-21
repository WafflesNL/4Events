using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseGetReservations
    {
        public static List<Reservation> GetReservation(int EventID)
        {
            List<Reservation> ReservationList = new List<Reservation>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Reservering Where EventID = @EventID";
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        int PlaceID = Convert.ToInt32(reader["PlaatsID"]);                      
                        int Amount = Convert.ToInt32(reader["BetalingsBedrag"]);
                        bool Status = Convert.ToBoolean(reader["BetalingStatus"]);


                        Place Place = DatabaseGetPlace.GetPlace(PlaceID);

                        Reservation Reservation = new Reservation(ID, new Payment(Amount, Status), Place);
                        //ReservationList.Add(Reservation);
                    }
                    return ReservationList;
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
            return ReservationList;
        }




    }
}
