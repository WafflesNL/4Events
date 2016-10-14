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
    public partial class AlterAccountForm : Form
    {
        private Account Account;

        public AlterAccountForm()
        {
            InitializeComponent();
            GetAcces();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbUserName.Text != "" && cbFunction.Text != "" && (tbNewPassword.Text != "" || tbRepeatPassword.Text != "")) //change account and password
            {

                if (tbNewPassword.Text == tbRepeatPassword.Text)  //If passwords are the same
                {
                    Account NewAccount = new Account(Account.ID, tbName.Text, tbUserName.Text, tbNewPassword.Text, (Function)Enum.Parse(typeof(Function), cbFunction.Text));
                    //hier zullen ID opgehaald moeten worden aan de hand van de goede
                    bool Check = NewAccount.EditAccount(NewAccount);                 
                    CheckUserName(Check);

                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen");
                }
            }
            else if (tbName.Text != "" && tbUserName.Text != "" && cbFunction.Text != "") //Don't change password
            {
                Account NewAccount = new Account(Account.ID, tbName.Text, tbUserName.Text, tbOldPassword.Text, (Function)Enum.Parse(typeof(Function), cbFunction.Text));
                bool Check = NewAccount.EditAccount(NewAccount);            
                CheckUserName(Check);
            }
            else
            {
                MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
            }
        }

        private void CheckUserName(bool Check)
        {
            if (Check)
            {
                MessageBox.Show("Het account is succesvol aangepast");
                this.Close();
            }
            else
            {
                MessageBox.Show("De gebruikersnaam bestaat al in de database");
            }
        }

        public void GetAccountInformation(Account Account)
        {
            tbUserName.Text = Account.Username;
            tbName.Text = Account.Name;
            tbOldPassword.Text = Account.Password;
            cbFunction.Text = Account.Function.ToString();

            this.Account = Account;
        }


        private void GetAcces()
        {
            if (CurrentAccount.Function == Function.Beheerder)
            {
                cbFunction.Enabled = false;
            }
            else if (CurrentAccount.Function == Function.Accountbeheerder)
            {
                cbFunction.Enabled = false;
            }
            else if (CurrentAccount.Function == Function.Medewerker)
            {
                cbFunction.Enabled = false;
            }
            else
            {
                cbFunction.Enabled = false;
            }
        }
    }
}
