using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EonBotzLibrary;
using SqlKata.Execution;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem.FORMS.MainForm
{
    public partial class login_form2 : Form
    {
        public login_form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void username_txt_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void login_form2_Load(object sender, EventArgs e)
        {

        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            string holdvalue;
            //SELECT id, username, password, role.roletype from smsdb.users
            //inner join smsdb.role on users.userrole = role.roleid where username = 'lloyd' and password = '123';


            try
            {
                var query = DBContext.GetContext().Query("users").Where(new
                {
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                }).FirstOrDefault();


                if (query.userrole.Equals(1))
                {
                    this.Dispose();
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

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
