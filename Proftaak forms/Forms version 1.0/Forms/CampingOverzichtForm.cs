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
    public partial class CampingOverzichtForm : Form
    {
        public CampingOverzichtForm()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            HomeForm window = new HomeForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Filters the Campingspots using the combobox beneath.
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //Removes selected reservation. Admins can use this on every spot users can only use this on their own.
        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            //Reserves the selected spot.
        }
    }
}
