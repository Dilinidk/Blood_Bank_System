using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class AddNewDonor : Form

    {

        function fn = new function();



        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {


            String query = " Select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count + 1).ToString();
        }

        private void btnSAVe_Click(object sender, EventArgs e)
        {


            if (txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" && txtAddress.Text != "") ;
            {
                String dname = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String dob = txtDOB.Text;

                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String bgroup = txtBloodGroup.Text;
                String city = txtCity.Text;
                String address = txtAddress.Text;
                string mobileText = txtMobile.Text;
                if (Int64.TryParse(mobileText, out long mobile))
                {
                   
                    String query = "insert into newDonor(dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,address) VALUES ('" + dname + "','" + fname + "','" + mname + "','" + dob + "','" + mobile + "','" + gender + "','" + email + "','" + bgroup + "','" + city + "','" + address + "')";
                    fn.setDate(query);
                }
                else

                {
                    MessageBox.Show("Fill all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void btnReset_Click(object sender, EventArgs e)
 {
     txtName.Clear();
     txtFather.Clear();
     txtMother.Clear();
     txtDOB.ResetText();
     txtMobile.Clear();
     txtGender.ResetText();
     txtEmail.Clear();
     txtBloodGroup.ResetText();
     txtCity.Clear();
     txtAddress.Clear();
 }
        }



}