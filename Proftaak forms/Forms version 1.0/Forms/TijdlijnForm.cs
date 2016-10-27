using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms_version_1._0.Classes.Enum;


namespace Forms_version_1._0.Forms
{
    public partial class TijdlijnForm : Form
    {
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        Event newevent;
        Post postAttach;
        List<Post> Postlist = new List<Post>();

        public TijdlijnForm(Event Event)
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                cbCatergory.Items.Add(item);
            }       
            newevent = Event;
            GetPosts();
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
            int ID;
            TimeLine newtimeline = new TimeLine(newevent.TimeLine.TimelineID);
            if (TijdlijnBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteer een post");
            }
            else
            {
                ID = TijdlijnBox.SelectedIndex + 1;
                Post post1 = new Post(ID);
                newtimeline.LikePost(post1);
                if (newtimeline.Check == true)
                {
                    TijdlijnBox.Items.Clear();
                    GetPosts();
                }
            }
            
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (cbCatergory.Text != null && txtPost.Text != "")
            {
                TimeLine newtimeline = new TimeLine(newevent.TimeLine.TimelineID);
                string Categorytext = cbCatergory.Text;
                string Posttext = txtPost.Text;
                if (Posttext.Length < 90)
                {
                    postAttach = new Post(Posttext, Categorytext, CurrentAccount.ID, newevent.TimeLine.TimelineID, 0, newtimeline.AddFile());
                    newtimeline.AddPost(postAttach);
                }
                else
                {
                    MessageBox.Show("Meer dan 90 Karakters niet toegestaan");
                }
            }
            else
            {
                MessageBox.Show("Please enter Category and Text");
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            TimeLine newtimeline = new TimeLine(newevent.TimeLine.TimelineID);
            if (cbCatergory.Text != null && txtPost.Text != "")
            {
                if (postAttach != null)
                {
                    newtimeline.AddPost(postAttach);
                }

                else
                {
                    string Categorytext = cbCatergory.Text;
                    string Posttext = txtPost.Text;
                    if (Posttext.Length < 90)
                    {
                        Post post = new Post(Posttext, Categorytext, CurrentAccount.ID, newevent.TimeLine.TimelineID, 0);
                        newtimeline.AddPost(post);
                    }
                    else
                    {
                        MessageBox.Show("Meer dan 90 Karakters niet toegestaan");
                    }

                }

                    if (newtimeline.Check == true)
                    {
                        TijdlijnBox.Items.Clear();
                        GetPosts();
                        cbCatergory.Text = null;
                        txtPost.Text = null;
                    }        
            }
            else
            {
                MessageBox.Show("Please enter Category and Text");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterClass FC = new FilterClass();
            Filter window = new Filter();            
            window.ShowDialog();
            foreach (Post E in window.Filerlst)
            {
                TijdlijnBox.Items.Clear();
                TijdlijnBox.Items.Add(E);
            }
        }
        public void GetPosts()
        {
            TimeLine newtimeline = new TimeLine(newevent.TimeLine.TimelineID);
            foreach (Post E in newtimeline.GetPost())
            {
                TijdlijnBox.Items.Add(E);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            TimeLine newtimeline = new TimeLine(newevent.TimeLine.TimelineID);
            Post post = TijdlijnBox.SelectedItem as Post;
            pcbAttach.Image = TimeLine.ByteToImage(post.File);
            using (SaveFileDialog Save = new SaveFileDialog())
            {
                Save.Title = "Save Dialog";
                Save.Filter = "Bitmap Images (.bmp)|.bmp|All files(.)|.";
                if (Save.ShowDialog(this) == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(pcbAttach.Width, pcbAttach.Height))
                    {
                        pcbAttach.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));                       
                        bmp.Save(Save.FileName);
                    }
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            int ID;
            TimeLine newtimeline = new TimeLine(newevent.TimeLine.TimelineID);
            if (TijdlijnBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteer een post");
            }
            else
            {
                ID = TijdlijnBox.SelectedIndex + 1;
                Post post1 = new Post(ID);
                newtimeline.ReportPost(post1);
                if (newtimeline.Check == true)
                {
                    TijdlijnBox.Items.Clear();
                    GetPosts();
                }
            }
        }
    }
}
