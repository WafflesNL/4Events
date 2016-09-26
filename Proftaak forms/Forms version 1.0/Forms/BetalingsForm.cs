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
    public partial class BetalingsForm : Form
    {
        public BetalingsForm()
        {
            InitializeComponent();
        }

        private void btnBetalen_Click(object sender, EventArgs e)
        {
            //Takes the user to a 3rd party Paying Method
            this.Close();
        }
    }
}
