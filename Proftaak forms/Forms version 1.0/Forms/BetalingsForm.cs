using System;
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
            if (this.Reservation.PayForReservation())
            {
                MessageBox.Show("De betaling is voltooid");
                GetPayment();
            }
            else
            {
                MessageBox.Show("De betaling is niet voltooid");
            }
      
        }

        private void GetPayment()
        {         
            listReservation = currentEvent.GetReservationList();
            foreach (Reservation R in listReservation)
            {
                foreach (Account A in R.Accounts)
                {
                    if (A.ID == CurrentAccount.ID && R.ID == currentEvent.ID && R.Payment.Paid == false)
                    {
                        lblEvent.Text = "Event naam: " + currentEvent.Name.ToString();
                        lblReserve.Text = "Reservering gevonden, betaling is mogelijk.";
                        lblKosten.Text = "Kosten: € " + R.Payment.Amount;
                        Reservation = R;
                    }
                    else if (A.ID == CurrentAccount.ID && R.ID == currentEvent.ID && R.Payment.Paid)
                    {
                        btnBetalen.Enabled = false;
                        lblEvent.Text = "Event naam: " + currentEvent.Name.ToString();
                        lblReserve.Text = "Reservering gevonden, betaling is voltooid.";
                        lblKosten.Text = "Betaalde bedrag: € " + R.Payment.Amount;
                        break;
                    }               
                }
                
            }
        }

    }
}
