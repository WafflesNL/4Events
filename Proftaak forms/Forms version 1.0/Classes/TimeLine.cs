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

        public TimeLine(int timelineID)
        {
            
        }

        public TimeLine(int timelineID, List<Post> Postlist)
        {

        }

        public void AddPost(Post post)
        {
            DatabaseAddPost.AddPost(post);
        }

        public void GetPost(Post post)
        {

        }
    }
}
