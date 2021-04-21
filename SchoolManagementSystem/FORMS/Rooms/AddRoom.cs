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
    public partial class AddRoom : Form
    {
        Room room = new Room();

        room reloadDatagrid;
        public AddRoom(room reloadDatagrid)
        {
            InitializeComponent();
            this.reloadDatagrid = reloadDatagrid;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {   
            TextBox[] inputs = { txtDescription, txtDummy1, txtDummy2 };

            if (!Validator.isEmpty(inputs))
            {
                if (btnAddRoom.Text.Equals("Update Data"))
                {
                    if (Validator.UpdateConfirmation())
                    {
                        DBContext.GetContext().Query("rooms").Where("roomId", lblIDD.Text).Update(new
                        {
                            description = txtDescription.Text,
                        });
                    }
                    reloadDatagrid.displayData();
                    this.Close();
                }
            }
            else if (btnAddRoom.Text.Equals("   Save Data"))
            {
               if(!Validator.isEmpty(inputs))
                {
                   if(Validator.AddConfirmation())
                    {
                        if (!Validator.TextMin(inputs[0], null, 3) && !Validator.TextMin(inputs[1], null, 2))
                        {
                            DBContext.GetContext().Query("rooms").Insert(new
                            {
                                description = txtDescription.Text
                            });
                            reloadDatagrid.displayData();
                            this.Close();
                        }
                    }
                }           
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
