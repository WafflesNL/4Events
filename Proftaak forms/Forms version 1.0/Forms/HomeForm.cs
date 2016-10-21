using Forms_version_1._0.Classes;
using Forms_version_1._0.Classes.Database.TimelineManagement;
using Forms_version_1._0.Forms;
using Forms_version_1._0.Froms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_version_1._0
{
    public partial class HomeForm : Form
    {
        //Post post = new Post
        List<Post> poslst = new List<Post>();
        public HomeForm()
        {
            InitializeComponent();
            GetAcces();
            LoadEvents();           
        }

        private void btnTijdlijn_Click(object sender, EventArgs e)
        {
            //DatabaseAddPost.AddPost();
            Event Event = cbSelectEvent.SelectedItem as Event;
            TijdlijnForm Form = new TijdlijnForm(Event);
            Form.ShowDialog();
            this.Close();
        }

        private void btnBetalingStatus_Click(object sender, EventArgs e)
        {
            BetalingsForm Form = new BetalingsForm();
            Form.ShowDialog();
        }

        private void btnEventInfo_Click(object sender, EventArgs e)
        {
            Event Event = cbSelectEvent.SelectedItem as Event;
            EventForm Form = new EventForm();
            Form.GetData(Event);
            Form.ShowDialog();
            LoadEvents();
        }

        private void btnReserveren_Click(object sender, EventArgs e)
        {
            //On Click puts a reservation for the selected event into your account and adds it to your cart.
            ReserveringForm Form = new ReserveringForm();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void btnPlaats_Click(object sender, EventArgs e)
        {
            CampingOverzichtForm Form = new CampingOverzichtForm();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForm Form = new AccountForm();
            Form.ShowDialog();      
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CurrentAccount.RemovePropertys();
            FormLogin Form = new FormLogin();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void btnAccountWijzingen_Click(object sender, EventArgs e)
        {      
            AccountOverzichtForm Form = new AccountOverzichtForm();
            Form.ShowDialog();         
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEventForm Form = new CreateEventForm();
            Form.ShowDialog();
            LoadEvents();
        }

        private void LoadEvents()
        {
            cbSelectEvent.Items.Clear();
            foreach (Event E in CurrentAccount.GetEvents()) //slechte code
            {
                cbSelectEvent.Items.Add(E);
            }
        }
        
        //Geeft toegang aan de gebruikers 
        private void GetAcces()
        {
            if (CurrentAccount.Function == Function.Beheerder)
            {
                btnAccountView.Visible = true;
                btnCreateEvent.Visible = true;
                btnBetalingStatus.Visible = false;
                btnReserve.Visible = false;
            }
            else if(CurrentAccount.Function == Function.Accountbeheerder)
            {
                btnAccountView.Visible = true;
                btnBetalingStatus.Visible = false;
                btnReserve.Visible = false;

            }
            else if(CurrentAccount.Function == Function.Medewerker)
            {
                btnBetalingStatus.Visible = false;
                btnReservePlace.Visible = false;
                btnReserve.Visible = false;
            }
            else if(CurrentAccount.Function == Function.Bezoeker)
            {

            }
        }


        private void cbSelectEvent_SelectedIndexChanged(object sender, EventArgs e)
        {          
            this.btnEventInfo.Enabled = this.cbSelectEvent.SelectedItem != null;
            this.btnReserve.Enabled = this.cbSelectEvent.SelectedItem != null;
        }
    }
}
