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
        public Event Event { get; set; }

        public TimeLine()
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
