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
    public partial class Subject : Form
    {
        Subjects subj = new Subjects();
        public Subject()
        {
            InitializeComponent();
        }

        private void btnAddSybject_Click(object sender, EventArgs e)
        {
            var myfrm = new AddSubject(this);
            myfrm.ShowDialog();
        }

        private void dgvSubjects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var myfrm = new AddSubject(this);


            subj.id = dgvSubjects.Rows[e.RowIndex].Cells[0].Value.ToString();
            subj.PassData();
            myfrm.lblIDD.Text = subj.id;
            myfrm.txtSubjectCode.Text = subj.subjCode;
            myfrm.txtDescriptiveTitle.Text = subj.subjTitle;
            myfrm.txtLec.Text = subj.lec;
            myfrm.txtLab.Text = subj.lab;
            myfrm.txtTotalUnits.Text = subj.unit;
            myfrm.cmbPreReq.Text = subj.prereq;
            myfrm.btnAddSubjects.Text = "Update Data";

            myfrm.ShowDialog();
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            displayData();
        }
        public void displayData()
        {
            subj.VIEW_DATA();

            dgvSubjects.Rows.Clear();
            foreach (DataRow Drow in subj.dt.Rows)
            {
                int num = dgvSubjects.Rows.Add();

                dgvSubjects.Rows[num].Cells[0].Value = Drow["ID"].ToString();
                dgvSubjects.Rows[num].Cells[1].Value = Drow["SubjectCode"].ToString();
                dgvSubjects.Rows[num].Cells[2].Value = Drow["SubjectTitle"].ToString();
                dgvSubjects.Rows[num].Cells[3].Value = Drow["Lec"].ToString();
                dgvSubjects.Rows[num].Cells[4].Value = Drow["Lab"].ToString();
                dgvSubjects.Rows[num].Cells[5].Value = Drow["TotalUnits"].ToString();
                dgvSubjects.Rows[num].Cells[6].Value = Drow["PreReq"].ToString();
            }
        }
    }
}
