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
        TimeLine newtimeline;
        List<Post> Postlist = new List<Post>();

        public TijdlijnForm(Event Event)
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                cbCatergory.Items.Add(item);
            }       
            newevent = Event;
            newtimeline = new TimeLine(newevent.TimeLine.TimelineID);
            GetPosts();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {      
            this.Close();
        } //Button to go back to the homeform

        private void btnLike_Click(object sender, EventArgs e)
        {
            int ID;
            if (TijdlijnBox.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een post");
            }
            else
            {
                ID = TijdlijnBox.SelectedIndex + 1; //hier kun je een methode van maken en in post neer zetten
                Post post1 = new Post(ID);
                newtimeline.LikePost(post1); //like post zou eigenlijk op een manier terug moeten komen in de klasse post net als rapporteren

                if (newtimeline.Check == true)
                {
                    TijdlijnBox.Items.Clear();
                    GetPosts();
                }
            }
            
        } //Button to like the selected post

        private void btnAttach_Click(object sender, EventArgs e) //Sends post with an attachment to the business layer
        {
            if (cbCatergory.Text != null && txtPost.Text != "")
            {
                string Categorytext = cbCatergory.Text;
                string Posttext = txtPost.Text;
                if (Posttext.Length < 90)
                {
                    postAttach = new Post(Posttext, Categorytext, CurrentAccount.ID, newevent.TimeLine.TimelineID, 0, newtimeline.AddFile());
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

        private void btnPost_Click(object sender, EventArgs e) //Sends post to the business layer
        {
            if (TijdlijnBox.SelectedItem == null)
            {
                if (cbCatergory.Text != null && txtPost.Text != "")
                {
                    if (postAttach != null) //Inserts a post with an attachment
                    {
                        newtimeline.AddPost(postAttach); 
                    }
                    else //Inserts a post without an attachment
                    {
                        string Categorytext = cbCatergory.Text;
                        string Posttext = txtPost.Text;
                        if (Posttext.Length < 90)
                        {
                            Post post = new Post(Posttext, Categorytext, CurrentAccount.ID, newtimeline.TimelineID, 0);
                            newtimeline.AddPost(post); 
                        }
                        else
                        {
                            MessageBox.Show("Meer dan 90 Karakters niet toegestaan");
                        }

                    }

                    if (newtimeline.Check)
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
            else
            {
                Post post1 = TijdlijnBox.SelectedItem as Post;
                if (cbCatergory.Text != null && txtPost.Text != "")
                {
                    if (postAttach != null)
                    {
                        string Categorytext = cbCatergory.Text;
                        string Posttext = txtPost.Text;
                        newtimeline.AddReaction(postAttach = new Post(Posttext, Categorytext, CurrentAccount.ID, newevent.TimeLine.TimelineID, 0, newtimeline.AddFile(), post1.ID.ToString())); //Inserts a post with an attachment
                    }
                    else
                    {
                        string Categorytext = cbCatergory.Text;
                        string Posttext = txtPost.Text;
                        if (Posttext.Length < 90)
                        {
                            Post post2 = new Post(Posttext, Categorytext, CurrentAccount.ID, newtimeline.TimelineID, 0, post1.ID.ToString());
                            newtimeline.AddReaction(post2); //Inserts a post without an attachment
                        }
                        else
                        {
                            MessageBox.Show("Meer dan 90 Karakters niet toegestaan");
                        }

                    }

                    if (newtimeline.Check)
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
        }

        private void btnFilter_Click(object sender, EventArgs e) //Button for the filterfunction
        {
            Filter window = new Filter();            
            window.ShowDialog();
            TijdlijnBox.Items.Clear();
            foreach (Post E in window.Filerlst)
            {               
                TijdlijnBox.Items.Add(E);
            }
        }

        private void GetPosts() //Method to get all the posts into the Listbox
        {
            foreach (Post E in newtimeline.GetPost())
            {
                TijdlijnBox.Items.Add(E);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Post post = TijdlijnBox.SelectedItem as Post;
            pcbAttach.Image = TimeLine.ByteToImage(post.File);
            if (pcbAttach.Image == null)
            {
                
            }
            else
            {
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
        } //Downloads the attachment from the selected post

        private void btnReport_Click(object sender, EventArgs e)
        {
            int ID;
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
        } //Button to reports the selected post

        private void btnShow_Click(object sender, EventArgs e)
        {
            Post post = TijdlijnBox.SelectedItem as Post;
            pcbAttach.Image = TimeLine.ByteToImage(post.File);
        } //Button to show the attachment from the selected post

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TijdlijnBox.Items.Clear();
            GetPosts();
        } //Clears the filter

        private void btnShowReact_Click(object sender, EventArgs e)
        {

        }
    }
}
