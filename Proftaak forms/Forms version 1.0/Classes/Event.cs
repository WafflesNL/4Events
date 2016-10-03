using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Event
    {
        public List<Materiaal> Materiaallist = new List<Materiaal>();
        public Account Account { get; set; }
        public Tijdlijn Tijdlijn { get; set; }
        public string Naam { get; set; }
        public List<Reservering> Reserveringslist = new List<Reservering>();
        public Event(List<Reservering> reserveringslist, Account account, List<Materiaal> materiaallist)
        {
            this.Reserveringslist = reserveringslist;
            this.Account = account;
            this.Materiaallist = materiaallist;

        }

        public void EditEvent()
        {
            
        }
    }
}
