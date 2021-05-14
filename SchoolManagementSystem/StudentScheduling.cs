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
    public partial class StudentScheduling : Form
    {
        public StudentScheduling()
        {
            InitializeComponent();

        }

        private void StudentScheduling_Load(object sender, EventArgs e)
        {
         

            dgvStudentSched.Columns[4].DefaultCellStyle.Format = "hh:mm tt";
            dgvStudentSched.Columns[5].DefaultCellStyle.Format = "hh:mm tt";

            var values = DBContext.GetContext().Query("student").Get();

            foreach (var value in values)
            {
                comboBox1.Items.Add( value.lastname);
            }
        }




        private void dgvSched_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        

        }

        private void dgvStudentSched_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvStudentSched_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var myfrm = new AddStudentScheduling(this);
            myfrm.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtStudentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void StudentScheduling_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

            //var values = DBContext.GetContext().Query("student").Where("studentId", txtStudentNo.Text).Get();

            //foreach(var value in values)
            //{
            //    txtName.Text = $"{value.firstname} {value.lastname}";
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var values = DBContext.GetContext().Query("student").Where("lastname",comboBox1.Text).Get();

            foreach (var value in values)
            {
                txtName.Text = value.firstname();
            }
        }
    }
}