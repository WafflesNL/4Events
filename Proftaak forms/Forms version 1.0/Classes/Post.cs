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
        public int ID { get; set; }
        public int TimeLineID { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public int AccountID { get; set; }
        public int Likes { get; set; }
        public Account Account { get; set; }
        public byte[] File { get; set; }

        public Post(string text, string category, int accountID, int timelineID, int likes, Account account)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.Account = account;
        }

        public Post(string text, string category, int accountID, int timelineID, int likes)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
        }

        public Post(string text, string category, int accountID, int timelineID, int likes, byte[] file)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.File = file;
        }

        public Post(int iD)
        {
            this.ID = iD;
        }

        public void DownloadPost()
        {

        }

        public static void AddPost()
        {

        }

        public override string ToString()
        {
            return Account.Name +  Text +  Likes; 
        }
    }
}
