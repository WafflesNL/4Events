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
    public partial class AccountOverzichtForm : Form
    {
        //Andere oplossing is nodig
        public Account account = new Account("", "", "", Function.Bezoeker); 

        public AccountOverzichtForm()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            //Geen must have hoeft niet geïmplementeerd te worden
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            RegistreerForm Form = new RegistreerForm();
            Form.ShowDialog();
            RefreshForm();
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            if (lbAccounts.SelectedItem != null)
            {
                Account Index = lbAccounts.SelectedItem as Account;
                AlterAccountForm Form = new AlterAccountForm();
                Form.GetAccountInformation(Index);
                Form.ShowDialog();
               //Verwijst naar form waar account aan te passen is             
            }           
            RefreshForm();
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
