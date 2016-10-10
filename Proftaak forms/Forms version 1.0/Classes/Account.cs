using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0
{
    public class Account
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Function Function { get; set; }

        public Account(string name, string username, string password, Function function)
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


    }
}
