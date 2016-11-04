using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Place
    {
        public int ID { get; set; }
        public string Terrain { get; set; }
        public int Space { get; set; }
        public Categorie Categorie { get; set; }

        /// <summary>
        /// Creates a new Place object
        /// </summary>
        /// <param name="ID">The place id</param>
        /// <param name="Terrain"></param>
        /// <param name="Space"></param>
        /// <param name="Categorie"></param>
        public Place(int ID, string Terrain, int Space, Categorie Categorie)
        {
            this.ID = ID;
            this.Terrain = Terrain;
            this.Space = Space;
            this.Categorie = Categorie;
        }
    }
}
