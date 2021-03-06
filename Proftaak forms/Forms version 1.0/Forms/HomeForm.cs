﻿using Forms_version_1._0.Classes;
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
        List<Post> poslst = new List<Post>();
        public HomeForm()
        {
            InitializeComponent();
            GetAccess();
            LoadEvents();       
        }

        private void btnTijdlijn_Click(object sender, EventArgs e)
        {
            Event Event = cbSelectEvent.SelectedItem as Event;
            try
            {
                TijdlijnForm Form = new TijdlijnForm(Event);
                Form.ShowDialog();  
            }
            catch (Exception)
            {
                MessageBox.Show("Event heeft (nog) geen tijdlijn");
            }
            
                  
        }

        private void btnBetalingStatus_Click(object sender, EventArgs e)
        {
            Event Event = cbSelectEvent.SelectedItem as Event;
            BetalingsForm Form = new BetalingsForm(Event);
            Form.ShowDialog();
        }

        private void btnEventInfo_Click(object sender, EventArgs e)
        {
            Event Event = cbSelectEvent.SelectedItem as Event;
            EventForm Form = new EventForm();
            Form.GetData(Event);
            Form.ShowDialog();
            LoadEvents();
            DisableButtons();
        }

        private void btnReserveren_Click(object sender, EventArgs e)
        {
            Event Event = cbSelectEvent.SelectedItem as Event;
            ReserveringForm Form = new ReserveringForm(Event);
            Form.ShowDialog();

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

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Event Event = cbSelectEvent.SelectedItem as Event;
            VerhuurKeuze verhuurform = new VerhuurKeuze(Event);        
            verhuurform.ShowDialog();
        }

        private void cbSelectEvent_SelectedIndexChanged(object sender, EventArgs e)
        {          
            //iedereen
            this.btnEventInfo.Enabled = this.cbSelectEvent.SelectedItem != null;     
            this.btnTijdlijn.Enabled = this.cbSelectEvent.SelectedItem != null;

            if (CurrentAccount.Function == Function.Bezoeker)
            {
                this.btnReserve.Enabled = this.cbSelectEvent.SelectedItem != null;
                this.btnBetalingStatus.Enabled = this.cbSelectEvent.SelectedItem != null;
            }
            else if (CurrentAccount.Function == Function.Beheerder)
            {
                this.btnMaterial.Enabled = this.cbSelectEvent.SelectedItem != null;
            }
            else if (CurrentAccount.Function == Function.Medewerker)
            {
                this.btnMaterial.Enabled = this.cbSelectEvent.SelectedItem != null;
            }
            else if (CurrentAccount.Function == Function.Accountbeheerder)
            {

            }        
        }

        /// <summary>
        /// Loads all events and puts them in the combobox cbSelectEvents.
        /// </summary>
        private void LoadEvents()
        {
            cbSelectEvent.Items.Clear();
            foreach (Event E in CurrentAccount.GetEvents())
            {
                cbSelectEvent.Items.Add(E);
            }
        }

        /// <summary>
        /// Grants access to users.
        /// </summary>
        private void GetAccess()
        {
            if (CurrentAccount.Function == Function.Beheerder)
            {
                btnAccountView.Enabled = true;
                btnCreateEvent.Enabled = true;
            }
            else if (CurrentAccount.Function == Function.Accountbeheerder)
            {
                btnAccountView.Enabled = true;
            }
            else if (CurrentAccount.Function == Function.Medewerker)
            {

            }
            else if (CurrentAccount.Function == Function.Bezoeker)
            {

            }
        }

        /// <summary>
        /// Disables all buttons.
        /// </summary>
        private void DisableButtons()
        {
            btnAccountView.Enabled = false;
            btnBetalingStatus.Enabled = false;
            btnCreateEvent.Enabled = false;
            btnEventInfo.Enabled = false;
            btnMaterial.Enabled = false;
            btnReserve.Enabled = false;
            btnTijdlijn.Enabled = false;
            GetAccess();
        }


    }
}
