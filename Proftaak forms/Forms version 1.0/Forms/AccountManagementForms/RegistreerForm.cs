using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Forms_version_1._0.Classes;
using System.Threading;

namespace Forms_version_1._0
{
    public partial class RegistreerForm : Form
    {
        System.Timers.Timer t;
        RFID rfid;

        public RegistreerForm()
        {
            InitializeComponent();
            GetAcces();
            t = new System.Timers.Timer();
            t.Interval = 300;
            t.Elapsed += Time_Elapsed;
            t.Start();

            rfid = new RFID();
            rfid.Open();
            if(rfid.IsAttached == false)
            {
                MessageBox.Show("RFID Reader kon niet worden gevonden. Form wordt opgestart zonder RFID functionaliteit.", "Melding");
            }
            
        }

        private void Time_Elapsed(object sender, ElapsedEventArgs e)
        {
            UpdateRFIDText();
        }

        private void UpdateRFIDText()
        {
            if (InvokeRequired)
            {
                try
                {
                    MethodInvoker method = new MethodInvoker(UpdateRFIDText);
                    Invoke(method);
                    return;
                }
                catch (Exception)
                {

                   
                }
            }

            tbRFIDTag.Text = rfid.CurrentRFIDTag;
        }

        //netheid code moet nog aan gewerkt worden
        private void btnSave_Click(object sender, EventArgs e)
        {
            Function function;
            if (CurrentAccount.Function == Function.Accountbeheerder)
            {
                function = CurrentAccount.TranslateFunction(cbFunction.Text);
            }
            else
            {
                function = Function.Bezoeker;
            }
            if(tbName.Text != "" && tbUserName.Text != "" && tbNewPassword.Text != "" && tbRepeatPassword.Text != "" && tbRFIDTag.Text != "") // If RFID is filed in
            {
                if (tbNewPassword.Text == tbRepeatPassword.Text)  //If passwords are the same
                {
                    Account Account = new Account(tbName.Text, tbUserName.Text, tbNewPassword.Text, function);
                    bool Check = Account.CreateAccountWithRFID(Account, tbRFIDTag.Text);
                    CheckUserName(Check);
                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen");
                }
            }
            else if (tbName.Text != "" && tbUserName.Text != "" && tbNewPassword.Text != "" && tbRepeatPassword.Text != "") //change account and password
            {

                if (tbNewPassword.Text == tbRepeatPassword.Text)  //If passwords are the same
                {
                    Account Account = new Account(tbName.Text, tbUserName.Text, tbNewPassword.Text, function);
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


        private void GetAcces()
        {
            if (CurrentAccount.Function == Function.Beheerder)
            {
               
            }
            else if (CurrentAccount.Function == Function.Accountbeheerder)
            {
                lblFunction.Visible = true;
                cbFunction.Visible = true;
            }
            else if (CurrentAccount.Function == Function.Medewerker)
            {

            }
            else
            {

            }
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            rfid.Close();
            t.Stop();
            Dispose();
        }
    }
}
