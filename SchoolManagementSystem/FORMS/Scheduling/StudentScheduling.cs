using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EonBotzLibrary;
using SqlKata.Execution;
using Microsoft.Reporting.WinForms;

namespace SchoolManagementSystem
{
    public partial class StudentScheduling : Form
    {

        studentSched sched = new studentSched();
        public StudentScheduling()
        {
            InitializeComponent();

        }

        private void StudentScheduling_Load(object sender, EventArgs e)
        {
            displayStudents();
            displayDataCmb();
        }
        
        public void displayStudents()
        {
            dgvStudentSched.Columns[4].DefaultCellStyle.Format = "hh:mm tt";
            dgvStudentSched.Columns[5].DefaultCellStyle.Format = "hh:mm tt";

            var values = DBContext.GetContext().Query("student").Get();

            foreach (var value in values)
            {
                comboBox1.Items.Add(value.lastname);
            }
        }

        public void displayDataCmb()
        {
            var values = DBContext.GetContext().Query("tuitioncategory").Get();


            foreach (var value in values)
            {
                cmbSubjects.Items.Add(value.category);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStudentSched.Rows.Clear();
            sched.category = cmbSubjects.Text;


            dgvStudentSched.Columns[4].DefaultCellStyle.Format = "hh:mm tt";
            dgvStudentSched.Columns[5].DefaultCellStyle.Format = "hh:mm tt";
            sched.display();

            foreach (DataRow Drow in sched.dt.Rows)
            {
                int num = dgvStudentSched.Rows.Add();

                dgvStudentSched.Rows[num].Cells[0].Value = Drow["SchedId"].ToString();
                dgvStudentSched.Rows[num].Cells[1].Value = Drow["SubjectCode"].ToString();
                dgvStudentSched.Rows[num].Cells[2].Value = Drow["RoomName"].ToString();
                dgvStudentSched.Rows[num].Cells[3].Value = Drow["Day"].ToString();
                dgvStudentSched.Rows[num].Cells[4].Value = Convert.ToDateTime(Drow["Timestart"].ToString());
                dgvStudentSched.Rows[num].Cells[5].Value = Convert.ToDateTime(Drow["Timeend"].ToString());

                dgvStudentSched.Rows[num].Cells[6].Value = Drow["MaxStudent"].ToString();
                dgvStudentSched.Rows[num].Cells[7].Value = Drow["Status"].ToString();
            }
        }

        private void dgvStudentSched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        ReportDataSource rs = new ReportDataSource();
        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<StudentSchedulings> lst = new List<StudentSchedulings>();
            lst.Clear();
            StudentSchedulesReportViewer frm = new StudentSchedulesReportViewer();
            for (int i = 0; i < dgvStudentSched.Rows.Count - 1; i++)
            {
                lst.Add(new StudentSchedulings
                {
                    schedID = dgvStudentSched.Rows[i].Cells[0].Value.ToString(),
                    subjectCode = dgvStudentSched.Rows[i].Cells[1].Value.ToString(),
                    room = dgvStudentSched.Rows[i].Cells[1].Value.ToString(),
                    day = dgvStudentSched.Rows[i].Cells[1].Value.ToString(),
                    timestart = dgvStudentSched.Rows[i].Cells[1].Value.ToString(),
                    timeend = dgvStudentSched.Rows[i].Cells[1].Value.ToString(),
                    capacity = dgvStudentSched.Rows[i].Cells[1].Value.ToString(),
                    status = dgvStudentSched.Rows[i].Cells[1].Value.ToString(),
                });

                rs.Name = "DataSet1";
                rs.Value = lst;

                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SchoolManagementSystem.Report1.rdlc";

            }
            frm.ShowDialog();
        }
    }
    public class StudentSchedulings
    {
        public string schedID { get; set; }
        public string subjectCode { get; set; }
        public string room { get; set; }
        public string day { get; set; }
        public string timestart { get; set; }
        public string timeend { get; set; }
        public string capacity { get; set; }
        public string status { get; set; }
    }

}