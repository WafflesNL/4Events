using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseCreateTimeline
    {
        public static bool CreateTimeline()
        {
            bool Check = false;
            int ID = DatabaseGetHighestID.GetHighestID("Tijdlijn");
            int EventID = GetLatestEventID();

            if (DatabaseConnectie.OpenConnection())
            {                
                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "INSERT INTO Tijdlijn (ID, EventID) VALUES (@ID, @EventID)";
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));

                    if (EventID > 0)
                    {
                        cmd.ExecuteNonQuery();
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


        private static int GetLatestEventID()
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
            return Check;
        }


    }
}
