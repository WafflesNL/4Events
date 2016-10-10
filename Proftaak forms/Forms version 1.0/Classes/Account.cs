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

        public Account(string name, string username, string password)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }

  
        public void EditAccount(string Name, string Username, string Password)
        {
           //account has to be changed here
        }


    }
}
