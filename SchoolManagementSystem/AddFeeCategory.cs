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
    public partial class AddFeeCategory : Form
    {

        FeeManagement reloadDatagrid;
        public AddFeeCategory(FeeManagement reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (btnAddCategory.Text.Equals("Update Data"))
            {
                DBContext.GetContext().Query("feecategories").Where("feeID", lblIDD.Text).Update(new
                {
                    category = txtCategory.Text,
                });
                MessageBox.Show("Updated");
                reloadDatagrid.displayData();
                this.Close();
            }
            else if (btnAddCategory.Text.Equals("   Save Data"))
            {
                DBContext.GetContext().Query("feecategories").Insert(new
                {
                    category = txtCategory.Text
                }); ;
                MessageBox.Show("Inserted");
                reloadDatagrid.displayData();
                this.Close();
            }
        }
    }
}
