﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public static class DatabaseGetAccounts
    {
        public static List<Account> GetAccounts()
        {
            List<Account> AccountList = new List<Account>();

            if (DatabaseConnectie.OpenConnection())
            {

                try
                {
                    DatabaseConnectie.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DatabaseConnectie.connect;

                    cmd.CommandText = "";
                    //cmd.Parameters.Add(new SqlParameter("Password", Password));
                    //cmd.Parameters.Add(new SqlParameter("UserName", Username));

                    //cmd.ExecuteNonQuery();             
                    //OracleDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                       //Check = Convert.ToInt32(reader["ID"]);//
                       // Account Account = new Account();
                       // AccountList.Add(Account);
                    }
                    return AccountList;
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
            return AccountList;
        }









    }
}
