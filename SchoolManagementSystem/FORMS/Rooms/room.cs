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
    public partial class room : Form
    {
        Room rom = new Room();
        public room()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            var myrfrm = new AddRoom(this);
            myrfrm.ShowDialog();
        }

        private void room_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            rom.VIEW_DATA();

            dgvRooms.Rows.Clear();
            foreach (DataRow Drow in rom.dt.Rows)
            {
                int num = dgvRooms.Rows.Add();

                dgvRooms.Rows[num].Cells[0].Value = Drow["ID"].ToString();
                dgvRooms.Rows[num].Cells[1].Value = Drow["Description"].ToString();
            }
        }

        private void dgvRooms_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var myfrm = new AddRoom(this);


            rom.id = dgvRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
            rom.PassData();
            myfrm.lblIDD.Text = rom.id;
            myfrm.txtDescription.Text = rom.description;
            myfrm.btnAddRoom.Text = "Update Data";

            myfrm.ShowDialog();
        }
    }
}
