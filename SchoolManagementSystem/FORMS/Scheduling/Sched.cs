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
    public partial class Sched : Form
    {
        public Sched()
        {
            InitializeComponent();
        }

        private void Sched_Load(object sender, EventArgs e)
        {

            schedule sched = new schedule();

            sched.viewsched();

            dgvSched.Rows.Clear();
            foreach (DataRow Drow in sched.dt.Rows)
            {
                int num = dgvSched.Rows.Add();

                dgvSched.Rows[num].Cells[0].Value = Drow["SchedID"].ToString();
                dgvSched.Rows[num].Cells[1].Value = Drow["SubjectCode"].ToString();
                dgvSched.Rows[num].Cells[2].Value = Drow["CourseID"].ToString();
                dgvSched.Rows[num].Cells[3].Value = Drow["date"].ToString();
                dgvSched.Rows[num].Cells[4].Value = Drow["maxStudent"].ToString();
                dgvSched.Rows[num].Cells[5].Value = Drow["status"].ToString();
                dgvSched.Rows[num].Cells[6].Value = Drow["time start"].ToString();
                dgvSched.Rows[num].Cells[7].Value = Drow["time end"].ToString();


                }




            foreach (DataGridViewRow Myrow in dgvSched.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(Myrow.Cells[6].Value) == "available")// Or your condition 
                {

                    // Myrow.DefaultCellStyle.BackColor = Color.IndianRed;
                    Myrow.DefaultCellStyle.BackColor = Color.White;



                }

                else if (Convert.ToString(Myrow.Cells[6].Value) == "full")
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Orange;
                }

            }

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            addSchedule s = new addSchedule();
            s.Show();
        }
    }
}
