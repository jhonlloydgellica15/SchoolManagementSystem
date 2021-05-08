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


    public partial class AddStudentScheduling : Form
    {
        studentSched sched = new studentSched();
        StudentScheduling addDatagrid;
        public AddStudentScheduling(StudentScheduling addDatagrid)
        {
            InitializeComponent();
            this.addDatagrid = addDatagrid;

        }

        private void AddStudentScheduling_Load(object sender, EventArgs e)
        {
            displayData();
            displayDataCmb();
        }

        public void displayDataCmb()
        {
            var values = DBContext.GetContext().Query("tuitioncategory").Get();


            foreach (var value in values)
            {
                comboBox1.Items.Add(value.category);
            }
        }

        public void displayData()
        {
            //schedule sched = new schedule();

            //dgvSched.Columns[5].DefaultCellStyle.Format = "hh:mm tt";
            //dgvSched.Columns[6].DefaultCellStyle.Format = "hh:mm tt";

            //sched.viewsched();

            //dgvSched.Rows.Clear();
            //foreach (DataRow Drow in sched.dt.Rows)
            //{
            //    int num = dgvSched.Rows.Add();

            //    dgvSched.Rows[num].Cells[0].Value = Drow["SchedID"].ToString();
            //    dgvSched.Rows[num].Cells[1].Value = Drow["SubjectCode"].ToString();
            //    dgvSched.Rows[num].Cells[2].Value = Drow["courseID"].ToString();
            //    dgvSched.Rows[num].Cells[3].Value = Drow["date"].ToString();
            //    dgvSched.Rows[num].Cells[4].Value = Drow["maxStudent"].ToString();
            //    dgvSched.Rows[num].Cells[5].Value = Convert.ToDateTime(Drow["time start"].ToString());
            //    dgvSched.Rows[num].Cells[6].Value = Convert.ToDateTime(Drow["time end"].ToString());
            //    dgvSched.Rows[num].Cells[7].Value = Drow["status"].ToString();
            //}

            //foreach (DataGridViewRow Myrow in dgvSched.Rows)
            //{            //Here 2 cell is target value and 1 cell is Volume
            //    if (Convert.ToString(Myrow.Cells[6].Value) == "available")// Or your condition 
            //    {
            //        // Myrow.DefaultCellStyle.BackColor = Color.IndianRed;
            //        Myrow.DefaultCellStyle.BackColor = Color.White;
            //    }

            //    else if (Convert.ToString(Myrow.Cells[6].Value) == "full")
            //    {
            //        Myrow.DefaultCellStyle.BackColor = Color.Orange;
            //    }
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSched_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach(DataGridViewRow row in addDatagrid.dgvStudentSched.Rows)
            {
                if ((string)row.Cells[0].Value == dgvSched.SelectedRows[0].Cells[0].Value.ToString())
                {
                    Validator.AlertDanger("Subject existed");
                    return;
                }
            }
            addDatagrid.dgvStudentSched.Rows.Add(dgvSched.SelectedRows[0].Cells[0].Value.ToString(), dgvSched.SelectedRows[0].Cells[1].Value.ToString(),
            dgvSched.SelectedRows[0].Cells[2].Value.ToString(), dgvSched.SelectedRows[0].Cells[3].Value.ToString(), dgvSched.SelectedRows[0].Cells[4].Value,
            dgvSched.SelectedRows[0].Cells[5].Value, dgvSched.SelectedRows[0].Cells[6].Value, dgvSched.SelectedRows[0].Cells[7].Value.ToString());

        }



        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSched.Rows.Clear();
            sched.category = comboBox1.Text;


            dgvSched.Columns[4].DefaultCellStyle.Format = "hh:mm tt";
            dgvSched.Columns[5].DefaultCellStyle.Format = "hh:mm tt";
            sched.display();


            foreach (DataRow Drow in sched.dt.Rows)
            {
                int num = dgvSched.Rows.Add();

                dgvSched.Rows[num].Cells[0].Value = Drow["SchedId"].ToString();
                dgvSched.Rows[num].Cells[1].Value = Drow["SubjectCode"].ToString();
                dgvSched.Rows[num].Cells[2].Value = Drow["RoomName"].ToString();
                dgvSched.Rows[num].Cells[3].Value = Drow["Day"].ToString();
                dgvSched.Rows[num].Cells[4].Value = Convert.ToDateTime(Drow["Timestart"].ToString());
                dgvSched.Rows[num].Cells[5].Value = Convert.ToDateTime(Drow["Timeend"].ToString());

                dgvSched.Rows[num].Cells[6].Value = Drow["MaxStudent"].ToString();
                dgvSched.Rows[num].Cells[7].Value = Drow["Status"].ToString();

            }
        }
    }
}

