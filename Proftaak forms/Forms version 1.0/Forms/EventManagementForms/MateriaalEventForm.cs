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

namespace Forms_version_1._0
{
    public partial class MateriaalEventForm : Form
    {
        List<Material> MaterialForRental = new List<Material>();

        List<Material> MaterialAvailable = new List<Material>();

        //moet veranderd worden later
        Material Mt = new Material(1, "Stoel", 50, null, null);

        public MateriaalEventForm()
        {
            InitializeComponent();
            GetmaterialAvailable();
            RefreshForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbMaterialAvailable.SelectedItem != null)
            {
                Material Material = lbMaterialAvailable.SelectedItem as Material;
                lbMaterialAvailable.Items.Remove(Material);
                lbMaterialForEvent.Items.Add(Material);
            }
            else
            {
                MessageBox.Show("Er is niets uit de lijst geselecteerd");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void GetmaterialAvailable()
        {
            MaterialAvailable = Mt.GetMaterialAvailableList();
        }

        private void RefreshForm()
        {
            lbMaterialAvailable.Items.Clear();
            foreach (Material M in MaterialAvailable)
            {
                lbMaterialAvailable.Items.Add(M);
            }

            lbMaterialForEvent.Items.Clear();
            foreach (Material R in MaterialForRental)
            {
                lbMaterialForEvent.Items.Add(R);
            }
        }
    }
}
