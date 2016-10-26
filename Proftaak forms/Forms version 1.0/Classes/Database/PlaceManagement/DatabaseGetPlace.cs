using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseGetPlace
    {
        public static Place GetPlace(int PlaceID)
        {
            Place Place = null;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Plaats Where ID = @PlaceID";
                    cmd.Parameters.Add(new SqlParameter("PlaceID", PlaceID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Terrain = (reader["Terrein"].ToString());
                        int Space = Convert.ToInt32(reader["Oppervlakte"]);
                        string Categorie = (reader["Categorie"].ToString());

                        Place = new Place(ID, Terrain, Space, CurrentAccount.TranslateCategorie(Categorie));
                        return Place;
                    }
                    return Place;
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
            return Place;
        }

        public static List<Place> GetPlacesCamping(int? CampingID)
        {
            List<Place> placeList = new List<Place>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Plaats Where CampingID = @CampingID";
                    cmd.Parameters.Add(new SqlParameter("CampingID", CampingID));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Terrain = (reader["Terrein"].ToString());
                        int Space = Convert.ToInt32(reader["Oppervlakte"]);
                        string Categorie = (reader["Categorie"].ToString());

                        Place Place = new Place(ID, Terrain, Space, CurrentAccount.TranslateCategorie(Categorie));
                        placeList.Add(Place);
                    }
                    return placeList;
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
            return placeList;
        }




    }
}
