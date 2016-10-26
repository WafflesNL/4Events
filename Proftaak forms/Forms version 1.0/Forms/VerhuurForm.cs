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
    public partial class VerhuurForm : Form
    {   Event Event;
        Account account;
        Material material = new Material(1,"tomato",2, null,null);
        List<Material> materiallist = new List<Material>();
        List<Material> selectedlist = new List<Material>();
     
        public VerhuurForm()
        {
            InitializeComponent();
            
         
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            EventForm window = new EventForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        // rents the items
        // still unfinished does nothing useful
        private void btnVerhuur_Click(object sender, EventArgs e)
        { 
            if (cbAccounts.SelectedItem != null)
            {
                Account account = cbAccounts.SelectedItem as Account;
                material.Rent(selectedlist, account.ID);
                lbSelected.Items.Clear();
                selectedlist.Clear();
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //Adds selected Object to the main list. Meaning that it's been returned.
            if (lbMateriaal.SelectedItem != null)
            {
                Material material = lbMateriaal.SelectedItem as Material;
                lbSelected.Items.Add(lbMateriaal.SelectedItem);
                selectedlist.Add(material);

                materiallist.RemoveAt(lbMateriaal.SelectedIndex);
                lbMateriaal.DataSource = null;
                lbMateriaal.Items.Remove(lbMateriaal.SelectedItem);
                lbMateriaal.DataSource = materiallist;
            }

        }

        //Checks the seperate list and adds all the costs to see the total price.
        private void btnTotaal_Click(object sender, EventArgs e)
        {
            
            tbTotaal.Text = material.TotalPrice(selectedlist).ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbSelected.Items.Clear();
            materiallist = material.GetMaterialForEvent(Event.ID);
            lbMateriaal.DataSource = materiallist;
        }

        public void GetData(Event Event)
        {
            this.Event = Event;
            lblEvent.Text = Event.Name;
            cbAccounts.DataSource = material.GetAccounts(Event.ID);

        }
    }
}
