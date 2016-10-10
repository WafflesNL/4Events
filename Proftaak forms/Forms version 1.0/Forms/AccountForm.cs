using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_version_1._0.Froms
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            GetAccountInformation();
        }

        private void btnNietOpslaan_Click(object sender, EventArgs e)
        {
            //Won't save the changes made to the Account.
            HomeForm window = new HomeForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbUserName.Text != "" && cbFunction.Text != "" && tbNewPassword.Text != "" && tbRepeatPassword.Text != "")
            {
                //change account and password
                if (tbNewPassword.Text == tbRepeatPassword.Text)
                {
                    //if passwords are the same
                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen");
                }     
            }
            else if (tbName.Text != "" && tbUserName.Text != "" && cbFunction.Text != "")
            {
                Account Account = new Account(tbName.Text, tbUserName.Text)
            }
            else
            {
                MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
            }

        }

        public void GetAccountInformation()
        {
            tbName.Text = CurrentAccount.Name;
            tbUserName.Text = CurrentAccount.UserName;
            tbOldPassword.Text = CurrentAccount.Password;
            cbFunction.Text = CurrentAccount.Function.ToString();
            if (CurrentAccount.Function == Function.Bezoeker || CurrentAccount.Function == Function.Medewerker)
            {
                cbFunction.Enabled = false;
            }
            else
            {
                cbFunction.Enabled = true;
            }
        }
    }
}
