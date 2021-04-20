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
    public partial class FeeManagement : Form
    {
        public FeeManagement()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var myfrm = new AddFeeCategory(this);
            myfrm.ShowDialog();
        }

        private void FeeManagement_Load(object sender, EventArgs e)
        {
            displayData();
        }
        
        public void displayData()
        {

            var page1 = DBContext.GetContext().Query("feecategories").Limit(5).Get();
            dgvCategories.Rows.Clear();
;            foreach (var fees in page1)
            {
                dgvCategories.Rows.Add(fees.feeID, fees.category);
            }
        }

        private void dgvCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var myfrm = new AddFeeCategory(this);
            int id = Convert.ToInt32(dgvCategories.Rows[dgvCategories.CurrentRow.Index].Cells[0].Value);
            var fee = DBContext.GetContext().Query("feecategories").Where("feeID", id).First();

            myfrm.lblIDD.Text = id.ToString();
            myfrm.txtCategory.Text = fee.category;
            myfrm.btnAddCategory.Text = "Update Data";
            myfrm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
