using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_version_1._0.Classes.Database.TimelineManagement;

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
    }
}
