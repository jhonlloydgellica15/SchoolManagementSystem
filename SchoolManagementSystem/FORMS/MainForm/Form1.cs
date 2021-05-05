using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SchoolManagementSystem
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            pnlStudentMenu.Visible = false;
            pnlAcademicMenu.Visible = false;
            pnlFeeMenu.Visible = false;
            pnlDeptMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //Side panel colored buttons
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
        }

        private void ActivateButton1(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton1();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = Color.White;
                currentBtn.BackColor = Color.FromArgb(25, 34, 49);
                currentBtn.IconColor = Color.FromArgb(235, 89, 110);
            }
        }

        private void DisableButton1()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(25, 34, 49);
                currentBtn.ForeColor = Color.Gray;
                currentBtn.IconColor = Color.White;
            }
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(45, 50, 61);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.FromArgb(235, 89, 110);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(25, 34, 49);
                currentBtn.ForeColor = Color.Gray;
                currentBtn.IconColor = Color.White;
            }
        }

        private void displayDashboard()
        {
            var myForm = new Dashboard();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }
        private void displayAcademicYear()
        {
            var myForm = new AcademicYear();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void displayStudent()
        {
            var myForm = new StudentInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void displayTeachers()
        {
            var myForm = new TeacherInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void displayLibrarians()
        {
            var myForm = new LibrarianInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void displayAccountants()
        {
            var myForm = new AccountantInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void displayRooms()
        {
            var myForm = new room();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void displayCourse()
        {
            var myForm = new CourseInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void displaySubjects()
        {
            var myForm = new Subject();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }
        private void displayScheduling()
        {
            var myForm = new Sched();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }
        
        private void displayFeeManagement()
        {
            var myForm = new FeeManagement();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void displayFeeStructure()
        {
            var myForm = new FeeStructure();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }
        private void displayDepartment()
        {
            var myForm = new Department();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            displayDashboard();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            displayDashboard();
        }

        private void btnManageSession_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            displayAcademicYear();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlStudentMenu);
        }

        private void btnAdmitStudent_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            displayStudent();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            displayTeachers();
        }

        private void btnLibrarians_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            displayLibrarians();
        }

        private void btnAccountants_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            displayAccountants();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            displayRooms();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            displayCourse();
        }

        private void btnAcademic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlAcademicMenu);
        }

        private void btnScheduling_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color1);
            displayScheduling();
        }

        private void btnFeesManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlFeeMenu);

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            displaySubjects();
        }

        private void btnFeeCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            displayFeeManagement();

        }

        private void btnFeeStructure_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            displayFeeStructure();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlDeptMenu);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            displayCourse();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            displayDepartment();
        }
    }
}
