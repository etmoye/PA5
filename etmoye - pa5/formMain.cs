using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etmoye___pa5
{
    public partial class formMain : Form
    {


        public formMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnNewListing_Click(object sender, EventArgs e)
        {

            formNewListing showListings = new formNewListing();
            if (showListings.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //LoadList();
            }

        }

        private void btnListings_Click(object sender, EventArgs e)
        {
            formListings showListings = new formListings();
            if (showListings.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //LoadList();
            }

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            formTransaction showTransactions = new formTransaction();
            if (showTransactions.ShowDialog() == DialogResult.OK)
            {

            }
            else 
            { 
                //LoadList();
            }

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            formReport showReports = new formReport();
            if (showReports.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //LoadList();
            }
        }

        private void btnListings_Click_1(object sender, EventArgs e)
        {

            formListings showListings = new formListings();
            if (showListings.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //LoadList();
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
