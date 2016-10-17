using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Material
    {
        string type;
        public string Type { get; }

        public int Price { get; set; }
     
        public string Name { get; set; }

        public Material(int price, string name)
        {
            this.Price = price;         
            this.Name = name;
        }

        public void GetAccount()
        {

        }

        public void Rent()

        {

        }

        public void Add()
        {

        }

        public int CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }
}
