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
    public partial class AddSubject : Form
    {
        Subjects subj = new Subjects();

        Subject reloadDatagrid;
        public AddSubject(Subject reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnAddSubjects_Click(object sender, EventArgs e)
        {
            
            if (btnAddSubjects.Text == "   Save Data")
            {
                subj.subjCode = txtSubjectCode.Text;
                subj.subjTitle = txtDescriptiveTitle.Text;
                subj.lec = txtLec.Text;
                subj.lab = txtLab.Text;
                subj.unit = txtTotalUnits.Text;
                subj.prereq = cmbPreReq.Text;
               
               
                subj.CREATE_DATA();
                MessageBox.Show("Inserted");
                reloadDatagrid.displayData();

                this.Close();
            }
            else if (btnAddSubjects.Text == "Update Data")
            {
                subj.id = lblIDD.Text;
                subj.subjCode = txtSubjectCode.Text;
                subj.subjTitle = txtDescriptiveTitle.Text;
                subj.lec = txtLec.Text;
                subj.lab = txtLab.Text;
                subj.unit = txtTotalUnits.Text;
                subj.prereq = cmbPreReq.Text;

                subj.UPDATE_DATA();
                MessageBox.Show("Updated");
                reloadDatagrid.displayData();

                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtLab_TextChanged(object sender, EventArgs e)
        {
             
            if (txtLab.Text == "")
            {
                txtTotalUnits.Text = txtLec.Text;
            }

            if (!string.IsNullOrEmpty(txtLec.Text) && !string.IsNullOrEmpty(txtLab.Text))
                txtTotalUnits.Text = (Convert.ToInt32(txtLec.Text) + Convert.ToInt32(txtLab.Text)).ToString();
           

        }

        private void txtLec_TextChanged(object sender, EventArgs e)
        {
            if (txtLec.Text == "")
            {
                txtTotalUnits.Text = txtLab.Text;
            }

            if (!string.IsNullOrEmpty(txtLec.Text) && !string.IsNullOrEmpty(txtLab.Text))
                txtTotalUnits.Text = (Convert.ToInt32(txtLec.Text) + Convert.ToInt32(txtLab.Text)).ToString();
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
        }

        private void txtLec_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtLab_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtLec_Leave(object sender, EventArgs e)
        {
        }
    }
}
