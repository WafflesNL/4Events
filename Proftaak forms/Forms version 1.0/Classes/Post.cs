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
        public int TimeLineID { get; set; }

        public string Text { get; set; }
        public string Category { get; set; }
        public int AccountID = CurrentAccount.ID;

        public Post(string text, string category, int accountID, int timelineID)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;

        }

        public void DownloadPost()
        {

        }

        public static void AddPost()
        {

        }

        public override string ToString()
        {
            return Text; 
        }
    }
}
