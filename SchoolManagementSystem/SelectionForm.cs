﻿using SchoolManagementSystem.FORMS.MainForm;
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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }


        bool isShow;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            isShow = true;
            timer.Start();
            pnlSlide2.Show();
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
                pnlSlide2.Width += 500;
            }
            else
            {
                if (pnlSlide2.Width <= 0)
                {
                    pnlSlide2.Hide();
                    timer.Stop();
                }

                pnlSlide2.Width -= 500;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (pnlSlide2.Visible)
            {
                isShow = false;
                timer.Start();
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                var query = DBContext.GetContext().Query("users").Where(new
                {
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                }).FirstOrDefault();


                if (query.userrole.Equals(1))
                {
                    this.Hide();
                    var myfrm = new Form1();
                    myfrm.Show();
                }
                else if (query.userrole == 2)
                {
                    MessageBox.Show("Welcome Registrar");
                }
                else if (query.userrole == 3)
                {
                    MessageBox.Show("Welcome Cashier");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}