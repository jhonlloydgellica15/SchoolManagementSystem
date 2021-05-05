using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class practiceMac : Form
    {
        public practiceMac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result = string.Join("", textBox1.Text.Split(" ").Select(x => x[0]).ToArray());
            MessageBox.Show(result);
        }

        public string GetMacAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        
    }
}
