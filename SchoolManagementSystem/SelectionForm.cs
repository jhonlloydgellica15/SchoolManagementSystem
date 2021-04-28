using SchoolManagementSystem.FORMS.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }


        bool isShow;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //    var myfrm = new login_form2();
            //    myfrm.Show();
            //    this.Hide();

           
                isShow = true;
                pnlSlide2.Show();
                timer.Start();
            

        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            pnlSlide2.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                if (pnlSlide2.Width >= 1200)
                    timer.Stop();
                pnlSlide2.Width += 100;
            }
            else
            {
                if (pnlSlide2.Width <= 0)
                {
                    pnlSlide2.Hide();
                    timer.Stop();
                }

                pnlSlide2.Width -= 100;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlSlide2.Visible)
            {
                isShow = false;
                timer.Start();
            }
        }
    }
}
