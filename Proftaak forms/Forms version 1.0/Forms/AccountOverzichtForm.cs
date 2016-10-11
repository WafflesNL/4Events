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
        //andere oplossing is nodig
        Account account = new Account("", "", "", Function.Bezoeker);

        public AccountOverzichtForm()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            //geen must have hoeft niet geïmplementeerd te worden
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            RegistreerForm Form = new RegistreerForm();
            Form.ShowDialog();
            RefreshForm();
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            //geselecteerd account moet aangepast worden.
        }



        private void RefreshForm()
        {
            lbAccounts.Items.Clear();
            foreach (Account A in account.GetAccountList())
            {
                lbAccounts.Items.Add(A);
            }
        }



    }
}
