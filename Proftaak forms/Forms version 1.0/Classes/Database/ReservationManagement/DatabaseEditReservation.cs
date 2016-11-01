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
        public static bool EditReservation(Reservation Reservation)
        {
            if (DatabaseConnectie.OpenConnection())
            {

                DatabaseConnectie.OpenConnection();

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "";
                   // cmd.Parameters.Add(new SqlParameter("ID", Reservation.ID));
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
            return true;
        }






    }
}
