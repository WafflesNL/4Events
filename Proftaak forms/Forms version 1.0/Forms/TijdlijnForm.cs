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
        Post postcheck;
        Post postrep;
        TimeLine newtimeline;
        List<Post> Postlist = new List<Post>();
        int Check = 0;

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
            if (lbTimeline.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een post");
            }
            else
            {
                //Post post1 = lbTimeline.SelectedItem as Post;
                newtimeline.LikePost(lbTimeline.SelectedItem as Post);
                if (newtimeline.Check == true)
                {
                    lbTimeline.Items.Clear();
                    GetPosts();
                }
            }
            
        } //Button to like the selected post

        private void btnAttach_Click(object sender, EventArgs e) //Sends post with an attachment to the business layer
        {
            if (lbTimeline.SelectedItem != null)
            {
                if (cbCatergory.Text != null && txtPost.Text != "")
                {
                    Post post1 = lbTimeline.SelectedItem as Post;
                    string Categorytext = cbCatergory.Text;
                    string Posttext = txtPost.Text;
                    if (Posttext.Length < 90)
                    {
                        postAttach = new Post(Posttext, Categorytext, CurrentAccount.ID, newevent.TimeLine.TimelineID, 0, newtimeline.AddFile(), post1.ID.ToString());
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
            else
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
        }

        private void btnPost_Click(object sender, EventArgs e) //Sends post to the business layer
        {
            if (lbTimeline.SelectedItem == null)
            {
                if (cbCatergory.Text != "" && txtPost.Text != "")
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
                            newtimeline.AddPost(newtimeline.CreatePost(Posttext, Categorytext, newtimeline.TimelineID)); 
                        }
                        else
                        {
                            MessageBox.Show("Meer dan 90 Karakters niet toegestaan");
                        }

                    }

                    if (newtimeline.Check)
                    {
                        lbTimeline.Items.Clear();
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
                Post post1 = lbTimeline.SelectedItem as Post;
                if (cbCatergory.Text != null && txtPost.Text != "")
                {
                    if (postAttach != null)
                    {
                        newtimeline.AddReaction(postAttach); //Inserts a post with an attachment
                    }
                    else
                    {
                        string Categorytext = cbCatergory.Text;
                        string Posttext = txtPost.Text;
                        if (Posttext.Length < 90)
                        {
                            newtimeline.AddReaction(newtimeline.CreateReaction(Posttext, Categorytext, newtimeline.TimelineID, post1.ID.ToString())); //Inserts a post without an attachment
                        }
                        else
                        {
                            MessageBox.Show("Meer dan 90 Karakters niet toegestaan");
                        }

                    }

                    if (newtimeline.Check)
                    {
                        lbTimeline.Items.Clear();
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
            if (window.Filerlst.Count != 0)
            {
                lbTimeline.Items.Clear();              
            }
            else
            {
                MessageBox.Show("Geen resultaten gevonden");
            }      
            foreach (Post E in window.Filerlst)
            {               
                lbTimeline.Items.Add(E);
            }
        }

        private void GetPosts() //Method to get all the posts into the Listbox
        {
            foreach (Post E in newtimeline.GetPost())
            {
                lbTimeline.Items.Add(E);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Post post = lbTimeline.SelectedItem as Post;
            if (lbTimeline.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een Post met bestand");
            }
            else
            {
                pcbAttach.Image = TimeLine.ByteToImage(post.File);
            }
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
            if (lbTimeline.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een post");
            }
            else
            {
                postrep = lbTimeline.SelectedItem as Post;
                if (postcheck != postrep)
                {
                    postcheck = postrep;
                    newtimeline.ReportPost(postrep);
                    if (newtimeline.Check == true)
                    {
                        lbTimeline.Items.Clear();
                        GetPosts();
                    }
                }          
                
                else if (Check == 0)
                {
                    postcheck = postrep;
                    newtimeline.ReportPost(postrep);
                    if (newtimeline.Check == true)
                    {
                        lbTimeline.Items.Clear();
                        GetPosts();
                        Check++;
                    }
                }
                else
                {
                    MessageBox.Show("Deze post is al gereport");
                }              
            }    
        } //Button to reports the selected post

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (lbTimeline.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een post met bijlage");
            }
            else
            {
                Post post = lbTimeline.SelectedItem as Post;
                pcbAttach.Image = TimeLine.ByteToImage(post.File);
            }          
        } //Button to show the attachment from the selected post

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbTimeline.Items.Clear();
            GetPosts();
        } //Clears the filter

        private void btnShowReact_Click(object sender, EventArgs e)
        {
            Post post1 = lbTimeline.SelectedItem as Post;
            if (post1 != null)
            {
                lbTimeline.Items.Clear();
                lbTimeline.Items.Add(post1);
                foreach (Post E in newtimeline.GetReaction(post1.ID.ToString()))
                    {
                        lbTimeline.Items.Add(E);
                    }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een post");
            }
            lbTimeline.SetSelected(0, true);
        } //Shows reactions to selected post
    }
}
