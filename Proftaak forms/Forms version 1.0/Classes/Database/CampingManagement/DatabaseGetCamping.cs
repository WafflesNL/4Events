using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseGetCamping
    {
        /// <summary>
        /// Gets a camping from the database (the ID is a Foreign key from another table)
        /// </summary>
        /// <returns>Gets a camping that exists in the database null if not</returns>
        public static Camping GetSingleCamping(int ID)
        {
            Camping Camping = null;

            if (DatabaseConnectie.OpenConnection())
            {
                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Camping WHERE ID = @ID";
                    cmd.Parameters.Add(new SqlParameter("ID", ID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {                   
                        string Name = (reader["Naam"].ToString());
                        string Streetname = (reader["Straatnaam"].ToString());
                        string Location = (reader["Locatie"].ToString());

                        Camping = new Camping(ID, Name, Streetname, Location);
                    }
                    return Camping;
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
