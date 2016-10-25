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
    public partial class OverzichtReserveringForm : Form
    {
        Event newevent;

        public OverzichtReserveringForm(Event Event)
        {
            InitializeComponent();
            this.newevent = Event;
            GetReservationList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetReservationList();
        }

        private void GetReservationList()
        {
            lbReservation.Items.Clear();
            foreach (Reservation A in newevent.GetReservationList())
            {
                lbReservation.Items.Add(A);
            }
        }
    }
}
