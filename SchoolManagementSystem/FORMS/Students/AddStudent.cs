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
    public partial class AddStudent : Form
    {

        Students stud = new Students();

        StudentInformation reloadDatagrid; // reload datagrid 
        public AddStudent(StudentInformation reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            if(btnAddStudent.Text == "   Save Student")
            {
                stud.lastname = txtLastname.Text;
                stud.firstname = txtFirstname.Text;
                stud.middlename = txtMiddlename.Text;
                stud.age = txtAge.Text;
                stud.dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy");
                stud.placeofbirth = txtPlaceofbirth.Text;
                stud.contactno = txtContactNo.Text;
                stud.gender = cmbGender.Text;
                stud.maritalstatus = cmbMaritalStatus.Text;
                stud.citizenship = txtCitizen.Text;
                stud.religion = txtReligion.Text;
                stud.address = txtAddress.Text;

                stud.CREATE_DATA();
                MessageBox.Show("Inserted");
                reloadDatagrid.displayData();

                this.Close();
            }
            else if(btnAddStudent.Text == "Update Student")
            {
                stud.id = lblID.Text;
                stud.lastname = txtLastname.Text;
                stud.firstname = txtFirstname.Text;
                stud.middlename = txtMiddlename.Text;
                stud.age = txtAge.Text;
                stud.dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy");
                stud.placeofbirth = txtPlaceofbirth.Text;
                stud.contactno = txtContactNo.Text;
                stud.gender = cmbGender.Text;
                stud.maritalstatus = cmbMaritalStatus.Text;
                stud.citizenship = txtCitizen.Text;
                stud.religion = txtReligion.Text;
                stud.address = txtAddress.Text;

                stud.UPDATE_DATA();
                MessageBox.Show("Updated");
                reloadDatagrid.displayData();

                this.Close();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaceofbirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCitizen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReligion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
