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

     
        public Account(int ID, string name, string username, string password, Function function) //Second constructer 
        {
            this.ID = ID;
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Function = function;
        }

        public Account(string name, string username, string password, Function function) //Second constructer 
        {         
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Function = function;
        }


        public bool EditAccount(Account Account)
        {
            bool Check = DatabaseEditAccount.EditAccount(Account);
            return Check;       
        }

        public bool CreateAccount(Account Account)
        {
            bool Check = DatabaseCreateAccount.CreateAccount(Account);
            return Check;
        }

        public int GetHighestAccountID()
        {

            //wordt aan gewerkt
            return 0;
        }

        public List<Account> GetAccountList()
        {
            List<Account> AccountList = DatabaseGetAccounts.GetAccounts();
            return AccountList;
        }

        public override string ToString()
        {
            return Username + ", " + Password + ", " + Name + ", " + Function;
        }
    }
}
