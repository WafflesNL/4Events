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
        Event newevent;

        public GastenOverzichtForm(Event Event)
        {
            InitializeComponent();
            this.newevent = Event;
            GetGuestList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetGuestList();
        }

        private void GetGuestList()
        {
            lbGuestList.Items.Clear();
            foreach (Account A in newevent.GetGuestList())
            {
                lbGuestList.Items.Add(A);
            }
        }


    }
}
