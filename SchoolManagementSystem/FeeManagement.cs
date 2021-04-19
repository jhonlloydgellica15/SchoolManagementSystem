using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            var myfrm = new AddFeeCategory();
            myfrm.ShowDialog();
        }
    }
}
