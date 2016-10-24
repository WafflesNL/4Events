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
    public partial class EventForm : Form
    {
        Event Event;
        public EventForm()
        {
            InitializeComponent();
            GetAcces();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            GastenOverzichtForm Form = new GastenOverzichtForm(Event); 
            Form.ShowDialog();
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            OverzichtReserveringForm Form = new OverzichtReserveringForm(Event);     
            Form.ShowDialog();         
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            MateriaalBeschikbaarForm Form = new MateriaalBeschikbaarForm(Event);
            Form.ShowDialog();
        }



        private void btnOpslaan_Click(object sender, EventArgs e) //still in progress
        {
            //Saves changes to the Event.         
            if (tbEventName.Text != "" && tbEventDiscription.Text != "" && cbLocation.Text != "" && dtpDateEvent.Text != "" && numQuantityVisitors.Value >= 5)
            {            
                Event NewEvent = new Event(Event.ID, tbEventName.Text, tbEventDiscription.Text, cbLocation.Text, (int)numQuantityVisitors.Value, dtpDateEvent.Value);              

                if (NewEvent.CheckDateOutOfRange() == false)
                {
                    MessageBox.Show("De datum moet twee weken van te voren zijn");
                }
                else if (NewEvent.EditEvent(NewEvent))
                {                  
                    MessageBox.Show("Het event is succesvol aangepast");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is iets fout gegaan probeer het opnieuw");
                }
            }
            else
            {
                MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
            }
        }
       
      

        public void GetData(Event Event)
        {
            this.Event = Event;
            tbEventName.Text = Event.Name;
            tbEventDiscription.Text = Event.Discription;
            cbLocation.Text = Event.Location;
            dtpDateEvent.Value = Event.Date;
            numQuantityVisitors.Value = Event.MaxVisitors;
        }

        private void GetAcces()
        {
            numQuantityVisitors.Enabled = false;

            if (CurrentAccount.Function == Function.Beheerder)
            {
                btnSave.Visible = true;             
            }
            else
            {
                tbEventName.Enabled = false;
                tbEventDiscription.Enabled = false;
                cbLocation.Enabled = false;
                dtpDateEvent.Enabled = false;               
                
            }
        }
    }
}
