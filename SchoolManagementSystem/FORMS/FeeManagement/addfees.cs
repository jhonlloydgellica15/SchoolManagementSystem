using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EonBotzLibrary;
namespace SchoolManagementSystem.FORMS.FeeManagement
{
    public partial class addfees : Form
    {
        feeStruc struc = new feeStruc();
        string id;
        string categoryid;
        public addfees(string val,string val2)
        {

    
            InitializeComponent();
            id = val;
            struckname.Text = val2;
        }

        private void addfees_Load(object sender, EventArgs e)
        {
            struc.structureID = id;
            struc.viewfees();
       

            dataGridView1.Rows.Clear();
            foreach (DataRow Drow in struc.dt.Rows)
            {
                int num = dataGridView1.Rows.Add();

                dataGridView1.Rows[num].Cells[0].Value = Drow["category"].ToString();
                dataGridView1.Rows[num].Cells[1].Value = Drow["amount"].ToString();
               

            }
            textBox1.Text = struc.total;


            struc.viewcategories();

            comboBox1.DataSource = struc.datafill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            struc.category = comboBox1.Text;
            struc.viewcategoryID();
            categoryid = struc.categoryID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            struc.amount = textBox2.Text;
            struc.categoryID = categoryid;
            struc.structureID = id;

            struc.insertfee();
            MessageBox.Show("success");
        }
    }
}
