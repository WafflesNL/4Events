using Forms_version_1._0.Classes;
using Forms_version_1._0.Classes.Enum;
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
    public partial class Filter : Form
    {
        public List<Post> Filerlst = new List<Post>();
        public Filter()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                cbCat.Items.Add(item);
            }
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            FilterClass FC = new FilterClass();
            //All 3
            if (tbName.Text != "" && tbWoord.Text != "" && cbCat != null)
            {
                Filerlst = FC.GetAll(tbName.Text, tbWoord.Text, cbCat.Text);
                this.Close();
            }
            //Just Name
            else if (tbName.Text != "" && tbWoord.Text == "" && cbCat == null)
            {
                Filerlst = FC.GetName(tbName.Text);
                this.Close();
            }
            //Just Word
            else if (tbName.Text == "" && tbWoord.Text != "" && cbCat == null)
            {
                //FC.GetWord();
            }
            //Just Category
            else if (tbName.Text == "" && tbWoord.Text == "" && cbCat != null)
            {
               // FC.GetCategory();
            }
            //Name and Word
            else if (tbName.Text != "" && tbWoord.Text != "" && cbCat == null)
            {
              //  FC.GetNameWord();
            }
            //Name and Category
            else if (tbName.Text != "" && tbWoord.Text == "" && cbCat != null)
            {
                //FC.GetNameCategory();
            }
            //Word and Category
            else if (tbName.Text == "" && tbWoord.Text != "" && cbCat != null)
            {
               // FC.GetWordCategory();
            }

        }
    }
}
