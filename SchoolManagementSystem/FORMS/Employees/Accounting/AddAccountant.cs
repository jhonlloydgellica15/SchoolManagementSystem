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
    public partial class AddAccountant : Form
    {
        Accountants acc = new Accountants();

        AccountantInformation reloadDatagrid;
        public AddAccountant(AccountantInformation reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccountant_Click(object sender, EventArgs e)
        {
            if (btnAddAccountant.Text == "Save Accountant")
            {
                acc.lastname = txtLastname.Text;
                acc.firstname = txtFirstname.Text;
                acc.middlename = txtMiddlename.Text;
                acc.age = txtAge.Text;
                acc.dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy");
                acc.placeofbirth = txtPlaceofbirth.Text;
                acc.contactno = txtContactNo.Text;
                acc.gender = cmbGender.Text;
                acc.maritalstatus = cmbMaritalStatus.Text;
                acc.citizenship = txtCitizen.Text;
                acc.religion = txtReligion.Text;
                acc.address = txtAddress.Text;

                acc.CREATE_DATA();
                MessageBox.Show("Data registered");
                reloadDatagrid.displayData();

                this.Close();
            }
            else if (btnAddAccountant.Text == "Update Data")
            {
                acc.id = lblID.Text;
                acc.lastname = txtLastname.Text;
                acc.firstname = txtFirstname.Text;
                acc.middlename = txtMiddlename.Text;
                acc.age = txtAge.Text;
                acc.dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy");
                acc.placeofbirth = txtPlaceofbirth.Text;
                acc.contactno = txtContactNo.Text;
                acc.gender = cmbGender.Text;
                acc.maritalstatus = cmbMaritalStatus.Text;
                acc.citizenship = txtCitizen.Text;
                acc.religion = txtReligion.Text;
                acc.address = txtAddress.Text;

                acc.UPDATE_DATA();
                MessageBox.Show("Updated Data");
                reloadDatagrid.displayData();

                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
