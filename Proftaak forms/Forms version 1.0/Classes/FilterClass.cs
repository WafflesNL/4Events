using Forms_version_1._0.Classes.Database.TimelineManagement;
using Forms_version_1._0.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class FilterClass
    {
        public List<Post> Filterlist = new List<Post>();
        public FilterClass()
        {
                    
        }

        //The Methods fitting to the Search Functions in Filter
        public List<Post> GetAll(string naam, string woord, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetAll(naam, woord, categorie);
        }
        public List<Post> GetName(string naam)
        {
            return Filterlist = DatabaseGetPost.GetName(naam);
        }

        public List<Post> GetWord(string woord)
        {
            return Filterlist = DatabaseGetPost.GetWord(woord);
        }

        public List<Post> GetCategory(string categorie)
        {
            return Filterlist = DatabaseGetPost.GetCategory(categorie);
        }

        public List<Post> GetNameWord(string naam, string woord)
        {
            return Filterlist = DatabaseGetPost.GetNameWord(naam, woord);
        }

        public List<Post> GetNameCategory(string naam, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetNameCategory(naam, categorie);
        }
        public List<Post> GetWordCategory(string woord, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetWordCategory(woord, categorie);
        }
    }
}
