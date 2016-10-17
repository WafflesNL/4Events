using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Reservation
    {
        public Account Account { get; set; }
        public Event Event { get; set; }
        public Betaling Betaling { get; set; }
        public Plaats Plaats { get; set; }

        public Reservation()
        {
            this.Account = Account;
            this.Event = Event;
            this.Betaling = Betaling;
            this.Plaats = Plaats;
        }
    }
}
