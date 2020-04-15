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
    public partial class formNewListing : Form
    {
        private Listing currentListing;

        public formNewListing()
        {
           // currentListing = (Listing)tempListing;
            InitializeComponent();
        }

        private void txtboxListingID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            currentListing.listingID = txtboxListingID.Text; //object reference not set to an instance of the object 
            currentListing.address = txtboxAddress.Text;
            currentListing.listingEndDate = txtboxEndDate.Text;
            currentListing.rentalAmount = txtboxRentAmount.Text;
            currentListing.ownerEmail = txtboxOwnerEmail.Text;

            //ListingUtilities.SaveListing(viewListings);


            DialogResult dialogResult = MessageBox.Show("Content saved - not actually saved ", "Save", MessageBoxButtons.OK);
            this.Close();
        }

        private void formNewListing_Load(object sender, EventArgs e)
        {

        }
    }
}
