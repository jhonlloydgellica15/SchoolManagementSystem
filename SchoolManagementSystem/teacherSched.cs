using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EonBotzLibrary;
using SqlKata.Execution;
namespace SchoolManagementSystem
{
    public partial class teacherSched : Form
    {
    

        public teacherSched( )
        {
     
            InitializeComponent();
       
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addTeacherScheduling add = new addTeacherScheduling(this);
            add.Show();
        }

        private void teacherSched_Load(object sender, EventArgs e)
        {
            var values = DBContext.GetContext().Query("teachers").Get();

            foreach (var value in values)
            {
                comboBox1.Items.Add(value.teacherId);
            }
        }
    }
}
