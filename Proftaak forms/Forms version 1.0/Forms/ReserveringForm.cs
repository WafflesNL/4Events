﻿using System;
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
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            EventForm window = new EventForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //Removes selected reservation from the list/database.
        }
    }
}
