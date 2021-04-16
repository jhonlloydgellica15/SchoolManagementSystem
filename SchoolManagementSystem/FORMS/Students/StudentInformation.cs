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
   
    public partial class StudentInformation : Form
    {
        Students stud = new Students();
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent myform = new AddStudent(this);
            myform.ShowDialog();
        }
        private void StudentInformation_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //stud.VIEW_DATA();
            //dataGridView1.DataSource = stud.dt;

            displayData();
        }

        public void displayData()
        {
            stud.VIEW_DATA();

            dgvStudents.Rows.Clear();
            foreach (DataRow Drow in stud.dt.Rows)
            {
                int num = dgvStudents.Rows.Add();

                dgvStudents.Rows[num].Cells[0].Value = Drow["ID"].ToString();
                dgvStudents.Rows[num].Cells[1].Value = Drow["Lastname"].ToString();
                dgvStudents.Rows[num].Cells[2].Value = Drow["Firstname"].ToString();
                dgvStudents.Rows[num].Cells[3].Value = Drow["Middlename"].ToString();
                dgvStudents.Rows[num].Cells[4].Value = Drow["Age"].ToString();
                dgvStudents.Rows[num].Cells[5].Value = Drow["DateOfBirth"].ToString();
                dgvStudents.Rows[num].Cells[6].Value = Drow["PlaceOfBirth"].ToString();
                dgvStudents.Rows[num].Cells[7].Value = Drow["ContactNo"].ToString();
                dgvStudents.Rows[num].Cells[8].Value = Drow["Gender"].ToString();
                dgvStudents.Rows[num].Cells[9].Value = Drow["MaritalStatus"].ToString();
                dgvStudents.Rows[num].Cells[10].Value = Drow["Citizen"].ToString();
                dgvStudents.Rows[num].Cells[11].Value = Drow["Religion"].ToString();
                dgvStudents.Rows[num].Cells[12].Value = Drow["Address"].ToString();
            }
        }

        private void dgvStudents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var myfrm = new AddStudent(this);

           
            stud.id = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            stud.PassData();
            myfrm.lblID.Text = stud.id;
            myfrm.txtLastname.Text = stud.lastname;
            myfrm.txtFirstname.Text = stud.firstname;
            myfrm.txtMiddlename.Text = stud.middlename;
            myfrm.txtAge.Text = stud.age;
            myfrm.dtpDateofbirth.Text = stud.dateofbirth;
            myfrm.txtPlaceofbirth.Text = stud.placeofbirth;
            myfrm.txtContactNo.Text = stud.contactno;
            myfrm.cmbGender.Text = stud.gender;
            myfrm.cmbMaritalStatus.Text = stud.maritalstatus;
            myfrm.txtCitizen.Text = stud.citizenship;
            myfrm.txtReligion.Text = stud.religion;
            myfrm.txtAddress.Text = stud.address;
            myfrm.btnAddStudent.Text = "Update Student";

            myfrm.ShowDialog();

        }
    }
}
