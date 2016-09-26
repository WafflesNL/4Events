using Forms_version_1._0.Forms;
using Forms_version_1._0.Froms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_version_1._0
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnTijdlijn_Click(object sender, EventArgs e)
        {
            TijdlijnForm window = new TijdlijnForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnBetalingStatus_Click(object sender, EventArgs e)
        {
            BetalingsForm window = new BetalingsForm();
            window.ShowDialog();
        }

        private void btnEventInfo_Click(object sender, EventArgs e)
        {
            EventForm window = new EventForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnReserveren_Click(object sender, EventArgs e)
        {
            //On Click puts a reservation for the selected event into your account and adds it to your cart.
        }

        private void btnPlaats_Click(object sender, EventArgs e)
        {
            CampingOverzichtForm window = new CampingOverzichtForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForm window = new AccountForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin window = new FormLogin();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }
    }
}
