using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EonBotzLibrary;
using SqlKata.Execution;
namespace SchoolManagementSystem
{
    public partial class tuitionCateg : Form
    {
        public tuitionCateg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBContext.GetContext().Query("tuitioncategory").Insert(new
            {
                category = textBox1.Text,
                description = textBox2.Text


            }); ;
            MessageBox.Show("success");
           
     
        }
    }
}
