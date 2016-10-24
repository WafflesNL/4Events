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
    public partial class GastenOverzichtForm : Form
    {
        Event newEvent;

        public GastenOverzichtForm(Event Event)
        {
            InitializeComponent();
            this.newEvent = Event;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGuestList.Items.Clear();
            foreach (Account A in newEvent.GetGuestList()) 
            {
                lbGuestList.Items.Add(A);
            }
        }
    }
}
