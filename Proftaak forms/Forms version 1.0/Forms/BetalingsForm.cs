﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms_version_1._0.Classes;

namespace Forms_version_1._0.Forms
{
    public partial class BetalingsForm : Form
    {
        Reservation Reservation;
        Event currentEvent;
        List<Reservation> listReservation;

        public BetalingsForm(Event currentEvent)
        {
            InitializeComponent();
            this.currentEvent = currentEvent;
            GetPayment();
        }

        private void btnBetalen_Click(object sender, EventArgs e)
        {
            // moet de reservation op kunnen vragen 
            // Put database code to set payment to true here.
            this.Close();
        }

        private void GetPayment()
        {
            listReservation = currentEvent.GetReservationList();
            foreach (Reservation reservation in listReservation)
            {
                lblEvent.Text = "" + reservation.Event.ToString();

                foreach (Account account in reservation.Accounts)
                {
                    if (account.ID != CurrentAccount.ID)
                    {
                        lblKostenDB.Text = "" + reservation.Payment.Amount;
                        lblReserve.Text = "Reservering gevonden, betaling is mogelijk.";
                        btnBetalen.Enabled = true;
                        this.Reservation = reservation;
                    }
                }
            }

        }
    }
}
