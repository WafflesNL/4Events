using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_version_1._0.Classes.Database.TimelineManagement;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

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
            if (CurrentAccount.ID == 3)
            {
                Postlist = DatabaseGetPost.GetPost();
            }
            else
            {
                Postlist = DatabaseGetPost.GetSafePost();
            }
            return Postlist;
        }

        public void LikePost(Post post)
        {
            Check = DatabaseEditPost.LikePost(post);
        }

        public void ReportPost(Post post)
        {
            Check = DatabaseEditPost.ReportPost(post);
        }

        public byte[] AddFile()
        {
            byte[] TempFile;
            Stream stream;
            OpenFileDialog ofD = new OpenFileDialog();
            ofD.InitialDirectory = "c:\\";
            ofD.Filter = "Image Files (*.jpg)|*.Jpg|Image Files (*.png)|*.png";
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

        public static Bitmap ByteToImage(byte[] postbyte)
        {
            MemoryStream mStream = new MemoryStream();
            mStream.Write(postbyte, 0, Convert.ToInt32(postbyte.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

        }
    }
}
