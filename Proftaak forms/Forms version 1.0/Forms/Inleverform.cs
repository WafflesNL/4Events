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
    public partial class InleverForm : Form
    {
        Event Event;
        Account Account;
        RFID rfid;
        Material material = new Material(1,"tomato",2, null,null);

        List<Material> materiallist = new List<Material>();
        List<Material> selectedlist = new List<Material>();
     
        public InleverForm(Event Event)
        {
            rfid = new RFID();
            InitializeComponent();
            this.Event = Event;
            GetData();
            Refreshform();
            rfid.Open();
            if(rfid.IsAttached == false)
            {
                MessageBox.Show("RFID reader kon niet worden gevonden. Form wordt opgestart zonder RFID functionaliteit.");
                btnInleveren.Visible = false;
                btnCheck.Visible = false;
            }
        }
        
        private void btnInleveren_Click(object sender, EventArgs e)
        {
            Account account = DatabaseGetAccounts.GetAccountFromRFID(rfid.CurrentRFIDTag);

            if(account == null)
            {
                MessageBox.Show("Account kon niet worden gevonden.");
                return;
            }

            material.Return(selectedlist, account.ID);
            selectedlist.Clear();
            Refreshform();
        }
    

        private void btnToevoegen_Click(object sender, EventArgs e)
        {          
            if (lbMateriaal.SelectedItem != null)
            {
                Material material = lbMateriaal.SelectedItem as Material;
                materiallist.Remove(material);
                selectedlist.Add(material);                         
            }
            Refreshform();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbSelected.SelectedItem != null)
            {
                Material material = lbSelected.SelectedItem as Material;
                selectedlist.Remove(material);
                materiallist.Add(material);           
            }
            Refreshform();
        }

        //Checks the seperate list and adds all the costs to see the total price.
        private void btnTotaal_Click(object sender, EventArgs e)
        {         
            tbTotaal.Text = material.TotalPrice(selectedlist).ToString();
        }
  

        private void Refreshform()
        {           
            lbMateriaal.Items.Clear();
            foreach (Material M in materiallist)
            {
                lbMateriaal.Items.Add(M);
            }

            lbSelected.Items.Clear();
            foreach (Material M2 in selectedlist)
            {
                lbSelected.Items.Add(M2);
            }         
        }


        public void GetData()
        {           
            lblEvent.Text = Event.Name;       
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Account = DatabaseGetAccounts.GetAccountFromRFID(rfid.CurrentRFIDTag);

            if(Account == null)
            {
                MessageBox.Show("Account kon niet worden gevonden.");
                return;
            }

            materiallist = material.GetMaterialForAccount(Event.ID, Account.ID);
            Refreshform();
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            rfid.Close();
        }
    }
}
