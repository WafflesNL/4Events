using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Forms_version_1._0
{
    public static class QueryClass
    {
        public static bool Login(string Username, string Password)
        {
            bool Check = false;

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "SELECT * FROM Account WHERE Password = :Password AND Username = :Username";
                    cmd.Parameters.Add(new SqlParameter("Password", Password));
                    cmd.Parameters.Add(new SqlParameter("Username", Username));

                    //cmd.ExecuteNonQuery();             
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Check = true;
                    }
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
            return Check;

        }


    }
}
