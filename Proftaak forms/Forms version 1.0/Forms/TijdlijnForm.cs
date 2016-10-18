using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_version_1._0.Forms
{
    public partial class TijdlijnForm : Form
    {
        TimeLine timeline;
        string Posttext;
        string Categorytext;

        public TijdlijnForm()
        {
            
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            HomeForm window = new HomeForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            //Likes selected Post.
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            //Opens Photo Library to add a picture or film to the Post.
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Categorytext = cbCatergory.Text;
            Posttext = txtPost.Text;
            Post post = new Post(Posttext, Categorytext, CurrentAccount.ID);
            timeline.AddPost(post);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter window = new Filter();
            window.ShowDialog();
        }

        public void GetData(TimeLine timeline)
        {
            this.timeline = timeline;
        }
    }
}
