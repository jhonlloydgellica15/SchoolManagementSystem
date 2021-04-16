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
    public partial class AddLibrarian : Form
    {
        Librarians lib = new Librarians();
        LibrarianInformation reloadDatagrid;
        public AddLibrarian(LibrarianInformation reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddLibrarian_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            if (btnAddLibrarian.Text == "Save Librarian")
            {
                lib.lastname = txtLastname.Text;
                lib.firstname = txtFirstname.Text;
                lib.middlename = txtMiddlename.Text;
                lib.age = txtAge.Text;
                lib.dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy");
                lib.placeofbirth = txtPlaceofbirth.Text;
                lib.contactno = txtContactNo.Text;
                lib.gender = cmbGender.Text;
                lib.maritalstatus = cmbMaritalStatus.Text;
                lib.citizenship = txtCitizen.Text;
                lib.religion = txtReligion.Text;
                lib.address = txtAddress.Text;

                lib.CREATE_DATA();
                MessageBox.Show("Inserted");
                reloadDatagrid.displayData();

                this.Close();
            }
            else if (btnAddLibrarian.Text == "Update Data")
            {
                lib.id = lblID.Text;
                lib.lastname = txtLastname.Text;
                lib.firstname = txtFirstname.Text;
                lib.middlename = txtMiddlename.Text;
                lib.age = txtAge.Text;
                lib.dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy");
                lib.placeofbirth = txtPlaceofbirth.Text;
                lib.contactno = txtContactNo.Text;
                lib.gender = cmbGender.Text;
                lib.maritalstatus = cmbMaritalStatus.Text;
                lib.citizenship = txtCitizen.Text;
                lib.religion = txtReligion.Text;
                lib.address = txtAddress.Text;

                lib.UPDATE_DATA();
                MessageBox.Show("Updated");
                reloadDatagrid.displayData();

                this.Close();
            }
        }
    }
}
