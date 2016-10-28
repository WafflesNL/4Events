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
        Material material = new Material(1,"tomato",2, null,null);

        List<Material> materiallist = new List<Material>();
        List<Material> selectedlist = new List<Material>();
     
        public InleverForm(Event Event)
        {
            InitializeComponent();
            this.Event = Event;
            GetData();
            Refreshform();
        }
    
        //Koppelt een material aan een account       
        private void btnInleveren_Click(object sender, EventArgs e)
        { 
            if (cbAccounts.SelectedItem != null)
            {
                Account account = cbAccounts.SelectedItem as Account;
                material.Return(selectedlist, account.ID);           
                selectedlist.Clear();
            }
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
            cbAccounts.DataSource = Event.GetGuestList();
           // materiallist = Event.GetMaterialList();         
        }

        private void cbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account = cbAccounts.SelectedItem as Account;
            materiallist = material.GetMaterialForAccount(Event.ID, Account.ID);
            Refreshform();
            
        }
    }
}
