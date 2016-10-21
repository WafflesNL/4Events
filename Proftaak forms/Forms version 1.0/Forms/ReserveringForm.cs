﻿using Forms_version_1._0;
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

        public ReserveringForm()
        {
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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var toBeAddedItem = lbAccount.SelectedItem;

            //Checks if the item is already in the list
            foreach (var item in lbReserveringLijst.Items)
            {
                if(toBeAddedItem == item)
                {
                    MessageBox.Show("Account is al toegevoegd aan de reserveringslijst.");
                    return;
                }
            }

            lbReserveringLijst.Items.Add(toBeAddedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
