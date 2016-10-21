using Forms_version_1._0;
using Forms_version_1._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_version_1._0.Forms
{
    public partial class ReserveringForm : Form
    {

        public ReserveringForm()
        {
            InitializeComponent();

            RefreshForm();
        }

        private void RefreshForm()
        {
            List<Account> accountList = new List<Account>();
            accountList = DatabaseGetAccounts.GetAccounts();

            lbAccount.Items.Clear();
            foreach (Account A in accountList)
            {
                lbAccount.Items.Add(A);
            }
        }
    }
}
