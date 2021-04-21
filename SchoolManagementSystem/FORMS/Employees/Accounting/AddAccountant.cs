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
    public partial class AddAccountant : Form
    {
        Accountants acc = new Accountants();

        AccountantInformation reloadDatagrid;
        public AddAccountant(AccountantInformation reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccountant_Click(object sender, EventArgs e)
        {
            TextBox[] inputs = { txtLastname, txtFirstname, txtMiddlename, txtAge,txtPlaceofbirth, txtContactNo, txtCitizen, txtReligion, txtAddress };

            if (btnAddAccountant.Text.Equals("Update Data"))
            {
                if (!Validator.isEmpty(inputs))
                {
                    if (Validator.UpdateConfirmation())
                    {
                        DBContext.GetContext().Query("accountants").Where("accountantId", lblID.Text).Update(new
                        {
                            Lastname = txtLastname.Text,
                            Firstname = txtFirstname.Text,
                            Middlename = txtMiddlename.Text,
                            Age = txtAge.Text,
                            Dateofbirth = dtpDateofbirth.Value.ToString("MM/dd/yyyy"),
                            Placeofbirth = txtPlaceofbirth.Text,
                            ContactNo = txtContactNo.Text,
                            Gender = cmbGender.Text,
                            MaritalStatus = cmbMaritalStatus.Text,
                            Citizenship = txtCitizen.Text,
                            Religion = txtReligion.Text,
                            Address = txtAddress.Text,
                        });
                    }
                    reloadDatagrid.displayData();
                    this.Close();
                }
            }
            else if (btnAddAccountant.Text.Equals("Save Accountant"))
            {
                if (!Validator.isEmpty(inputs))
                {
                    if (Validator.AddConfirmation())
                    {
                        if (!Validator.TextMin(inputs[0], null, 3) && !Validator.TextMin(inputs[1], null, 2))
                        {
                            DBContext.GetContext().Query("accountants").Insert(new
                            {
                                Lastname = txtLastname.Text,
                            });
                            reloadDatagrid.displayData();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
