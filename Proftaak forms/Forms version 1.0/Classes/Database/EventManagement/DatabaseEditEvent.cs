﻿using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseEditEvent
    {
        /// <summary>
        /// Changes the attributes for an Event
        /// </summary>
        /// <param name="Event">Event that has to be edited</param>
        /// <returns>True if Database allows the changes false if not</returns>
        public static bool EditEvent(Event Event)
        {
            bool Check = false;

            if (DatabaseConnectie.OpenConnection())
            {
                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "UPDATE Event SET Naam = @Name, Datum = @Date, Beschrijving = @Description, Locatie = @Location WHERE ID = @ID";
                    cmd.Parameters.Add(new SqlParameter("ID", Event.ID));
                    cmd.Parameters.Add(new SqlParameter("Name", Event.Name));
                    cmd.Parameters.Add(new SqlParameter("Date", Event.Date));
                    cmd.Parameters.Add(new SqlParameter("Description", Event.Description));
                    cmd.Parameters.Add(new SqlParameter("Location", Event.Location));

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



    }
}
