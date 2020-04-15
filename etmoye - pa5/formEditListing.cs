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
    public partial class formEditListing : Form
    {
        private Listing viewListing;
        public formEditListing(Object tempListing) //pass in generic object
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

           // listingU .GetAllListing();

            //ListingUtilities.SaveListing();
            DialogResult dialogResult = MessageBox.Show("Report saved - not actually saved yet", "Save", MessageBoxButtons.OK);
            
            this.Close();
        }

        private void formEditListing_Load(object sender, EventArgs e)
        {
            txtboxListingID.Text = viewListing.listingID;
            txtboxAddress.Text = viewListing.address;
            txtboxEndDate.Text = viewListing.listingEndDate;
            txtboxRentAmount.Text = viewListing.rentalAmount;
            txtboxOwnerEmail.Text = viewListing.ownerEmail;

            //formListings.LoadList(); - NEED TO RELOAD THE LIST, MAY COULD BE DONE IN SAVE METHOD 
            
        }

       
    }
}
