using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget21COM;

namespace RFID_Reader_Prototype_X01
{
    public partial class Form1 : Form
    {
        //RFID rf;
        PhidgetRFID rf;
        string lastTag;

        public Form1()
        {
            //rf = new RFID();
            rf = new PhidgetRFID();
            rf.OnAttach += Rf_OnAttach;
            rf.OnDetach += Rf_OnDetach;
            rf.OnError += Rf_OnError;

            rf.OnTag += Rf_OnTag;
            rf.OnTagLost += Rf_OnTagLost;
            
            InitializeComponent();
        }

        private void Rf_OnTagLost(string TagNumber)
        {
            Console.WriteLine("Tag {0} lost", TagNumber);
        }

        private void Rf_OnTag(string TagNumber)
        {
            Console.WriteLine("Tag {0} ", TagNumber);
            lastTag = TagNumber;
        }

        private void Rf_OnError(string Description, [System.Runtime.InteropServices.ComAliasName("Phidget21COM.PhidgetCOM_Error")] PhidgetCOM_Error SCODE)
        {
            Console.WriteLine(Description);
        }

        private void Rf_OnDetach()
        {
            Console.WriteLine("RFIDReader {0} Detached!", rf.DeviceName.ToString());
        }

        private void Rf_OnAttach()
        {
            Console.WriteLine("RFIDReader {0} attached!", rf.DeviceName.ToString());
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                rf.Open();
                Console.WriteLine("Waiting for attachment...");
                rf.WaitForAttachment(1000);
                rf.AntennaOn = true;
                rf.LEDOn = true;



            }
            catch
            {
                Console.WriteLine("Error with attaching.");
            }

            
        }

        private void WriteToBox(string text)
        {
            tbRFIDTag.Text = text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tbRFIDTag.Text = lastTag;
            rf.LEDOn = false;
            rf.Close();
        }

        private void tbWrite_Click(object sender, EventArgs e)
        {
            
        }
    }
}
