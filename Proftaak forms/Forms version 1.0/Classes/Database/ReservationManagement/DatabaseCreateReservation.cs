using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_version_1._0.Classes;

namespace Forms_version_1._0
{
    class DatabaseCreateReservation
    {
        /// <summary>
        /// Creates a new column in the reservation table.
        /// </summary>
        /// <param name="Reservation">The reservation to be added.</param>
        /// <returns>Returns true if the reservation is added and false if it failed.</returns>
        public static bool CreateReservation(Reservation Reservation)
        {
            bool Check = false;
            int ID = DatabaseGetHighestID.GetHighestID("Reservering");

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "INSERT INTO Reservering (ID, PlaatsID, EventID, BetalingBedrag, BetalingStatus) VALUES (@ID, null, @EventID, @BetalingBedrag, @BetalingStatus)";
                    cmd.Parameters.Add(new SqlParameter("ID", Reservation.ID));
                    //cmd.Parameters.Add(new SqlParameter("PlaatsID", Reservation.Place));
                    cmd.Parameters.Add(new SqlParameter("EventID", Reservation.Event.ID));
                    cmd.Parameters.Add(new SqlParameter("BetalingBedrag", Reservation.Payment.Amount));

                    //Converts the bool to a bit for the database.
                    int paymentStatus;
                    if (Reservation.Payment.Payed)
                    {
                        paymentStatus = 1;
                    }
                    else
                    {
                        paymentStatus = 0;
                    }

                    cmd.Parameters.Add(new SqlParameter("BetalingStatus", paymentStatus));

                    cmd.ExecuteNonQuery();

                    foreach (var account in Reservation.Accounts)
                    {
                        cmd.CommandText = "INSERT INTO Account_Reservering (AccountID, ReserveringID) VALUES (@AccountID, @ReserveringID)";
                        var para1 = cmd.Parameters.Add(new SqlParameter("AccountID", account.ID));
                        var para2 = cmd.Parameters.Add(new SqlParameter("ReserveringID", Reservation.ID));

                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Remove(para1);
                        cmd.Parameters.Remove(para2);
                    }
                    

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
