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
            if (btnAddRoom.Text.Equals("Update Data"))
            {
                DBContext.GetContext().Query("rooms").Where("roomId", lblIDD.Text).Update(new
                {
                    description = txtDescription.Text,
                });

                MessageBox.Show("Updated");
                reloadDatagrid.displayData();
                this.Close();

            }
            else if (btnAddRoom.Text.Equals("   Save Data"))
            {
                DBContext.GetContext().Query("rooms").Insert(new
                {
                    description = txtDescription.Text
                }); 
                MessageBox.Show("Inserted");
                reloadDatagrid.displayData();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
