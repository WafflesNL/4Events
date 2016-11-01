using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes.Database.TimelineManagement
{
    public static class DatabaseAddPost
    {
        /// <summary>
        /// Adds a post to the timeline
        /// </summary>      
        /// <returns>true if database allows changes false if not</returns>
        public static bool AddPost(Post Post)
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

                    if (Post.File == null)
                    {
                        cmd.CommandText = "INSERT INTO Post (ID, Tekstinhoud, Datum, Categorie, TijdlijnID, AccountID) VALUES (@ID, @Text, @Date, @Category, @TimelineID, @AccountID)";
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO Post (ID, Tekstinhoud, Datum, Categorie, TijdlijnID, AccountID, Bestand) VALUES (@ID, @Text, @Date, @Category, @TimelineID, @AccountID, @File)";
                        cmd.Parameters.Add(new SqlParameter("File", Post.File));
                    }                
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                    cmd.Parameters.Add(new SqlParameter("Text", Post.Text));
                    cmd.Parameters.Add(new SqlParameter("Date", System.DateTime.Now));
                    cmd.Parameters.Add(new SqlParameter("Category", Post.Category));
                    cmd.Parameters.Add(new SqlParameter("TimelineID", Post.TimeLineID));
                    cmd.Parameters.Add(new SqlParameter("AccountID", Post.AccountID));
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
        } //Adding the gottenpost from the business layer to the database

        /// <summary>
        /// Adds a reaction to posts
        /// </summary>   
        /// <returns>true if database allows changes false if not</returns>
        public static bool AddReaction(Post Post)
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

                    if (Post.File == null)
                    {
                        cmd.CommandText = "INSERT INTO Post (ID, Tekstinhoud, postID, Datum, Categorie, TijdlijnID, AccountID) VALUES (@ID, @Text, @PostID, @Date, @Category, @TimelineID, @AccountID)";
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO Post (ID, Tekstinhoud, postID, Datum, Categorie, TijdlijnID, AccountID, Bestand) VALUES (@ID, @Text, @PostID, @Date, @Category, @TimelineID, @AccountID, @File)";
                        cmd.Parameters.Add(new SqlParameter("File", Post.File));
                    }
                    cmd.Parameters.Add(new SqlParameter("ID", ID));
                    cmd.Parameters.Add(new SqlParameter("Text", Post.Text));
                    cmd.Parameters.Add(new SqlParameter("postID", Post.PostID));
                    cmd.Parameters.Add(new SqlParameter("Date", System.DateTime.Now));
                    cmd.Parameters.Add(new SqlParameter("Category", Post.Category));
                    cmd.Parameters.Add(new SqlParameter("TimelineID", Post.TimeLineID));
                    cmd.Parameters.Add(new SqlParameter("AccountID", Post.AccountID));
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
        } //Adding the gottenpost from the business layer to the database
    }
}
