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
    public partial class DashForm : Form
    {
        public DashForm()
        {
            InitializeComponent();
        }


       
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashForm fm=new DashForm();
            fm.Show();
            this.Hide();
        }



        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();            
            and.Show(); 
        }

       

      private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDEtails add = new AllDonorDEtails();
            add.Show();  
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBloodDonorDetails sba = new SearchBloodDonorDetails();
            sba.Show();

        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByBlood sd = new SearchDonorByBlood();
            sd.Show();
                    }

        private void DashForm_Load(object sender, EventArgs e)
        {

        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
