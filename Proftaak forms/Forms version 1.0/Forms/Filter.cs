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
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            //Searches the timeline for Posts containing the specified info.
            this.Close();
        }
    }
}