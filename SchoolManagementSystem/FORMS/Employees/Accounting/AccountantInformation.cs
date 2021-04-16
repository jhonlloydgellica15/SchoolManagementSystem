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
    public partial class AccountantInformation : Form
    {

        Accountants acc = new Accountants();
        public AccountantInformation()
        {
            InitializeComponent();
        }

        private void btnAddAccountant_Click(object sender, EventArgs e)
        {
            var myform = new AddAccountant(this);
            myform.ShowDialog();
        }

        private void AccountantInformation_Load(object sender, EventArgs e)
        {
            displayData();
        }


        public void displayData()
        {
            acc.VIEW_DATA();

            dgvAccountant.Rows.Clear();
            foreach (DataRow Drow in acc.dt.Rows)
            {
                int num = dgvAccountant.Rows.Add();

                dgvAccountant.Rows[num].Cells[0].Value = Drow["ID"].ToString();
                dgvAccountant.Rows[num].Cells[1].Value = Drow["Lastname"].ToString();
                dgvAccountant.Rows[num].Cells[2].Value = Drow["Firstname"].ToString();
                dgvAccountant.Rows[num].Cells[3].Value = Drow["Middlename"].ToString();
                dgvAccountant.Rows[num].Cells[4].Value = Drow["Age"].ToString();
                dgvAccountant.Rows[num].Cells[5].Value = Drow["DateOfBirth"].ToString();
                dgvAccountant.Rows[num].Cells[6].Value = Drow["PlaceOfBirth"].ToString();
                dgvAccountant.Rows[num].Cells[7].Value = Drow["ContactNo"].ToString();
                dgvAccountant.Rows[num].Cells[8].Value = Drow["Gender"].ToString();
                dgvAccountant.Rows[num].Cells[9].Value = Drow["MaritalStatus"].ToString();
                dgvAccountant.Rows[num].Cells[10].Value = Drow["Citizen"].ToString();
                dgvAccountant.Rows[num].Cells[11].Value = Drow["Religion"].ToString();
                dgvAccountant.Rows[num].Cells[12].Value = Drow["Address"].ToString();
            }
        }

        private void dgvAccountant_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var myfrm = new AddAccountant(this);


            acc.id = dgvAccountant.Rows[e.RowIndex].Cells[0].Value.ToString();
            acc.PassData();
            myfrm.lblID.Text = acc.id;
            myfrm.txtLastname.Text = acc.lastname;
            myfrm.txtFirstname.Text = acc.firstname;
            myfrm.txtMiddlename.Text = acc.middlename;
            myfrm.txtAge.Text = acc.age;
            myfrm.dtpDateofbirth.Text = acc.dateofbirth;
            myfrm.txtPlaceofbirth.Text = acc.placeofbirth;
            myfrm.txtContactNo.Text = acc.contactno;
            myfrm.cmbGender.Text = acc.gender;
            myfrm.cmbMaritalStatus.Text = acc.maritalstatus;
            myfrm.txtCitizen.Text = acc.citizenship;
            myfrm.txtReligion.Text = acc.religion;
            myfrm.txtAddress.Text = acc.address;
            myfrm.btnAddAccountant.Text = "Update Data";

            myfrm.ShowDialog();
        }
    }
}
