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
    public partial class LibrarianInformation : Form
    {
        Librarians lib = new Librarians();
        public LibrarianInformation()
        {
            InitializeComponent();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            var myform = new AddLibrarian(this);
            myform.ShowDialog();
        }

        private void LibrarianInformation_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            lib.VIEW_DATA();

            dgvLibrarians.Rows.Clear();
            foreach (DataRow Drow in lib.dt.Rows)
            {
                int num = dgvLibrarians.Rows.Add();

                dgvLibrarians.Rows[num].Cells[0].Value = Drow["ID"].ToString();
                dgvLibrarians.Rows[num].Cells[1].Value = Drow["Lastname"].ToString();
                dgvLibrarians.Rows[num].Cells[2].Value = Drow["Firstname"].ToString();
                dgvLibrarians.Rows[num].Cells[3].Value = Drow["Middlename"].ToString();
                dgvLibrarians.Rows[num].Cells[4].Value = Drow["Age"].ToString();
                dgvLibrarians.Rows[num].Cells[5].Value = Drow["DateOfBirth"].ToString();
                dgvLibrarians.Rows[num].Cells[6].Value = Drow["PlaceOfBirth"].ToString();
                dgvLibrarians.Rows[num].Cells[7].Value = Drow["ContactNo"].ToString();
                dgvLibrarians.Rows[num].Cells[8].Value = Drow["Gender"].ToString();
                dgvLibrarians.Rows[num].Cells[9].Value = Drow["MaritalStatus"].ToString();
                dgvLibrarians.Rows[num].Cells[10].Value = Drow["Citizen"].ToString();
                dgvLibrarians.Rows[num].Cells[11].Value = Drow["Religion"].ToString();
                dgvLibrarians.Rows[num].Cells[12].Value = Drow["Address"].ToString();
            }
        }

        private void dgvLibrarians_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var myfrm = new AddLibrarian(this);


            lib.id = dgvLibrarians.Rows[e.RowIndex].Cells[0].Value.ToString();
            lib.PassData();
            myfrm.lblID.Text = lib.id;
            myfrm.txtLastname.Text = lib.lastname;
            myfrm.txtFirstname.Text = lib.firstname;
            myfrm.txtMiddlename.Text = lib.middlename;
            myfrm.txtAge.Text = lib.age;
            myfrm.dtpDateofbirth.Text = lib.dateofbirth;
            myfrm.txtPlaceofbirth.Text = lib.placeofbirth;
            myfrm.txtContactNo.Text = lib.contactno;
            myfrm.cmbGender.Text = lib.gender;
            myfrm.cmbMaritalStatus.Text = lib.maritalstatus;
            myfrm.txtCitizen.Text = lib.citizenship;
            myfrm.txtReligion.Text = lib.religion;
            myfrm.txtAddress.Text = lib.address;
            myfrm.btnAddLibrarian.Text = "Update Data";

            myfrm.ShowDialog();
        }
    }
}
