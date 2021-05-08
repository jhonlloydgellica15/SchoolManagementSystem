﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EonBotzLibrary;
using SqlKata.Execution;
namespace SchoolManagementSystem.FORMS.FeeManagement
{
    public partial class addfees : Form
    {
        feeStruc struc = new feeStruc();
        string id;
        string categoryid;
        FeeStructure reloadDatagrid;
        public addfees(string val, string val2, FeeStructure reloadDatagrid)
        {


            InitializeComponent();
            id = val;
            struckname.Text = val2;
            this.reloadDatagrid = reloadDatagrid;
        }

        private void addfees_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            struc.structureID = id;
            struc.viewfees();

            dgvCategories.Rows.Clear();
            foreach (DataRow Drow in struc.dt.Rows)
            {
                int num = dgvCategories.Rows.Add();

                dgvCategories.Rows[num].Cells[0].Value = Drow["category"].ToString();
                dgvCategories.Rows[num].Cells[1].Value = Drow["amount"].ToString();
            }

            textBox1.Text = struc.total;


            struc.viewcategories();

            comboBox1.DataSource = struc.datafill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            struc.category = comboBox1.Text;
            struc.viewcategoryID();
            categoryid = struc.categoryID;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            reloadDatagrid.displayData();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            struc.amount = textBox2.Text;
            struc.categoryID = categoryid;
            struc.structureID = id;

            struc.insertfee();
            displayData();
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewRow rows = dgvCategories.Rows[e.RowIndex];
            string aaa = dgvCategories.SelectedRows[0].Cells[2].Value.ToString();

            if (aaa.Equals("Delete") && Validator.DeleteConfirmation()) 
            {
                deleteFees();
                displayData();
            }
        }

        private void deleteFees()
        {
            string category = dgvCategories.SelectedRows[0].Cells[0].Value.ToString();
            string amount = dgvCategories.SelectedRows[0].Cells[1].Value.ToString();
            struc.getcat = category;
            struc.getid();


            string getcatid = struc.getcatid;

            var value = DBContext.GetContext().Query("totalfee").Where(new
            {
                categoryID = getcatid,
                structureID = id,
                total = amount,
            }).First();
            
            int selTot = value.totalFeeID;
            // MessageBox.Show("aa");
            DBContext.GetContext().Query("totalfee").Where("totalFeeID", selTot).Delete();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
          



        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
