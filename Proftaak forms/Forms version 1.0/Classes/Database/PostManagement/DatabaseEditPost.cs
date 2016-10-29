using Forms_version_1._0.Classes;
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
        } //Likes the selected Post

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
        } //Reports the selected Post
    }
}
