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
    public partial class VerhuurForm : Form
    {
        Material material = new Material(1,"tomato",2, null,null);
        public VerhuurForm()
        {
            InitializeComponent();
         
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            EventForm window = new EventForm();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            //Adds selected Object to seperate list which will be saved untill user presser "Totaal".
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //Adds selected Object to the main list. Meaning that it's been returned.
        }

        private void btnTotaal_Click(object sender, EventArgs e)
        {
            //Checks seperate list and adds all the costs to see the total price.
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbSelected.Items.Clear();
            lbMateriaal.DataSource = material.GetMaterialAvailableList();
        }
    }
}
