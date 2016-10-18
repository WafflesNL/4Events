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
        public string Text { get; set; }
        public string Category { get; set; }
        public string Tijdlijnname { get; set; }

        public Post(string text, string category, Account account, Post postobj)
        {
            this.Account = account;
            this.Text = text;
            this.Category = category;
        }

        public void DownloadPost()
        {

        }
    }
}
