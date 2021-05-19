﻿using System;
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
    public partial class AddTeacher : Form
    {
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
            TextBox[] inputs = { txtLastname, txtFirstname, txtMiddlename, txtPlaceofbirth, txtContactNo, txtCitizen, txtReligion, txtAddress };
            if (btnAddTeachers.Text.Equals("Update"))
            {
                if (Validator.isEmpty(inputs) && Validator.UpdateConfirmation()  && Validator.ValidateDate(dtpDateofbirth))
                {
                    DBContext.GetContext().Query("teachers").Where("teacherId", lblID.Text).Update(new
                    {
                        Lastname = txtLastname.Text,
                        Firstname = txtFirstname.Text,
                        Middlename = txtMiddlename.Text,
                        Dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy"),
                        Placeofbirth = txtPlaceofbirth.Text,
                        ContactNo = txtContactNo.Text,
                        Gender = cmbGender.Text,
                        MaritalStatus = cmbMaritalStatus.Text,
                        Citizenship = txtCitizen.Text,
                        Religion = txtReligion.Text,
                        Address = txtAddress.Text,
                    });
                    reloadDatagrid.displayData();
                    this.Close();
                }
            }
            else if (btnAddTeachers.Text.Equals("Save"))
            {
                if (Validator.isEmpty(inputs) && Validator.AddConfirmation()  && Validator.ValidateDate(dtpDateofbirth))
                {
                    DBContext.GetContext().Query("teachers").Insert(new
                    {
                        Lastname = txtLastname.Text,
                        Firstname = txtFirstname.Text,
                        Middlename = txtMiddlename.Text,
                        Dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy"),
                        Placeofbirth = txtPlaceofbirth.Text,
                        ContactNo = txtContactNo.Text,
                        Gender = cmbGender.Text,
                        MaritalStatus = cmbMaritalStatus.Text,
                        Citizenship = txtCitizen.Text,
                        Religion = txtReligion.Text,
                        Address = txtAddress.Text,
                    });
                    reloadDatagrid.displayData();
                    this.Close();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dtpDateofbirth_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
