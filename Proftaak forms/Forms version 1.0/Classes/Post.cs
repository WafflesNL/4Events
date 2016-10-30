﻿using System;
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
        public string Attachment { get; set; }
        public string PostID { get; set; }

        public Post(int iD)
        {
            this.ID = iD;
        } //Id constructor

        public Post(int iD, string text, string category, int accountID, int timelineID, int likes, Account account, byte[] file, string attachment)
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
        } //Full iD constructor

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
        } //Full ID Reaction constructor

        public Post(string text, string category, int accountID, int timelineID, int likes, Account account)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.Account = account;
        } //Constructor adding account to post

        public Post(string text, string category, int accountID, int timelineID, int likes)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
        } //Regular constructor

        public Post(string text, string category, int accountID, int timelineID, int likes, string postID)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.PostID = postID;
        } //Regular constructor Reaction   

        public Post(string text, string category, int accountID, int timelineID, int likes, byte[] file)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.File = file;
        } //Constructor adding attachment to a post

        public Post(string text, string category, int accountID, int timelineID, int likes, byte[] file, string postID)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.File = file;
            this.PostID = postID;
        } //Constructor adding attachment to a post Reaction

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
        } //Full constructor

        public Post(string text, string category, int accountID, int timelineID, int likes, Account account, byte[] file, string attachment, string postID)
        {
            this.AccountID = accountID;
            this.Text = text;
            this.Category = category;
            this.TimeLineID = timelineID;
            this.Likes = likes;
            this.Account = account;
            this.File = file;
            this.Attachment = attachment;
            this.PostID = postID;
        } //Full Reaction Constructor

        public override string ToString()
        {
            int Length;
            string Name = Account.Name;
            for (Length = Name.Length; Length < 20;)
            {
                Name = Name.Insert(Name.Length, " ");
                Length = Name.Length;
            }
            return  Name + Text.PadRight(90) +  Likes.ToString().PadRight(12) + Attachment.PadRight(12) + ID; 
        } //Tostring method to change Post from the database to strings for the listbox
    }
}
