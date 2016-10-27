using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes.Database.TimelineManagement
{
    public static class DatabaseGetPost
    {
        public static List<Post> GetPost()
        {
            List<Post> Postlist = new List<Post>();
            byte[] File;
            string Attachment;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Post";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        int TimelineID = Convert.ToInt32(reader["TijdlijnID"]);
                        int AccountID = Convert.ToInt32(reader["AccountID"]);
                        string PostID = (reader["PostID"].ToString());
                        string Category = (reader["Categorie"].ToString());
                        string Text = (reader["Tekstinhoud"].ToString());
                        DateTime Date = Convert.ToDateTime(reader["Datum"]);
                        int Likes = Convert.ToInt32(reader["Likes"]);
                        int Reports = Convert.ToInt32(reader["Rapportaties"]);
                        bool Readable = (Convert.ToBoolean(reader["Leesbaar"]));
                        if (reader["Bestand"] != DBNull.Value)
                        {
                            Attachment = "Bijlage";
                            File = (byte[])reader["Bestand"];
                        }
                        else
                        {
                            Attachment = null;
                            File = null;
                        }

                        Account Account = DatabaseGetAccounts.GetSingleAccountID(AccountID);

                        Post GottenPost = new Post(Text, Category, AccountID, TimelineID, Likes, Account, File, Attachment);
                        Postlist.Add(GottenPost);
                    }
                    return Postlist;
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
            return Postlist;
        }

        public static List<Post> GetSafePost()
        {
            List<Post> Postlist = new List<Post>();
            byte[] File;
            string Attachment;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Post WHERE Rapportaties < 5";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        int TimelineID = Convert.ToInt32(reader["TijdlijnID"]);
                        int AccountID = Convert.ToInt32(reader["AccountID"]);
                        string PostID = (reader["PostID"].ToString());
                        string Category = (reader["Categorie"].ToString());
                        string Text = (reader["Tekstinhoud"].ToString());
                        DateTime Date = Convert.ToDateTime(reader["Datum"]);
                        int Likes = Convert.ToInt32(reader["Likes"]);
                        int Reports = Convert.ToInt32(reader["Rapportaties"]);
                        bool Readable = (Convert.ToBoolean(reader["Leesbaar"]));
                        if (reader["Bestand"] != DBNull.Value)
                        {
                            Attachment = "Bijlage";
                            File = (byte[])reader["Bestand"];
                        }
                        else
                        {
                            Attachment = null;
                            File = null;
                        }

                        Account Account = DatabaseGetAccounts.GetSingleAccountID(AccountID);

                        Post GottenPost = new Post(Text, Category, AccountID, TimelineID, Likes, Account, File, Attachment);
                        Postlist.Add(GottenPost);
                    }
                    return Postlist;
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
            return Postlist;
        }

        public static List<Post> GetAll(string Fnaam, string Fwoord, string Fcat)
        {
            List<Post> Postlist = new List<Post>();
            byte[] File;
            string Attachment;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT p.Categorie, p.AccountID, p.TijdlijnID, p.Tekstinhoud, p.Likes, a.Naam, p.Bestand FROM Post p, Account a WHERE p.AccountID = a.ID AND a.Naam = "+ "'" + Fnaam + "'" + " AND p.Tekstinhoud LIKE " + "'%" +  Fwoord + "%'" + "AND p.Categorie = " + "'" + Fcat + "'" + ";";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //int ID = Convert.ToInt32(reader["ID"]);
                        int TimelineID = Convert.ToInt32(reader["TijdlijnID"]);
                        int AccountID = Convert.ToInt32(reader["AccountID"]);
                        //string PostID = (reader["PostID"].ToString());
                        string Category = (reader["Categorie"].ToString());
                        string Text = (reader["Tekstinhoud"].ToString());
                        //DateTime Date = Convert.ToDateTime(reader["Datum"]);
                        int Likes = Convert.ToInt32(reader["Likes"]);
                        //int Reports = Convert.ToInt32(reader["Rapportaties"]);
                        //bool Readable = (Convert.ToBoolean(reader["Leesbaar"]));
                        if (reader["Bestand"] != DBNull.Value)
                        {
                            Attachment = "Bijlage";
                            File = (byte[])reader["Bestand"];
                        }
                        else
                        {
                            Attachment = null;
                            File = null;
                        }

                        Account Account = DatabaseGetAccounts.GetSingleAccountID(AccountID);

                        Post GottenPost = new Post(Text, Category, AccountID, TimelineID, Likes, Account, File, Attachment);
                        Postlist.Add(GottenPost);
                    }
                    return Postlist;
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
            return Postlist;
        }

        public static List<Post> GetName(string Fnaam)
        {
            List<Post> Postlist = new List<Post>();
            byte[] File;
            string Attachment;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT p.Categorie, p.AccountID, p.TijdlijnID, p.Tekstinhoud, p.Likes, a.Naam, p.Bestand FROM Post p, Account a WHERE p.AccountID = a.ID AND a.Naam = " + "'" + Fnaam + ";";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //int ID = Convert.ToInt32(reader["ID"]);
                        int TimelineID = Convert.ToInt32(reader["TijdlijnID"]);
                        int AccountID = Convert.ToInt32(reader["AccountID"]);
                        //string PostID = (reader["PostID"].ToString());
                        string Category = (reader["Categorie"].ToString());
                        string Text = (reader["Tekstinhoud"].ToString());
                        //DateTime Date = Convert.ToDateTime(reader["Datum"]);
                        int Likes = Convert.ToInt32(reader["Likes"]);
                        //int Reports = Convert.ToInt32(reader["Rapportaties"]);
                        //bool Readable = (Convert.ToBoolean(reader["Leesbaar"]));
                        if (reader["Bestand"] != DBNull.Value)
                        {
                            Attachment = "Bijlage";
                            File = (byte[])reader["Bestand"];
                        }
                        else
                        {
                            Attachment = null;
                            File = null;
                        }

                        Account Account = DatabaseGetAccounts.GetSingleAccountID(AccountID);

                        Post GottenPost = new Post(Text, Category, AccountID, TimelineID, Likes, Account, File, Attachment);
                        Postlist.Add(GottenPost);
                    }
                    return Postlist;
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
            return Postlist;
        }
    }
}
