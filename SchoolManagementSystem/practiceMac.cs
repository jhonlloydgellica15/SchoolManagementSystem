using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using EonBotzLibrary;
using SqlKata.Execution;

namespace SchoolManagementSystem
{
    public partial class practiceMac : Form
    {
        string aa;
        public practiceMac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ccc



            //string s = textBox1.Text;
            //string hold = "";

            //string[] subs = s.Split(' ');

            //foreach (var sub in subs)
            //{


            //    if (sub == "1")
            //    {
            //        hold += "monday ";
            //    }
            //    else if (sub == "2")
            //    {
            //        hold += "tuesday ";
            //    }

            //    else if (sub == "3")
            //    {
            //        hold += "wednesday ";
            //    }

            //    else if (sub == "4")
            //    {
            //        hold += "thursday ";
            //    }

            //    else if (sub == "5")
            //    {
            //        hold += "friday ";
            //    }
            //}


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

        private void practiceMac_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var values = DBContext.GetContext().Query("rooms").Get();

            foreach (var value in values)
            {
                dataGridView1.Rows.Add(value.roomId, value.name, value.description);
            }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


      
            //dataGridView2.Rows[0].Cells[0].Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //dataGridView2.Rows[0].Cells[1].Value = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //dataGridView2.Rows[0].Cells[2].Value = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //dataGridView2.Rows.Add();
            aa = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            dataGridView2.Rows.Add(aa.ToString());

        }

        public void reloadDatagrid()
        {

        }
    }
}
