﻿using System;
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
            GetAccess();
            GetAccountInformation();
        }

       
        private void btnOpslaan_Click(object sender, EventArgs e)
        {        
            if (tbName.Text != "" && tbUserName.Text != "" && cbFunction.Text != "" && (tbNewPassword.Text != "" || tbRepeatPassword.Text != "")) //change account and password
            {
                
                if (tbNewPassword.Text == tbRepeatPassword.Text)  //If passwords are the same
                {
                    Account Account = new Account(CurrentAccount.ID, tbName.Text, tbUserName.Text, tbNewPassword.Text, (Function)Enum.Parse(typeof(Function), cbFunction.Text));                   
                    bool Check = Account.EditAccount(Account);                            
                    CurrentAccount.UpdateAccount(Account);                  
                    CheckUserName(Check);
                
                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen");
                }     
            }
            else if (tbName.Text != "" && tbUserName.Text != "" && cbFunction.Text != "") //Don't change password
            {
                Account Account = new Account(CurrentAccount.ID, tbName.Text, tbUserName.Text, tbOldPassword.Text, (Function)Enum.Parse(typeof(Function), cbFunction.Text));
                bool Check = Account.EditAccount(Account);
                CurrentAccount.UpdateAccount(Account);        
                CheckUserName(Check);         
            }
            else
            {
                MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
            }                          
        }

        /// <summary>
        /// Shows the user messageboxes depending on the bool.
        /// </summary>
        /// <param name="Check">Requires true if the username doesn't exist and false if it does.</param>
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

        /// <summary>
        /// Gets the account information from CurrentAccount.
        /// </summary>
        private void GetAccountInformation()
        {               
            tbName.Text = CurrentAccount.Name;
            tbUserName.Text = CurrentAccount.UserName;
            tbOldPassword.Text = CurrentAccount.Password;
            cbFunction.Text = CurrentAccount.Function.ToString();              
        }

        /// <summary>
        /// Grants Access depending on the account function.
        /// </summary>
        private void GetAccess()
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
