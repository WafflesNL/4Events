﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_version_1._0.Classes.Database.TimelineManagement;
using System.IO;
using System.Windows.Forms;

namespace Forms_version_1._0.Classes
{
    public class TimeLine
    {     
        public List<Post> Postlist = new List<Post>();
        public int TimelineID { get; set; }
        public bool Check { get; set; }

        public TimeLine(int timelineID)
        {
            this.TimelineID = timelineID;
        }

        public TimeLine(int timelineID, List<Post> Postlist)
        {
            this.TimelineID = timelineID;
            this.Postlist = Postlist;
        }

        public void AddPost(Post post)
        {
            Check = DatabaseAddPost.AddPost(post);
        }

        public List<Post> GetPost()
        {
            Postlist = DatabaseGetPost.GetPost();
            return Postlist;
        }

        public void LikePost(Post post)
        {
            Check = DatabaseEditPost.LikePost(post);
        }

        public byte[] AddFile()
        {
            byte[] TempFile;
            Stream stream;
            OpenFileDialog ofD = new OpenFileDialog();
            ofD.InitialDirectory = "c:\\";
            ofD.Filter = "Image Files (*.jpg)|*.Jpg|Image Files (*.png)|*.png |Video Files (*.mp4)|*.mp4|All files (*.*)|*.*";
            ofD.FilterIndex = 2;
            ofD.RestoreDirectory = true;
            if (ofD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = ofD.OpenFile()) != null)
                    {
                        using (stream)
                        {
                                return TempFile = File.ReadAllBytes(ofD.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            return TempFile = null;
        }

        public void GetFile(Post post)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Download";
            // set filters - this can be done in properties as well
            sfd.Filter = "Image Files (*.jpg)|*.jpg|Image Files (*.png)|*.png|Video Files (*.mp4)|*.mp4|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.InitialDirectory = @"\Desktop";
                File.WriteAllBytes(sfd.InitialDirectory, post.File);
            }           
        }
    }
}
