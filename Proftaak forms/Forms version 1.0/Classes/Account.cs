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
        public int EventID { get; set; } //moet nog toegepast worden in methodes

        /// <summary>
        /// Used to get account information from the database
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
            return Username + ", " + Password + ", " + Name + ", " + Function;
        }
    }
}
