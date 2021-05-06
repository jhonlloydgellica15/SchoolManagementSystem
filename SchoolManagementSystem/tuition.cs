using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EonBotzLibrary;
namespace SchoolManagementSystem
{
    public partial class tuition : Form
    {
        tuitionfee tuit = new tuitionfee();
        public tuition()
        {
          
            
            InitializeComponent();
        }

        private void tuition_Load(object sender, EventArgs e)
        {
            displaydata();
        }
       public void displaydata()
        {
            tuit.view();
            foreach (DataRow Drow in tuit.dt.Rows)
            {
                int num = dataGridView1.Rows.Add();

                dataGridView1.Rows[num].Cells[0].Value = Drow["ID"].ToString();
                dataGridView1.Rows[num].Cells[1].Value = Drow["Category"].ToString();
                dataGridView1.Rows[num].Cells[2].Value = Drow["Count"].ToString();
                dataGridView1.Rows[num].Cells[3].Value = Drow["lec price"].ToString();
                dataGridView1.Rows[num].Cells[4].Value = Drow["lab price"].ToString();
                dataGridView1.Rows[num].Cells[5].Value = Drow["total units"].ToString();
                dataGridView1.Rows[num].Cells[6].Value = Drow["total price"].ToString();
            }
        }
    }
}
