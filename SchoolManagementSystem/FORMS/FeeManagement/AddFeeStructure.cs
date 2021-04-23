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
    public partial class AddFeeStructure : Form
    {
        int aa;
        public AddFeeStructure()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            TextBox[] inputs = { txtDescrip, txtStruct };
            if (btnAddCourse.Text.Equals("   Save Data"))
            {
                if (!Validator.isEmpty(inputs))
                {
                    if (Validator.AddConfirmation())
                    {
                        if (!Validator.TextMin(inputs[0], 3) && !Validator.TextMin(inputs[1], 2))
                        {
                            DBContext.GetContext().Query("feestructure").Insert(new
                            {
                                structurename = txtStruct.Text,
                                description = txtDescrip.Text,

                            });

                            //var result = DBContext.GetContext().Query("feestructure").Where("structureName", txtStruct.Text).First();
                            var rooms = DBContext.GetContext().Query("feestructure").Where("structureName", txtStruct.Text).First();

                            aa = rooms.structureID;

                            DBContext.GetContext().Query("totalfee").Insert(new
                            {
                                structureID = aa,

                            });
                            this.Close();
                        }
                    }
                }
            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
