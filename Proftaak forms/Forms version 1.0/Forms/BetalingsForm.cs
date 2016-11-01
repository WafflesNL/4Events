using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms_version_1._0.Classes;

namespace Forms_version_1._0.Forms
{
    public partial class BetalingsForm : Form
    {
        Event currentEvent;

        public BetalingsForm(Event currentEvent)
        {
            InitializeComponent();
            this.currentEvent = currentEvent;
            
        }

        private void btnBetalen_Click(object sender, EventArgs e)
        {
            //Takes the user to a 3rd party Paying Method
            this.Close();
        }
    }
}
