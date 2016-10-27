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

        public List<Post> GetAll(string naam, string woord, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetAll(naam, woord, categorie);
        }
        public List<Post> GetName(string naam)
        {
            return Filterlist = DatabaseGetPost.GetName(naam);
        }

        public List<Post> GetWord()
        {
            return null;
            // return Filterlist = DatabaseGetPost.GetWord();
        }

        public List<Post> GetCategory()
        {
            return null;
            // return Filterlist = DatabaseGetPost.GetCategory();
        }

        public List<Post> GetNameWord()
        {
            return null;
            // return Filterlist = DatabaseGetPost.GetNameWord();
        }

        public List<Post> GetNameCategory()
        {
            return null;
            // return Filterlist = DatabaseGetPost.GetNameCategory();
        }
        public List<Post> GetWordCategory()
        {
            return null;
            // return Filterlist = DatabaseGetPost.GetWordCategory();
        }
    }
}
