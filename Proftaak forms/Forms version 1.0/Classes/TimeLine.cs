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

        /// <summary>
        /// Used to add a Timeline to an Event
        /// </summary>
        /// <param name="timelineID"><param>
        public TimeLine(int timelineID)
        {
            this.TimelineID = timelineID;
        }

        /// <summary>
        /// Used to add a list of post to the Timeline
        /// </summary>
        /// <param name="timelineID"><param>
        /// <param name="Postlist"></param>
        public TimeLine(int timelineID, List<Post> Postlist)
        {
            this.TimelineID = timelineID;
            this.Postlist = Postlist;
        }

        /// <summary>
        /// Adds the post from the parameter into the Data access layer
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
        public void AddPost(Post post)
        {
            Check = DatabaseAddPost.AddPost(post);
        }

        /// <summary>
        /// Adds the post from the parameter into the Data access layer as a reaction
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
        public void AddReaction(Post post)
        {
            Check = DatabaseAddPost.AddReaction(post);
        }

        /// <summary>
        /// Gets all post from the Data access layer
        /// </summary>
        /// <returns>A list of posts</returns>
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

        /// <summary>
        /// Gets all reactions to a specific post from the Data access layer
        /// </summary>
        /// <returns>A list of reactions</returns>
        public List<Post> GetReaction(string ID)
        {
            if (CurrentAccount.ID == 3)
            {
                Postlist = DatabaseGetPost.GetReaction(ID);
            }
            else
            {
                Postlist = DatabaseGetPost.GetSafeReaction(ID);
            }
            return Postlist;
        }

        /// <summary>
        /// Likes the post from the parameter into the Data access layer
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
        public void LikePost(Post post)
        {
            Check = DatabaseEditPost.LikePost(post);
        }

        /// <summary>
        /// Likes the post from the parameter into the Data access layer
        /// </summary>
        /// <returns>True if changes are allowed false if not</returns>
        public void ReportPost(Post post)
        {
            Check = DatabaseEditPost.ReportPost(post);
        }

        /// <summary>
        /// Converts the file uploaded to byte[] and adds it with a post into the Data access layer
        /// </summary>
        /// <returns>The byte[] of the added file</returns>
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

        /// <summary>
        /// Uses the btye[] from the database and converts it to bitmap
        /// </summary>
        /// <param name="postbyte"><param>
        /// <returns>The from byte[] converted bitmap</returns>
        public static Bitmap ByteToImage(byte[] postbyte)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                mStream.Write(postbyte, 0, Convert.ToInt32(postbyte.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            catch (Exception)
            {
                MessageBox.Show("Post heeft geen bijlage");
                return null;
            }


        }

        /// <summary>
        /// Creates a new Post
        /// </summary>
        /// <param name="posttext">Text of the Post<param>
        /// <param name="categorytext">Category of the Post</param>
        /// <param name="timelineID">TimelineID where the Post is posted<param>
        /// <returns>A new Post</returns>
        public Post CreatePost(string posttext, string categorytext, int timelineID)
        {
            Post post = new Post(posttext, categorytext, CurrentAccount.ID, timelineID, 0);
            return post;
        }

        /// <summary>
        /// Creates a new Post as a reaction to another
        /// </summary>
        /// <param name="posttext">Text of the Post<param>
        /// <param name="categorytext">Category of the Post</param>
        /// <param name="timelineID">TimelineID where the Post is posted<param>
        /// <param name="postID">ID of the post reacted to</param>
        /// <returns>A new Post as reaction</returns>
        public Post CreateReaction(string posttext, string categorytext, int timelineID, string postID)
        {
            Post post = new Post(posttext, categorytext, CurrentAccount.ID, timelineID, 0, postID);
            return post;
        }
    }
}
