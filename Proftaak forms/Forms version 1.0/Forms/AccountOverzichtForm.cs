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
    public partial class AccountOverzichtForm : Form
    {
        public AccountOverzichtForm()
        {
            InitializeComponent();
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            //geen must have hoeft niet geïmplementeerd te worden
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            RegistreerForm Form = new RegistreerForm();
            Form.ShowDialog();
        }
    }
}
