using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    class DatabaseGetAccountReservering
    {
        /// <summary>
        /// returns amount of people in a reservation
        /// </summary>
        /// <param name="Reservation">reservation</param>
        /// <returns>gets amount of all people in a reservation</returns>
        public static int GetReservationAmountReservation(Reservation Reservation)
        {
            int reservationCount = 0;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT COUNT(AccountID) As count FROM Account_Reservering WHERE ReserveringID = @ReserveringID";
                    cmd.Parameters.Add(new SqlParameter("ReserveringID", Reservation.ID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        reservationCount = Convert.ToInt32(reader["count"]);
                    }
                    return reservationCount;
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
            return reservationCount;
        }
    }
}
