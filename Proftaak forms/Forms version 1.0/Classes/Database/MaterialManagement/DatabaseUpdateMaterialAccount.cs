﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes.Database.MaterialManagement
{
        public static class DatabaseUpdateAccountMaterial
        {
            public static void UpdateMaterial(List<Material> MaterialList, int AccountID)
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

                            cmd.CommandText = "UPDATE Materiaal SET AccountID = @AccountID WHERE ID = @ID";
                            cmd.Parameters.Add(new SqlParameter("ID", M.ID));
                            cmd.Parameters.Add(new SqlParameter("AccountID", AccountID));

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

