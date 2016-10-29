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
    public partial class VerhuurKeuze : Form
    {
        Event Event;
        public VerhuurKeuze(Event Event)
        {
            InitializeComponent();
            this.Event = Event;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            VerhuurForm verhuurform = new VerhuurForm(Event);
            verhuurform.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {       
            InleverForm inleverform = new InleverForm(Event);
            inleverform.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
