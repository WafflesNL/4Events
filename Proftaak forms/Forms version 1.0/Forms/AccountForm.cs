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
            //bool Check;

            if (tbName.Text != "" && tbUserName.Text != "" && cbFunction.Text != "" && tbNewPassword.Text != "" && tbRepeatPassword.Text != "") //change account and password
            {
                
                if (tbNewPassword.Text == tbRepeatPassword.Text)  //If passwords are the same
                {
                    Account Account = new Account(tbName.Text, tbUserName.Text, tbNewPassword.Text, (Function)Enum.Parse(typeof(Function), cbFunction.Text));
                    Account.EditAccount(Account);
                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen");
                }     
            }
            else if (tbName.Text != "" && tbUserName.Text != "" && cbFunction.Text != "") //Don't change password
            {
                Account Account = new Account(tbName.Text, tbUserName.Text, tbOldPassword.Text, (Function)Enum.Parse(typeof(Function), cbFunction.Text));
                Account.EditAccount(Account);
            }
            else
            {
                MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
            }

            /*
            if ()
            {

            }
            else
            {
                MessageBox.Show("The username already exists in the database");
            }
            */
        }

        public void GetAccountInformation()
        {
            tbName.Text = CurrentAccount.Name;
            tbUserName.Text = CurrentAccount.UserName;
            tbOldPassword.Text = CurrentAccount.Password;
            cbFunction.Text = CurrentAccount.Function.ToString();
            if (CurrentAccount.Function == Function.Accountbeheerder)
            {
                cbFunction.Enabled = true;
            }
            else
            {
                cbFunction.Enabled = false;
            }
        }
    }
}
