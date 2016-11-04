using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseEditReservation
    {
        /// <summary>
        /// Changes the Status of the payment to true
        /// </summary>
        /// <param name="ReservationID">ReservationID integer</param> 
        /// <returns>True if Database allows the changes false if not</returns>     
        public static bool ChangePayment(int ReservationID)
        {
            DatabaseConnectie.OpenConnection();

            try
            {
                DatabaseConnectie.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DatabaseConnectie.connect;

                cmd.CommandText = "UPDATE Reservering SET BetalingStatus = 1 WHERE ID = @ID";
                cmd.Parameters.Add(new SqlParameter("ID", ReservationID));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Query Failed: " + e.StackTrace + e.Message.ToString());
                return false;
            }
            finally
            {
                DatabaseConnectie.CloseConnection();
            }

        }




    }
}
