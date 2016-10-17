using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Material
    {
        public int Price { get; set; }
     
        public string Name { get; set; }

        // material stuff
        public Material(int price, string name)
        {
            this.Price = price;         
            this.Name = name;
        }
    }
}
