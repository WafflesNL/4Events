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
        /// <summary>
        /// asign all selected materials to an event
        /// </summary>
        /// <param name="MaterialList">List of materials</param>
        /// <param name="EventID">EventID integer</param>
        /// <returns>true if database allows changes false if not</returns>
        public static bool UpdateMaterial(List<Material> MaterialList, int EventID)
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

                        return true;
                    }
                    catch (SqlException e)
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
            return true;

        }

        /// <summary>
        /// Sets selected items to an event
        /// </summary>
        /// <param name="EventID">EventID int</param>
        /// <param name="MaterialList">All materials that get set to an account</param>
        /// <returns>true if database allows changes false if not</returns>
        public static bool UpdateAccount(List<Material> MaterialList, int? AccountID)
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

                        

                        if (AccountID == null)
                        {
                            cmd.CommandText = "UPDATE Materiaal SET AccountID = NULL WHERE ID = @ID";
                            cmd.Parameters.Add(new SqlParameter("ID", M.ID));
                        }
                        else
                        {
                            cmd.CommandText = "UPDATE Materiaal SET AccountID = @AccountID WHERE ID = @ID";
                            cmd.Parameters.Add(new SqlParameter("ID", M.ID));
                            cmd.Parameters.Add(new SqlParameter("AccountID", AccountID));
                        }
                        
                        

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (SqlException e)
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
            return true;

        }
    }
}
