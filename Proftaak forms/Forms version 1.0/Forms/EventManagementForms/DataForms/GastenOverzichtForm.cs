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
    public partial class GastenOverzichtForm : Form
    {
        Event newevent;
        RFID rfid;

        public GastenOverzichtForm(Event Event)
        {
            InitializeComponent();
            this.newevent = Event;
            GetGuestList();
            GetAcces();
            rfid = new RFID();
            rfid.Open();
            if (rfid.IsAttached == false)
            {
                MessageBox.Show("RFID reader could not be found. Form will be opened without RFID functionality.");
                btnInChecken.Visible = false;
                btnUitChecken.Visible = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetGuestList();
        }

        private void GetGuestList()
        {
            lbGuestList.Items.Clear();
            foreach (Account A in newevent.GetGuestList())
            {
                lbGuestList.Items.Add(A);
            }
        }

        private void GetAcces()
        {
            if (CurrentAccount.Function == Function.Beheerder || CurrentAccount.Function == Function.Medewerker)
            {
                btnInChecken.Visible = true;
                btnUitChecken.Visible = true;
            }
            else
            {
                btnInChecken.Visible = false;
                btnUitChecken.Visible = false;
            }
        }

        private void btnInChecken_Click(object sender, EventArgs e)
        {
            //voegt een gast toe aan de gastenlijst
            //laat messagebox zien met in te checken account
            if(rfid.CurrentRFIDTag != null)
            {
                // Check het account
                // Hier moet ook nog fout afhandeling bij.
                if(MessageBox.Show("Account: " + rfid.CurrentRFIDTag + " Wordt ingeschrevern.", "Melding", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Schrijf het account in
                }
                else
                {
                    MessageBox.Show("Account is niet ingeschreven.", "Melding");
                }
            }
            else
            {
                MessageBox.Show("Geen RFID tag gevonden. Hou de RFID tag boven de reader en druk op de knop.", "Melding");
            }

        }

        private void btnUitChecken_Click(object sender, EventArgs e)
        {
            //verwijderd een gast uit de lijst
            if (rfid.CurrentRFIDTag != null)
            {
                // Check het account
                // Hier moet ook nog foutafhandeling bij
                if (MessageBox.Show("Account: " + rfid.CurrentRFIDTag + " Wordt uitgeschreven.", "Melding", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Schrijf het accoutn in.
                }
                else
                {
                    MessageBox.Show("Account is niet uitgeschreven.", "Melding");
                }
            }
            else
            {
                MessageBox.Show("Geen RFID tag gevonden. Hou de RFID tag boven de reader en druk op de knop.", "Melding");
            }
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            rfid.Close();
        }
    }
}
