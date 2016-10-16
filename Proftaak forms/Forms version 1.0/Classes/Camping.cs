using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Camping
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Streetname { get; set; }
        public string Location { get; set; }

        public Camping(int? ID, string Name, string Streetname, string Location)
        {
            this.ID = ID;
            this.Name = Name;
            this.Streetname = Streetname;
            this.Location = Location;
        }

        public void GetPlaces()
        {

        }
    }
}
