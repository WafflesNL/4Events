﻿using Forms_version_1._0.Classes;
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

        private void btnInChecken_Click(object sender, EventArgs e)
        {
            if(rfid.CurrentRFIDTag != null)
            {
                Account account = newevent.Checkin_CheckAccount(rfid.CurrentRFIDTag);

                if(account == null)
                {
                    MessageBox.Show("Dit account is niet ingeschreven voor dit event of heeft niet betaald.");
                    return;
                }

                // Check het account
                if (MessageBox.Show("Account: " + account.Username + " Wordt ingeschrevern.", "Melding", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Schrijf het account in
                    
                    if (newevent.Checkin_UpdateAccount(account) == false)
                    {
                        MessageBox.Show("Account kon niet worden ingecheckt.");
                    }

                    GetGuestList();
                }
                else
                {
                    MessageBox.Show("Account wordt niet ingecheckt.", "Melding");
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
                Account Account = newevent.Checkuit_CheckAccount(rfid.CurrentRFIDTag);

                if (Account == null)
                {
                    MessageBox.Show("Dit account is momenteel niet op het event");
                    return;
                }
                // Hier moet ook nog foutafhandeling bij
                if (MessageBox.Show("Account: " + Account.Username + " Wordt uitgeschreven.", "Melding", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (newevent.Checkuit_UpdateAccount(Account) == false)
                    {
                        MessageBox.Show("Account kon niet worden uigecheckt.");
                    }

                    GetGuestList();
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

        /// <summary>
        /// Gets a list from all guests from an event and puts them in a listbox.
        /// </summary>
        private void GetGuestList()
        {
            lbGuestList.Items.Clear();
            foreach (Account A in newevent.GetGuestList())
            {
                lbGuestList.Items.Add(A);
            }
        }

        /// <summary>
        /// Grants acces to the user depending on function.
        /// </summary>
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
    }
}
