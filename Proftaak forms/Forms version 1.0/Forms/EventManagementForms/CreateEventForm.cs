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

namespace Forms_version_1._0
{
    public partial class CreateEventForm : Form
    {
        //stel er is een event op dezelfde locatie en dag dan controleert die hier niet op

        public CreateEventForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbEventName.Text != "" && tbEventDiscription.Text != "" && cbLocation.Text != "" && dtpDateEvent.Text != "")
            {
                Account account = new Account(CurrentAccount.ID, CurrentAccount.Name, CurrentAccount.UserName, CurrentAccount.Password, CurrentAccount.Function);
                Event NewEvent = new Event(tbEventName.Text, tbEventDiscription.Text, cbLocation.Text, (int)numQuantityVisitors.Value, dtpDateEvent.Value, account);
                NewEvent.GetCamping();
                
                if (NewEvent.CheckDateOutOfRange() == false)
                {
                    MessageBox.Show("De datum moet twee weken van te voren zijn");
                }              
                else if (NewEvent.CreateEvent(NewEvent))
                {
                    NewEvent.CreateTimeLine();
                    MessageBox.Show("Een nieuwe event is succesvol aangemaakt");                
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

        private void btnRental_Click(object sender, EventArgs e)
        {
            MateriaalEventForm Form = new MateriaalEventForm();
            Form.ShowDialog();
            
        }
    }
}
