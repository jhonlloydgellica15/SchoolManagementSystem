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
    public partial class AddCourse : Form
    {
            Course course = new Course();
        CourseInformation reloadDatagrid;
        public AddCourse(CourseInformation reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            if (btnAddCourse.Text == "   Save Data")
            {
                course.description = txtDescription.Text;
                course.abbreviation = txtAbbreviation.Text;

                course.CREATE_DATA();
                MessageBox.Show("Inserted");
                this.Close();
                reloadDatagrid.displayData();
            }
            else if (btnAddCourse.Text == "Update Data")
            {
                course.id = lblIDD.Text;
                course.description = txtDescription.Text;
                course.abbreviation = txtAbbreviation.Text;

                course.UPDATE_DATA();
                MessageBox.Show("Updated");
                reloadDatagrid.displayData();

                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
