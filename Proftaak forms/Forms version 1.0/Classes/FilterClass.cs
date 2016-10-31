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
        }//Searches based on 3 different parameters

        public List<Post> GetName(string naam)
        {
            return Filterlist = DatabaseGetPost.GetName(naam);
        }//Searches based on Name

        public List<Post> GetWord(string woord)
        {
            return Filterlist = DatabaseGetPost.GetWord(woord);
        }//Searches based on Keyword

        public List<Post> GetCategory(string categorie)
        {
            return Filterlist = DatabaseGetPost.GetCategory(categorie);
        }//Searches based on Category

        public List<Post> GetNameWord(string naam, string woord)
        {
            return Filterlist = DatabaseGetPost.GetNameWord(naam, woord);
        }//Searches based on Name and Keyword

        public List<Post> GetNameCategory(string naam, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetNameCategory(naam, categorie);
        }//Searches based on Name and Category

        public List<Post> GetWordCategory(string woord, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetWordCategory(woord, categorie);
        }//Searches based on Keyword and Category
    }
}
