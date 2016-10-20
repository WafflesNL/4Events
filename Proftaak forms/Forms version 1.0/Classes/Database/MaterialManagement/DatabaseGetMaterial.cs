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
                        int eventid = Convert.ToInt32(reader["EventID"]);
                        int accountID = Convert.ToInt32(reader["AccountID"]);

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
