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

        public Account(string name, string username, string password)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }

        public void Login(string Username, string Password)
        {
            QueryClass.Login(Username, Password);         
        }

        public void EditAccount(string Name, string Username, string Password)
        {
           this.Name = Name;
           this.Username = Username;
           this.Password = Username;  
            //Database Alter Table goes here         
        }


    }
}
