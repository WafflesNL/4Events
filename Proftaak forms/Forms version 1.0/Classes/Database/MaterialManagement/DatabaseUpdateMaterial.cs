using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseUpdateMaterial
    {
        public static void UpdateMaterial(List<Material> MaterialList, int EventID)
        {
            foreach (Material M in MaterialList)
            {
                if (DatabaseConnectie.OpenConnection())
                {
                    try
                    {
                        DatabaseConnectie.OpenConnection();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = DatabaseConnectie.connect;

                        cmd.CommandText = "UPDATE Materiaal SET EventID = @EventID WHERE ID = @ID";
                        cmd.Parameters.Add(new SqlParameter("ID", M.ID));
                        cmd.Parameters.Add(new SqlParameter("EventID", EventID));

                        cmd.ExecuteNonQuery();

                        
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
            }
        
        }
    }
}
