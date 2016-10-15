using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Betaling
    {
        public int Amount { get; set; }
        public Reservation Reservering { get; set; }
        public Betaling(Reservation reservering, int amount)
        {
            this.Reservering = reservering;
            this.Amount = amount;
        }
    }
}
