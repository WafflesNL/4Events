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
    public partial class MateriaalBeschikbaarForm : Form
    {
        Event newevent;

        public MateriaalBeschikbaarForm(Event Event)
        {
            InitializeComponent();
            this.newevent = Event;
            GetMaterialList();

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            GetMaterialList();
        }

        private void GetMaterialList()
        {
            lbMateriaal.Items.Clear();
            foreach (Material A in newevent.GetMaterialList())
            {
                lbMateriaal.Items.Add(A);
            }
        }

      
    }
}
