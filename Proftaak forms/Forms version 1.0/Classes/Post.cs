using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_version_1._0.Classes.Database.TimelineManagement;


namespace Forms_version_1._0.Classes
{
    public class Post
    {
        public Post Postobj { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public int AccountID = CurrentAccount.ID;

        public Post(string text, string category, int accountID, Post postobj)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
        }

        public Post(string text, string category, int accountID)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
        }

        public void DownloadPost()
        {

        }

        public static void AddPost()
        {

        }
    }
}
