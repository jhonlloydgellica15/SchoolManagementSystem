using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class FeeStructure : Form
    {
        public FeeStructure()
        {
            InitializeComponent();
        }

        private void btnAddFeeStruc_Click(object sender, EventArgs e)
        {
            var myfrm = new AddFeeStructure();
            myfrm.ShowDialog();
        }
    }
}
