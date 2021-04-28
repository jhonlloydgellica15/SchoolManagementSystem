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
    public partial class AddStudent : Form
    {

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

            TextBox[] inputs = { txtLastname, txtFirstname, txtMiddlename, txtAge, txtPlaceofbirth, txtReligion,
            txtCitizen, txtContactNo, txtEmailAddress, txtAddress, txtHomeAddress, txtFatherLname, txtFatherFname,
            txtFatherMname, txtFatherOccupation, txtMotherLname, txtMotherFname, txtMotherMname, txtMotherOccupation,
            txtSchooLast};


            var birth = (chkPsa.Checked) ? 1 : 0;
            var card = (chkReportCard.Checked) ? 1 : 0;
            var honorable = (chkHonorable.Checked) ? 1 : 0;


            if (btnAddStudent.Text.Equals("Update"))
            {
                if (Validator.isEmpty(inputs) && Validator.UpdateConfirmation())
                {
                    DBContext.GetContext().Query("student").Where("studentId", lblID.Text).Update(new
                    {
                        lastname = txtLastname.Text,
                        firstname = txtFirstname.Text,
                        middlename = txtMiddlename.Text,
                        suffix = cmbSuffix.Text,
                        dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy"),
                        age = txtAge.Text,
                        placeofbirth = txtPlaceofbirth.Text,
                        religion = txtReligion.Text,
                        gender = cmbGender.Text,
                        maritalstatus = cmbMaritalStatus.Text,
                        citizenship = txtCitizen.Text,
                        contactno = txtContactNo.Text,
                        emailAddress = txtEmailAddress.Text,
                        course = cmbCourse.Text,
                        presentAddress = txtAddress.Text,
                        homeAddress = txtHomeAddress.Text,
                        fatherLastname = txtFatherLname.Text,
                        fatherFirstname = txtFatherFname.Text,
                        fatherMiddlename = txtFatherMname.Text,
                        fatherOccupation = txtFatherOccupation.Text,
                        motherLastname = txtMotherLname.Text,
                        motherFirstname = txtMotherFname.Text,
                        motherMiddlename = txtMotherMname.Text,
                        motherOccupation = txtMotherOccupation.Text,
                        schoolLastAttended = txtSchooLast.Text,
                        dateLastAttended = dtpLast.Value.ToString("MM/dd/yyyy"),
                    });
                    reloadDatagrid.displayData();
                    this.Close();
                }
            }
            else if (btnAddStudent.Text.Equals("Save"))
            {
                if (Validator.isEmpty(inputs) && Validator.AddConfirmation())
                {
                    DBContext.GetContext().Query("student").Insert(new
                    {
                        lastname = txtLastname.Text,
                        firstname = txtFirstname.Text,
                        middlename = txtMiddlename.Text,
                        suffix = cmbSuffix.Text,
                        dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy"),
                        age = txtAge.Text,
                        placeofbirth = txtPlaceofbirth.Text,
                        religion = txtReligion.Text,
                        gender = cmbGender.Text,
                        maritalstatus = cmbMaritalStatus.Text,
                        citizenship = txtCitizen.Text,
                        contactno = txtContactNo.Text,
                        emailAddress = txtEmailAddress.Text,
                        course = cmbCourse.Text,
                        presentAddress = txtAddress.Text,
                        homeAddress = txtHomeAddress.Text,
                        fatherLastname = txtFatherLname.Text,
                        fatherFirstname = txtFatherFname.Text,
                        fatherMiddlename = txtFatherMname.Text,
                        fatherOccupation = txtFatherOccupation.Text,
                        motherLastname = txtMotherLname.Text,
                        motherFirstname = txtMotherFname.Text,
                        motherMiddlename = txtMotherMname.Text,
                        motherOccupation = txtMotherOccupation.Text,
                        schoolLastAttended = txtSchooLast.Text,
                        dateLastAttended = dtpLast.Value.ToString("MM/dd/yyyy"),
                        psa = birth,
                        reportCard = card,
                        honorableDismissal = honorable,

                    });
                    Validator.AlertSuccess("Success");
                    reloadDatagrid.displayData();
                    this.Close();

                }
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

        private void AddStudent_Load(object sender, EventArgs e)
        {
            txtLastname.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var result =  (checkBox1.Checked) ? txtHomeAddress.Text = txtAddress.Text :  txtHomeAddress.Text = "";
        }
    }
}
