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
    public partial class CourseInformation : Form
    {

        Course course = new Course();
        public CourseInformation()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var myfrm = new AddCourse(this);
            myfrm.ShowDialog();
        }

        private void CourseInformation_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            course.VIEW_DATA();

            dgvCourse.Rows.Clear();
            foreach (DataRow Drow in course.dt.Rows)
            {
                int num = dgvCourse.Rows.Add();

                dgvCourse.Rows[num].Cells[0].Value = Drow["ID"].ToString();
                dgvCourse.Rows[num].Cells[1].Value = Drow["Course"].ToString();
            }
        }

        private void dgvCourse_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var myfrm = new AddCourse(this);


            course.id = dgvCourse.Rows[e.RowIndex].Cells[0].Value.ToString();
            course.PassData();
            myfrm.lblIDD.Text = course.id;
            myfrm.txtDescription.Text = course.description;
            myfrm.txtAbbreviation.Text = course.abbreviation;
            myfrm.btnAddCourse.Text = "Update Data";

            myfrm.ShowDialog();
        }
    }
}