using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace etmoye___pa5
{
    public partial class formNewListing : Form
    {
        private Listing viewListing;
        //Listing[] printListing;
        ListingUtilities listingUtils;
        public formNewListing(Object tempListing)
        {
            viewListing = (Listing)tempListing;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Listing[] viewListings = new Listing[100];

            viewListing.listingID = txtboxListingID.Text;
            viewListing.address = txtboxAddress.Text;
            viewListing.listingEndDate = txtboxEndDate.Text;
            viewListing.rentalAmount = txtboxRentAmount.Text;
            viewListing.ownerEmail = txtboxOwnerEmail.Text;

       
            StreamWriter outfile = new StreamWriter("listings.txt", true); //("output.txt", true) use if you want to append
            outfile.WriteLine(viewListing.listingID + "#" + viewListing.address + "#" + viewListing.listingEndDate + "#" + viewListing.rentalAmount + "#"+ viewListing.ownerEmail); // " should show student");

            outfile.Close();


            // ListingUtilities.SaveListing();
            DialogResult dialogResult = MessageBox.Show("Report saved", "Save", MessageBoxButtons.OK);

            this.Close();

            formListings showListings = new formListings();
            if (showListings.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //LoadList();
            }
        }

        

        private void newListing_Load(object sender, EventArgs e)
        {
            //Guid newListingGuid = Guid.NewGuid();
            //txtboxListingID.Text = newListingGuid.ToString();
            int newListing = Listing.GetCount() + 1;
            string countListings = newListing.ToString();
            txtboxListingID.Text = countListings;
        }

        
    }
}
