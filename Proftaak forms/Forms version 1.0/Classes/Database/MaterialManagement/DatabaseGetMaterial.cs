using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseGetMaterial
    {
        /// <summary>
        /// Get all materials that are linked with a event
        /// </summary>
        /// <param name="EventID">EventID int</param>
        /// <returns>A list of materials that is linked with the event</returns>
        public static List<Material> GetMaterialforEvent(int EventID)
        {
            List<Material> MaterialList = new List<Material>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Materiaal WHERE EventID = @EventID";
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        int Price = Convert.ToInt32(reader["Prijs"]);
                        string Type = (reader["Type"].ToString());
                        int? eventid = (reader["EventID"] != DBNull.Value) ? Convert.ToInt32(reader["EventID"]) : 0;
                        int? accountID = (reader["AccountID"] != DBNull.Value) ? Convert.ToInt32(reader["AccountID"]) : 0;
                        if (eventid == 0)
                        {
                            eventid = null;
                        }
                        if (accountID == 0)
                        {
                            accountID = null;
                        }

                        Material Material = new Material(ID, Type, Price, eventid, accountID);
                        MaterialList.Add(Material);
                    }
                    return MaterialList;
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
            return MaterialList;
        }

        public static List<Material> GetMaterialforEventNoAccount(int EventID)
        {
            List<Material> MaterialList = new List<Material>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Materiaal WHERE EventID = @EventID AND AccountID IS NULL";
                    cmd.Parameters.Add(new SqlParameter("EventID", EventID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        int Price = Convert.ToInt32(reader["Prijs"]);
                        string Type = (reader["Type"].ToString());
                        int? eventid = (reader["EventID"] != DBNull.Value) ? Convert.ToInt32(reader["EventID"]) : 0;
                        int? accountID = (reader["AccountID"] != DBNull.Value) ? Convert.ToInt32(reader["AccountID"]) : 0;
                        if (eventid == 0)
                        {
                            eventid = null;
                        }
                        if (accountID == 0)
                        {
                            accountID = null;
                        }

                        Material Material = new Material(ID, Type, Price, eventid, accountID);
                        MaterialList.Add(Material);
                    }
                    return MaterialList;
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
            return MaterialList;
        }
        /// <summary>
        /// Gets a materials that haven't been linked to an event yet
        /// </summary>     
        /// <returns>A list of materials</returns>
        public static List<Material> GetMaterialAvailable()
        {
            List<Material> MaterialList = new List<Material>();

            if (DatabaseConnectie.OpenConnection())
            {
                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Materiaal WHERE EventID IS NULL";
                   
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        double Price = Convert.ToInt32(reader["Prijs"]);
                        string Type = (reader["Type"].ToString());
                        int? eventid = (reader["EventID"] != DBNull.Value) ? Convert.ToInt32(reader["EventID"]) : 0;
                        int? accountID = (reader["AccountID"] != DBNull.Value) ? Convert.ToInt32(reader["AccountID"]) : 0;
                        if (eventid == 0)
                        {
                            eventid = null;
                        }
                        if (accountID == 0)
                        {
                            accountID = null;
                        }
                        Price = Price / 100;

                        Material Material = new Material(ID, Type, Price, eventid, accountID);
                        MaterialList.Add(Material);
                    }
                    return MaterialList;
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
            return MaterialList;
        }


    }
}
