﻿using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes.Database.TimelineManagement
{
    public static class DatabaseEditPost 
    {
        /// <summary>
        /// Give a like to a post
        /// </summary>   
        ///  <param name="Post">that needs to be liked</param> 
        /// <returns>true if database allows changes false if not</returns>
        public static bool LikePost(Post Post)
        {
            bool Check = false;
            int ID = DatabaseGetHighestID.GetHighestID("Post");

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "UPDATE Post SET Likes = (Likes + 1) WHERE ID = @ID";;
                    cmd.Parameters.Add(new SqlParameter("ID", Post.ID));
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

        /// <summary>
        /// Adds a report to a post
        /// </summary>   
        ///  <param name="Post">Post that needs to be Reported</param> 
        /// <returns>true if database allows changes false if not</returns>
        public static bool ReportPost(Post Post)
        {
            bool Check = false;
            int ID = DatabaseGetHighestID.GetHighestID("Post");

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "UPDATE Post SET Rapportaties = (Rapportaties + 1) WHERE ID = @ID"; ;
                    cmd.Parameters.Add(new SqlParameter("ID", Post.ID));
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
