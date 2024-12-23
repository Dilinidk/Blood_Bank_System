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
    public partial class SearchBloodDonorDetails : Form
    {
        function fn = new function();
        public SearchBloodDonorDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBloodDonorDetails_Load(object sender, EventArgs e)
        {
            String Query = "Select*from newDonor";
            DataSet ds=fn.getData(Query);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                String query ="select * from newDonor where city like'"+txtAddress.Text+"%' or address like '"+txtAddress.Text+"%'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
              
                String Query = "Select*from newDonor";
                DataSet ds = fn.getData(Query);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }
    }
}
