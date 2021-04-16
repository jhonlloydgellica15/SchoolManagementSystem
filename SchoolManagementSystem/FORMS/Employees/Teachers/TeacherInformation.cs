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
    public partial class TeacherInformation : Form
    {

        Teachers teach = new Teachers();
        public TeacherInformation()
        {
            InitializeComponent();
        }

        private void TeacherInformation_Load(object sender, EventArgs e)
        {
            displayData();


        }

        public void displayData()
        {
            teach.VIEW_DATA();

            dgvTeachers.Rows.Clear();
            foreach (DataRow Drow in teach.dt.Rows)
            {
                int num = dgvTeachers.Rows.Add();

                dgvTeachers.Rows[num].Cells[0].Value = Drow["ID"].ToString();
                dgvTeachers.Rows[num].Cells[1].Value = Drow["Lastname"].ToString();
                dgvTeachers.Rows[num].Cells[2].Value = Drow["Firstname"].ToString();
                dgvTeachers.Rows[num].Cells[3].Value = Drow["Middlename"].ToString();
                dgvTeachers.Rows[num].Cells[4].Value = Drow["Age"].ToString();
                dgvTeachers.Rows[num].Cells[5].Value = Drow["DateOfBirth"].ToString();
                dgvTeachers.Rows[num].Cells[6].Value = Drow["PlaceOfBirth"].ToString();
                dgvTeachers.Rows[num].Cells[7].Value = Drow["ContactNo"].ToString();
                dgvTeachers.Rows[num].Cells[8].Value = Drow["Gender"].ToString();
                dgvTeachers.Rows[num].Cells[9].Value = Drow["MaritalStatus"].ToString();
                dgvTeachers.Rows[num].Cells[10].Value = Drow["Citizen"].ToString();
                dgvTeachers.Rows[num].Cells[11].Value = Drow["Religion"].ToString();
                dgvTeachers.Rows[num].Cells[12].Value = Drow["Address"].ToString();
            }
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            var myform = new AddTeacher(this);
            myform.ShowDialog();
        }

        private void dgvTeachers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var myfrm = new AddTeacher(this);


            teach.id = dgvTeachers.Rows[e.RowIndex].Cells[0].Value.ToString();
            teach.PassData();
            myfrm.lblID.Text = teach.id;
            myfrm.txtLastname.Text = teach.lastname;
            myfrm.txtFirstname.Text = teach.firstname;
            myfrm.txtMiddlename.Text = teach.middlename;
            myfrm.txtAge.Text = teach.age;
            myfrm.dtpDateofbirth.Text = teach.dateofbirth;
            myfrm.txtPlaceofbirth.Text = teach.placeofbirth;
            myfrm.txtContactNo.Text = teach.contactno;
            myfrm.cmbGender.Text = teach.gender;
            myfrm.cmbMaritalStatus.Text = teach.maritalstatus;
            myfrm.txtCitizen.Text = teach.citizenship;
            myfrm.txtReligion.Text = teach.religion;
            myfrm.txtAddress.Text = teach.address;
            myfrm.btnAddTeachers.Text = "Update Data";

            myfrm.ShowDialog();
        }
    }
}
