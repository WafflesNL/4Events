using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_version_1._0.Classes
{
    public class Tijdlijn
    {
        public string Eventname { get; set; }
        List<Post> Postlist = new List<Post>();
        public Event Event { get; set; }

        public Tijdlijn(string eventname)
        {
            this.Eventname = eventname;
        }

        public void AddPost(Post post)
        {

        }

        public void GetPost(Post post)
        {

        }
    }
}
