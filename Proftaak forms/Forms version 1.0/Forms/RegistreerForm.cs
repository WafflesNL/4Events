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
    public partial class RegistreerForm : Form
    {
        public RegistreerForm()
        {
            InitializeComponent();
        }

        //Zelfde code als ander form moet nog aan gewerkt worden
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbUserName.Text != "" && tbNewPassword.Text != "" && tbRepeatPassword.Text != "") //change account and password
            {

                if (tbNewPassword.Text == tbRepeatPassword.Text)  //If passwords are the same
                {
                    Account Account = new Account(tbName.Text, tbUserName.Text, tbNewPassword.Text, Function.Bezoeker);
                    bool Check = Account.CreateAccount(Account);
                    CheckUserName(Check);
                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen");
                }
            }           
            else
            {
                MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
            }
        }

        public void CheckUserName(bool Check)
        {
            if (Check)
            {
                MessageBox.Show("Het account is succesvol aangemaakt");      
                this.Hide();        
            }
            else
            {
                MessageBox.Show("De gebruikersnaam bestaat al in de database");
            }
        }
    }
}
