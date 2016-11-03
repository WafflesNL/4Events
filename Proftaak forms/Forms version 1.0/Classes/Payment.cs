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

        /// <summary>
        /// Costructur for payment
        /// </summary>
        /// <param name="Amount">Amount that needs to be paid</param>
        /// <param name="Paid">if reservation is paid or not<param>

        public Payment(int amount, bool Paid)
        {        
            this.Amount = amount;
            this.Paid = Paid;
        }
    }
}
