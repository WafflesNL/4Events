using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Materiaal
    {
        public int Price { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public Materiaal(int price, int amount, string name)
        {
            this.Price = price;
            this.Amount = amount;
            this.Name = name;
        }
    }
}
