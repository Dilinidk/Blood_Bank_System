using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHideandshow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (btnHideandshow.Text == "Show")
            {
                btnHideandshow.Text = "Hide";
                txtPassword.PasswordChar = '\0';


            }
            else
            {
                btnHideandshow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="btechdays" && txtPassword.Text=="Pass")
            {
                DashForm db=new DashForm();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username OR Password.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);          
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)

            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}