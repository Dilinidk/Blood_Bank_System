using System;
using System.Collections;
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
    public partial class SearchDonorByBlood : Form
    {
        function fs = new function();

        String query;
        public SearchDonorByBlood()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void SearchDonorByBlood_Load(object sender, EventArgs e)
        {
           
    {
               query = "select * from newDonor";
                DataSet ds = fs.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void SearchBlood_Click(object sender, EventArgs e)
        {  if(txtBlood.Text!="")
            {
                query = "select * from newDonor where bloodgroup Like'" + txtBlood.Text + "%'";
                DataSet ds = fs.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from newDonor";
                DataSet ds = fs.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
       
  
