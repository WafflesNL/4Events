using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Reservering
    {
        public Account Account { get; set; }
        public Event Event { get; set; }
        public Betaling Betaling { get; set; }
        public Plaats Plaats { get; set; }

        public Reservering(Account account, Event event1, Betaling betaling, Plaats plaats)
        {
            this.Account = account;
            this.Event = event1;
            this.Betaling = betaling;
            this.Plaats = plaats;
        }
    }
}
