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
            GetAcces();
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

        private void GetAcces()
        {
            if (CurrentAccount.Function == Function.Beheerder || CurrentAccount.Function == Function.Medewerker)
            {
                btnInChecken.Visible = true;
                btnUitChecken.Visible = true;
            }
            else
            {
                btnInChecken.Visible = false;
                btnUitChecken.Visible = false;
            }
        }

        private void btnInChecken_Click(object sender, EventArgs e)
        {
            //voegt een gast toe aan de gastenlijst
            //laat messagebox zien met in te checken account
        }

        private void btnUitChecken_Click(object sender, EventArgs e)
        {
            //verwijderd een gast uit de lijst
        }
    }
}
