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
        /// <summary>
        /// Constructor used in FilterForm
        /// </summary>
        public FilterClass()
        {
                    
        }

        /// <summary>
        /// Filters posts on 3 parameters
        /// </summary>
        /// <param name="naam">The name entered in the Searchbox<param>
        /// <param name="woord">The text entered in the Searchbox</param>
        /// <param name="categorie">The category selected in the comboSearchbox</param> 
        /// <returns>A list of posts which match the criteria</returns>
        public List<Post> GetAll(string naam, string woord, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetAll(naam, woord, categorie);
        }

        /// <summary>
        /// Filters posts on name
        /// </summary>
        /// <param name="naam">The name entered in the Searchbox<param>
        /// <returns>A list of posts which match the criteria</returns>
        public List<Post> GetName(string naam)
        {
            return Filterlist = DatabaseGetPost.GetName(naam);
        }

        /// <summary>
        /// Filters posts on words in the text
        /// </summary>
        /// <param name="woord">The text entered in the Searchbox</param>
        /// <returns>A list of posts which match the criteria</returns>
        public List<Post> GetWord(string woord)
        {
            return Filterlist = DatabaseGetPost.GetWord(woord);
        }

        /// <summary>
        /// Filters posts on the selected category
        /// </summary>
        /// <param name="categorie">The category selected in the comboSearchbox</param> 
        /// <returns>A list of posts which match the criteria</returns>
        public List<Post> GetCategory(string categorie)
        {
            return Filterlist = DatabaseGetPost.GetCategory(categorie);
        }

        /// <summary>
        /// Filters posts on name and words in the text
        /// </summary>
        /// <param name="naam">The name entered in the Searchbox<param>
        /// <param name="woord">The text entered in the Searchbox</param>
        /// <returns>A list of posts which match the criteria</returns>
        public List<Post> GetNameWord(string naam, string woord)
        {
            return Filterlist = DatabaseGetPost.GetNameWord(naam, woord);
        }

        /// <summary>
        /// Filters posts on name and category
        /// </summary>
        /// <param name="naam">The name entered in the Searchbox<param>
        /// <param name="categorie">The category selected in the comboSearchbox</param> 
        /// <returns>A list of posts which match the criteria</returns>
        public List<Post> GetNameCategory(string naam, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetNameCategory(naam, categorie);
        }

        /// <summary>
        /// Filters posts on word in the text and category
        /// </summary>
        /// <param name="woord">The text entered in the Searchbox</param>
        /// <param name="categorie">The category selected in the comboSearchbox</param> 
        /// <returns>A list of posts which match the criteria</returns>
        public List<Post> GetWordCategory(string woord, string categorie)
        {
            return Filterlist = DatabaseGetPost.GetWordCategory(woord, categorie);
        }
    }
}
