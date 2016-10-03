using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Post
    {
        public Account Account { get; set; }
        public Post Postobj { get; set; }
        public string Posttext { get; set; }
        public string Categorie { get; set; }
        public string Tijdlijnname { get; set; }

        public Post(string posttext, string categorie, Account account, Post postobj)
        {
            this.Account = account;
            this.Posttext = posttext;
            this.Categorie = categorie;
        }

        public void DownloadPost()
        {

        }
    }
}
