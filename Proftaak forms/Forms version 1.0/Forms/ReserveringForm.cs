using Forms_version_1._0;
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
    public partial class ReserveringForm : Form
    {
        private Reservation reservation;
        private Event currentEvent;
        List<Place> placeList;
        List<Reservation> reservationList;

        public ReserveringForm(Event currentEvent)
        {
            this.currentEvent = currentEvent;

            reservation = new Reservation();
            
            reservationList = currentEvent.GetReservationList();

            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<Account> accountList = new List<Account>();


            accountList = reservation.GetAccountsFunction(Function.Bezoeker);

            if(currentEvent.Camping != null)
            {
                placeList = currentEvent.Camping.GetPlaces();

                foreach (Control c in gbCamping.Controls)
                {
                    if (c is Button)
                    {
                        c.Click += Button_Click;
                        c.Text = c.Text.Remove(0, 6);
                        int placeID = Convert.ToInt32(c.Text);
                    }
                }
            }

            else
            {
                gbCamping.Enabled = false;
            }
            

            lbAccount.Items.Clear();
            foreach (Account A in accountList)
            {
                lbAccount.Items.Add(A);
            }
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int placeID = Convert.ToInt32(sender.ToString().Remove(0, 35));

            if (placeList[placeID - 1] == reservation.Place)
            {
                reservation.Place = null;
                MessageBox.Show("Plaats selectie verwijderd.", "Melding");
                tbGeselecteerdePlaats.Text = "Geen";
            }
            else
            {
                reservation.Place = placeList[placeID - 1];
                tbGeselecteerdePlaats.Text = "" + placeID;
            }


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet je zeker dat je wilt reserveren?", "Check", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                reservation.Event = currentEvent;

                if (reservation.MoreThanMaxVisitors())
                {
                    MessageBox.Show("Er zitten al te veel bezoekers in dit event.");
                    return;
                }

                foreach (var item in lbReserveringLijst.Items)
                {
                    reservation.Accounts.Add((Account)item);
                }

                

                if (reservation.AddReservation())
                {
                    MessageBox.Show("Gereserveerd.");
                }
                else
                {
                    MessageBox.Show("Er is een fout opgetreden.");
                }
                
            }
            else
            {
                return;
            }



            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var toBeAddedItem = lbAccount.SelectedItem;
            // Eventprice should come from the database. but this is not implemented yet.
            var EventPrice = 10;

            // Checks if the item is already in the list
            foreach (var item in lbReserveringLijst.Items)
            {
                if(toBeAddedItem == item)
                {
                    MessageBox.Show("Account is al toegevoegd aan de reserveringslijst.", "Fout");
                    return;
                }
            }

            lbReserveringLijst.Items.Add(toBeAddedItem);

            // Adds the value of the reservation to the textbox;
            var totalEventPrice = lbReserveringLijst.Items.Count * EventPrice;
            tbBedrag.Text = Convert.ToString(totalEventPrice);
            // And also to the reservation object.
            reservation.Payment.Amount = totalEventPrice;
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbReserveringLijst.SelectedItem != null)
            {
                var toBeRemoved = lbReserveringLijst.SelectedItem;
                var EventPrice = 10;

                lbReserveringLijst.Items.Remove(toBeRemoved);

                // Adds the value of the reservation to the textbox;
                var totalEventPrice = lbReserveringLijst.Items.Count * EventPrice;
                tbBedrag.Text = Convert.ToString(totalEventPrice);
                // And also to the reservation object.
                reservation.Payment.Amount = totalEventPrice;
            }
            else
            {
                MessageBox.Show("Selecteer een account uit de reserveringslijst die verwijdert moet worden.", "Fout");
            }

            
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.SelectedIndex)
            {
                // No filter
                case (0):
                    foreach (Control c in gbCamping.Controls)
                    {
                        if (c is Button)
                        {
                            c.BackColor = DefaultBackColor;
                            c.ForeColor = DefaultForeColor;
                        }
                    }
                    break;
                // Reservation
                case (1):
                    foreach (Control c in gbCamping.Controls)
                    {
                        if (c is Button)
                        {
                            c.BackColor = DefaultBackColor;
                            c.ForeColor = DefaultForeColor;

                            int placeID = Convert.ToInt32(c.Text);
                            int actualID = placeList[placeID - 1].ID;

                            // Not optimal
                            foreach (var currentReservation in reservationList)
                            {
                                if(currentReservation.Place != null)
                                {
                                    if (actualID == currentReservation.Place.ID)
                                    {
                                        c.BackColor = Color.DarkGray;
                                        c.ForeColor = Color.LightGray;
                                    }
                                }

                                
                            }
                        }
                    }
                    break;
                // Category: Green
                case (2):
                    foreach (Control c in gbCamping.Controls)
                    {
                        if (c is Button)
                        {
                            c.BackColor = DefaultBackColor;
                            c.ForeColor = DefaultForeColor;

                            int placeID = Convert.ToInt32(c.Text);

                            if (placeList[placeID - 1].Categorie != Categorie.Green)
                            {
                                c.BackColor = Color.DarkGray;
                                c.ForeColor = Color.LightGray;
                            }
                        }
                    }
                    break;
                // Category: Luxe
                case (3):
                    foreach (Control c in gbCamping.Controls)
                    {
                        if (c is Button)
                        {
                            c.BackColor = DefaultBackColor;
                            c.ForeColor = DefaultForeColor;

                            int placeID = Convert.ToInt32(c.Text);

                            if (placeList[placeID - 1].Categorie != Categorie.Luxe)
                            {
                                c.BackColor = Color.DarkGray;
                                c.ForeColor = Color.LightGray;
                            }
                        }
                    }
                    break;
                // Category: Normal
                case (4):
                    foreach (Control c in gbCamping.Controls)
                    {
                        if (c is Button)
                        {
                            c.BackColor = DefaultBackColor;
                            c.ForeColor = DefaultForeColor;

                            int placeID = Convert.ToInt32(c.Text);

                            if (placeList[placeID - 1].Categorie != Categorie.Normal)
                            {
                                c.BackColor = Color.DarkGray;
                                c.ForeColor = Color.LightGray;
                            }
                        }
                    }
                    break;
                
            }
        }
    }
}
