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
        } //Constructor

        private void btnZoek_Click(object sender, EventArgs e) //All the Search functions
        {
            FilterClass FC = new FilterClass();
            //All 3
            if (tbName.Text != "" && tbWoord.Text != "" && cbCat.Text != "")
            {
                Filerlst = FC.GetAll(tbName.Text, tbWoord.Text, cbCat.Text);
                this.Close();
            }
            //Just Name
            else if (tbName.Text != "" && tbWoord.Text == "" && cbCat.Text == "")
            {
                Filerlst = FC.GetName(tbName.Text);
                this.Close();
            }
            //Just Word
            else if (tbName.Text == "" && tbWoord.Text != "" && cbCat.Text == "")
            {
                Filerlst = FC.GetWord(tbWoord.Text);
                this.Close();
            }
            //Just Category
            else if (tbName.Text == "" && tbWoord.Text == "" && cbCat.Text != "")
            {
                Filerlst = FC.GetCategory(cbCat.Text);
                this.Close();
            }
            //Name and Word
            else if (tbName.Text != "" && tbWoord.Text != "" && cbCat.Text == "")
            {
                Filerlst = FC.GetNameWord(tbName.Text, tbWoord.Text);
                this.Close();
            }
            //Name and Category
            else if (tbName.Text != "" && tbWoord.Text == "" && cbCat.Text != "")
            {
                Filerlst = FC.GetNameCategory(tbName.Text, cbCat.Text);
                this.Close();
            }
            //Word and Category
            else if (tbName.Text == "" && tbWoord.Text != "" && cbCat.Text != "")
            {
                Filerlst = FC.GetWordCategory(tbWoord.Text, cbCat.Text);
                this.Close();
            }

        }
    }
}
