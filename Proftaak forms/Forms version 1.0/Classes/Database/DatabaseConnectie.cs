using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Forms_version_1._0
{
    public static class DatabaseConnectie
    {
        public static SqlConnection connect { get; set; } //database static


        /// <summary>
        /// Check if database connection is open
        /// </summary>
        /// <returns>True if open false if closed</returns>
        public static bool OpenConnection()
        {
            connect = new SqlConnection();

            try
            {
                connect.ConnectionString = "Connection string"; //working connection

                connect.Open();
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }
            if (connect.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Close database connection
        /// </summary>
        /// <returns>True if connection is closed false if not</returns>
        public static void CloseConnection()
        {
            connect.Close();
        }
    }
}
