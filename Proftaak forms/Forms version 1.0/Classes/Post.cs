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

        public string Attachment = "None";
        public string PostID { get; set; }

        /// <summary>
        /// Used to get/add posts to the Data Access Layer
        /// </summary>
        /// <param name="iD">The ID of a post<param>
        /// <param name="text">The text of a post</param>
        /// <param name="category">The category of a post</param> 
        /// <param name="accountID">AccountID of de post<param>
        /// <param name="timelineID">timelineID of a post</param>
        /// <param name="likes">The amount of likes of a post</param> 
        /// <param name="account">The account matching with the accountID></param> 
        /// <param name="file">The file belonging to the post</param>
        /// <param name="attachment">A string to show if a post has a file</param>
        /// <param name="postID">This is the ID of the post reacted to</param>
        public Post(int iD, string text, string category, int accountID, int timelineID, int likes, Account account, byte[] file, string attachment, string postID)
        {
            this.ID = iD;
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.Account = account;
            this.File = file;
            this.Attachment = attachment;
            this.PostID = postID;
        }

        /// <summary>
        /// Used to get/add posts to the Data Access Layer
        /// </summary>
        /// <param name="text">The text of a post</param>
        /// <param name="category">The category of a post</param> 
        /// <param name="accountID">AccountID of de post<param>
        /// <param name="timelineID">timelineID of a post</param>
        /// <param name="likes">The amount of likes of a post</param> 
        public Post(string text, string category, int accountID, int timelineID, int likes)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
        }

        /// <summary>
        /// Used to get/add posts to the Data Access Layer
        /// </summary>
        /// <param name="text">The text of a post</param>
        /// <param name="category">The category of a post</param> 
        /// <param name="accountID">AccountID of de post<param>
        /// <param name="timelineID">timelineID of a post</param>
        /// <param name="likes">The amount of likes of a post</param> 
        /// <param name="postID">This is the ID of the post reacted to</param>
        public Post(string text, string category, int accountID, int timelineID, int likes, string postID)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.PostID = postID;
        }

        /// <summary>
        /// Used to get/add posts to the Data Access Layer
        /// </summary>
        /// <param name="text">The text of a post</param>
        /// <param name="category">The category of a post</param> 
        /// <param name="accountID">AccountID of de post<param>
        /// <param name="timelineID">timelineID of a post</param>
        /// <param name="likes">The amount of likes of a post</param> 
        /// <param name="file">The file belonging to the post</param>
        public Post(string text, string category, int accountID, int timelineID, int likes, byte[] file)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.File = file;
        }

        /// <summary>
        /// Used to get/add posts to the Data Access Layer
        /// </summary>
        /// <param name="text">The text of a post</param>
        /// <param name="category">The category of a post</param> 
        /// <param name="accountID">AccountID of de post<param>
        /// <param name="timelineID">timelineID of a post</param>
        /// <param name="likes">The amount of likes of a post</param> 
        /// <param name="file">The file belonging to the post</param>
        /// <param name="postID">This is the ID of the post reacted to</param>
        public Post(string text, string category, int accountID, int timelineID, int likes, byte[] file, string postID)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.File = file;
            this.PostID = postID;
        }

        /// <summary>
        /// Used to get/add posts to the Data Access Layer
        /// </summary>
        /// <param name="text">The text of a post</param>
        /// <param name="category">The category of a post</param> 
        /// <param name="accountID">AccountID of de post<param>
        /// <param name="timelineID">timelineID of a post</param>
        /// <param name="likes">The amount of likes of a post</param> 
        /// <param name="account">The account matching with the accountID></param> 
        /// <param name="file">The file belonging to the post</param>
        /// <param name="attachment">A string to show if a post has a file</param>
        public Post(string text, string category, int accountID, int timelineID, int likes, Account account, byte[] file, string attachment)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.Account = account;
            this.File = file;
            this.Attachment = attachment;
        }

        /// <summary>
        /// Used to get/add posts to the Data Access Layer
        /// </summary>
        /// <returns>ToString method to write to the listbox</returns>
        public override string ToString()
        {
            int Length;
            string Name = Account.Name;
            for (Length = Name.Length; Length < 20;)
            {
                Name = Name.Insert(Name.Length, " ");
                Length = Name.Length;
            }
            return  Name + Text.PadRight(90) +  Likes.ToString().PadRight(12) + Attachment.PadRight(20) + ID; 
        }
    }
}
