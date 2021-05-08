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

        }


       

        private void dgvSched_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var dg = new AddStudentScheduling();
            //dgvStudentSched.Rows.Add(dg.dgvSched.SelectedRows[0].Cells[0].ToString());
            //dgvStudentSched.Rows.Add(dgvSched.SelectedRows[0].Cells[0].Value.ToString(),
            //    dgvSched.SelectedRows[0].Cells[1].Value.ToString(), dgvSched.SelectedRows[0].Cells[2].Value.ToString(),
            //    dgvSched.SelectedRows[0].Cells[3].Value.ToString(), dgvSched.SelectedRows[0].Cells[4].Value.ToString(),
            //    dgvSched.SelectedRows[0].Cells[5].Value, dgvSched.SelectedRows[0].Cells[6].Value,
            //    dgvSched.SelectedRows[0].Cells[7].Value.ToString());


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
    }
}
