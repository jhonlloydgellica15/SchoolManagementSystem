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
            TextBox[] inputs = { txtDescription, txtAbbreviation };

            if (btnAddCourse.Text.Equals("Update Data"))
            {
                if (!Validator.isEmpty(inputs))
                {
                    if (Validator.UpdateConfirmation())
                    {
                        DBContext.GetContext().Query("course").Where("courseId", lblIDD.Text).Update(new
                        {
                            description = txtDescription.Text,
                            abbreviation = txtAbbreviation.Text,
                        });
                        reloadDatagrid.displayData();
                        this.Close();
                    }
                }
            }
            else if (btnAddCourse.Text.Equals("   Save Data"))
            {
                if (!Validator.isEmpty(inputs))
                {
                    if (Validator.AddConfirmation())
                    {
                        DBContext.GetContext().Query("course").Insert(new
                        {
                            description = txtDescription.Text,
                            abbreviation = txtAbbreviation.Text,
                        });
                        reloadDatagrid.displayData();
                        this.Close();
                    }
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
