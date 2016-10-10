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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = tbUsername.Text;
            string Password = tbPassword.Text;

            if (CurrentAccount.Login(Password, Username))
            {
                HomeForm window = new HomeForm();
                this.Hide();
                window.ShowDialog();
                this.Close();
            }
            else
            {
                lblInlogstatus.Text = "Het inloggen is mislukt probeer het opnieuw";
            }

          
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegistreerForm Form = new RegistreerForm();
            Form.ShowDialog();
        }
    }
}
