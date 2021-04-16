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
    public partial class AddTeacher : Form
    {
        Teachers teach = new Teachers();

        TeacherInformation reloadDatagrid;
        public AddTeacher(TeacherInformation reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            if (btnAddTeachers.Text == "Save Teacher")
            {
                teach.lastname = txtLastname.Text;
                teach.firstname = txtFirstname.Text;
                teach.middlename = txtMiddlename.Text;
                teach.age = txtAge.Text;
                teach.dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy");
                teach.placeofbirth = txtPlaceofbirth.Text;
                teach.contactno = txtContactNo.Text;
                teach.gender = cmbGender.Text;
                teach.maritalstatus = cmbMaritalStatus.Text;
                teach.citizenship = txtCitizen.Text;
                teach.religion = txtReligion.Text;
                teach.address = txtAddress.Text;

                teach.CREATE_DATA();
                MessageBox.Show("Inserted");
                reloadDatagrid.displayData();

                this.Close();
            }
            else if (btnAddTeachers.Text == "Update Data")
            {
                teach.id = lblID.Text;
                teach.lastname = txtLastname.Text;
                teach.firstname = txtFirstname.Text;
                teach.middlename = txtMiddlename.Text;
                teach.age = txtAge.Text;
                teach.dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy");
                teach.placeofbirth = txtPlaceofbirth.Text;
                teach.contactno = txtContactNo.Text;
                teach.gender = cmbGender.Text;
                teach.maritalstatus = cmbMaritalStatus.Text;
                teach.citizenship = txtCitizen.Text;
                teach.religion = txtReligion.Text;
                teach.address = txtAddress.Text;

                teach.UPDATE_DATA();
                MessageBox.Show("Updated");
                reloadDatagrid.displayData();

                this.Close();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
