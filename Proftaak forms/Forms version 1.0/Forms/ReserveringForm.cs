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

        public ReserveringForm()
        {
            reservation = new Reservation();
            

            InitializeComponent();

            RefreshForm();
        }

        private void RefreshForm()
        {
            List<Account> accountList = new List<Account>();
            accountList = DatabaseGetAccounts.GetAccounts();

            lbAccount.Items.Clear();
            foreach (Account A in accountList)
            {
                lbAccount.Items.Add(A);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            foreach (var item in lbReserveringLijst.Items)
            {
                reservation.Accounts.Add((Account)item);
            }

            reservation.AddReservation();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm Form = new HomeForm();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var toBeAddedItem = lbAccount.SelectedItem;
            //Eventprice should come from the database. but this is not implemented yet.
            var EventPrice = 10;

            //Checks if the item is already in the list
            foreach (var item in lbReserveringLijst.Items)
            {
                if(toBeAddedItem == item)
                {
                    MessageBox.Show("Account is al toegevoegd aan de reserveringslijst.", "Fout");
                    return;
                }
            }

            lbReserveringLijst.Items.Add(toBeAddedItem);

            //Adds the value of the reservation to the textbox;
            var totalEventPrice = lbReserveringLijst.Items.Count * EventPrice;
            tbBedrag.Text = Convert.ToString(totalEventPrice);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbReserveringLijst.SelectedItem != null)
            {
                var toBeRemoved = lbReserveringLijst.SelectedItem;
                var EventPrice = 10;

                lbReserveringLijst.Items.Remove(toBeRemoved);

                //Adds the value of the reservation to the textbox;
                var totalEventPrice = lbReserveringLijst.Items.Count * EventPrice;
                tbBedrag.Text = Convert.ToString(totalEventPrice);
            }
            else
            {
                MessageBox.Show("Selecteer een account uit de reserveringslijst die verwijdert moet worden.", "Fout");
            }

            
        }
    }
}
