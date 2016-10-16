using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class TimeLine
    {     
        List<Post> Postlist = new List<Post>();
        // public Event Event { get; set; }

        public TimeLine()
        {
           
        }

        public TimeLine(List<Post> Postlist)
        {
            this.Postlist = Postlist;
        }

        public void AddPost(Post post)
        {

        }

        public void GetPost(Post post)
        {

        }
    }
}
