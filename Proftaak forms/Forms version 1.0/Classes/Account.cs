﻿using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public class Account
    {
        public int ID { get;  set;}
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Function Function { get; set; }
        public int? EventID { get; set; } 

        /// <summary>
        /// Used to get account information from the database
        /// </summary>
        /// <param name="ID">Identidication for an account</param>
        /// <param name="name">Name of an user<param>
        /// <param name="username">Username of a user used for Authentication</param>
        /// <param name="password">Password of a user used for Authentication</param>
        /// <param name="function">Function of a user used for authorization<param> 
        /// <param name="EventID">Event that the account is currently at<param>   
        public Account(int ID, string name, string username, string password, Function function, int? EventID) 
        {
            this.ID = ID;
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Function = function;
            this.EventID = EventID;
        }

        /// <summary>
        /// Used to change account in the database
        /// </summary>
        /// <param name="ID">Identidication for an account</param>
        /// <param name="name">Name of an user<param>
        /// <param name="username">Username of a user used for Authentication</param>
        /// <param name="password">Password of a user used for Authentication</param>
        /// <param name="function">Function of a user used for authorization<param>        
        public Account(int ID, string name, string username, string password, Function function)
        {
            this.ID = ID;
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Function = function;         
        }

        /// <summary>
        /// Used to Insert a new account into the database
        /// </summary>     
        /// <param name="name">Name of an user<param>
        /// <param name="username">Username of a user used for Authentication</param>
        /// <param name="password">Password of a user used for Authentication</param>
        /// <param name="function">Function of a user used for authorization<param>  
        public Account(string name, string username, string password, Function function)
        {         
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Function = function;
        }

        /// <summary>
        /// Check if changes for account are allowed in the database
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
        public bool EditAccount(Account Account)
        {
            bool Check = DatabaseEditAccount.EditAccount(Account);
            return Check;       
        }

        /// <summary>
        /// Checks if the new account is allowed in the database
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
        public bool CreateAccount(Account Account)
        {
            bool Check = DatabaseCreateAccount.CreateAccount(Account);
            return Check;
        }

        /// <summary>
        /// Checks if the account is allowed in the database and creates it with an RFID tag.
        /// </summary>
        /// <param name="Account">A single account object</param>
        /// <param name="RFIDTag">An RFID tag from an RFID reader.</param>
        /// <returns>True if changes are allowed and false if they're not</returns>
        public bool CreateAccountWithRFID(Account Account, string RFIDTag)
        {
            bool Check = DatabaseCreateAccount.CreateAccountWithRFID(Account, RFIDTag);
            return Check;
        }


        /// <summary>
        /// Checks if the new account is allowed in the database
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
        public List<Account> GetAccountList()
        {
            List<Account> AccountList = DatabaseGetAccounts.GetAccounts();
            return AccountList;
        }    

        /// <summary>
        /// Tostring methods for Account
        /// </summary>
        /// <returns>Object account to a string</returns>
        public override string ToString()
        {
            return Username + ", " + Name + ", " + Function;
        }

    }
}
