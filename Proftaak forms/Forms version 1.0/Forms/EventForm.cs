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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            GastenOverzichtForm  window = new GastenOverzichtForm();
            window.ShowDialog();
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            ReserveringForm window = new ReserveringForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnNietOpslaan_Click(object sender, EventArgs e)
        {
            //Won't save changes to the Event.
            HomeForm window = new HomeForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            //Saves changes to the Event.
            HomeForm window = new HomeForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            VerhuurForm window = new VerhuurForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }
    }
}
