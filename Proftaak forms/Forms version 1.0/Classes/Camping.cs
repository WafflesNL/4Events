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

        /// <summary>
        /// Camping used to get a camping from the database
        /// </summary>
        /// <param name="ID">Identidication for an camping</param>
        /// <param name="Name">Name of an camping<param>
        /// <param name="Streetname">Name of the street where the camping is established</param>
        /// <param name="Location">Name of the village or city where the camping is established</param>       
        public Camping(int? ID, string Name, string Streetname, string Location)
        {
            this.ID = ID;
            this.Name = Name;
            this.Streetname = Streetname;
            this.Location = Location;
        }

        /// <summary>
        /// Sends a database request to get all places
        /// </summary>
        /// <returns>Returns all places in the Camping as a List<Place></returns>
        public List<Place> GetPlaces()
        {
            List<Place> placeList = DatabaseGetPlace.GetPlacesCamping(ID);
            return placeList;
        }
    }
}
