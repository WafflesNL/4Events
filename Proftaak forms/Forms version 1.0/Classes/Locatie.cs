using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Locatie
    {
        public string Name { get; set; }
        public string Zipcode { get; set; }
        public string Streetname { get; set; }
        public int Capacity { get; set; }
        List<Account> Accountlist = new List<Account>();
        public string Eventname { get; set; }

        public Locatie(string name, string zipcode, string streetname, int capacity)
        {
            this.Name = name;
            this.Zipcode = zipcode;
            this.Streetname = streetname;
            this.Capacity = capacity;
        }

        public void AddAccount(Account Account)
        {

        }
    }
}
