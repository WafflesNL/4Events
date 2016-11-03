using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Payment 
    {
        public int Amount { get; set; }
        public bool Paid { get; set; }    

        public Payment(int amount, bool Paid)
        {        
            this.Amount = amount;
            this.Paid = Paid;
        }
    }
}
