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
            TextBox[] inputs = { txtSubjectCode , txtDescriptiveTitle, txtLec, txtLab, txtTotalUnits };

            if (btnAddSubjects.Text.Equals("Update"))
            {
                if (Validator.isEmpty(inputs) && Validator.UpdateConfirmation())
                {
                    DBContext.GetContext().Query("subjects").Where("subjectId", lblIDD.Text).Update(new
                    {
                         subjectCode = txtSubjectCode.Text,
                         subjectTitle = txtDescriptiveTitle.Text,

                    });
                    reloadDatagrid.displayData();
                    this.Close();
                }
            }
            else if (btnAddSubjects.Text.Equals("Save"))
            {
                if (Validator.isEmpty(inputs) && Validator.AddConfirmation())
                {

                    DBContext.GetContext().Query("subjects").Insert(new
                    {
                        subjectCode = txtSubjectCode.Text,
                        subjectTitle = txtDescriptiveTitle.Text,
                        lec = txtLec.Text,
                        lab = txtLab.Text,
                        unit = txtTotalUnits.Text,
                        prereq = cmbPreReq.Text
                    });
                    reloadDatagrid.displayData();
                    this.Close();

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtLab_TextChanged(object sender, EventArgs e)
        {
           
                txtTotalUnits.Text = txtLab.Text;
            

            if (!string.IsNullOrEmpty(txtLab.Text) && !string.IsNullOrEmpty(txtLec.Text))
                txtTotalUnits.Text = (Convert.ToInt32(txtLab.Text) + Convert.ToInt32(txtLec.Text)).ToString();
        }

        private void txtLec_TextChanged(object sender, EventArgs e)
        {
            
            txtTotalUnits.Text = txtLec.Text;
            

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

        private void txtLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtLec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
