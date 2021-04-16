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
        private Panel leftBorderBtn;
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pnlInsideMenu.Controls.Add(leftBorderBtn);
        }

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
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(235, 89, 110);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.FromArgb(235, 89, 110);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(25, 34, 49);
                currentBtn.ForeColor = Color.Gray;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }



        private void hideSubMenu()
        {
            pnlSubmenu.Visible = false;
            pnlInideSubSettings.Visible = false;
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

        private void btnStudents_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlSubmenu);
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlInideSubSettings);
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            var myForm = new Dashboard();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnManageSession_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            var myForm = new ManageSession();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            var myForm = new TeacherInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnLibrarians_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            var myForm = new LibrarianInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnAccountants_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            var myForm = new AccountantInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            var myForm = new room();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            var myForm = new CourseInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color1);

            var myForm = new Subject();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color1);
        }

        private void btnAdmitStudent_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color1);

            var myForm = new StudentInformation();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, RGBColors.color1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var myForm = new Dashboard();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnScheduling_Click(object sender, EventArgs e)
        {
            var myForm = new Sched();
            pnlShow.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
