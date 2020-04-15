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
    
    public partial class formListings : Form
    {
        Listing[] viewListing;
        ListingUtilities listingUtils; //declare as part of the class 

        public formListings()
        {
            InitializeComponent();
            listingUtils = new ListingUtilities(viewListing);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            
            formTransaction  currentTransaction = new formTransaction();
            if (currentTransaction.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
               LoadList();
            }
        }

        public void LoadList()
        {
            listingUtils.GetAllListing();
            listboxListings.DataSource = viewListing;

        }

        private void listboxListings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Listing> listingsList = ProcessFiles.GetAllListing();
            //ProcessFiles.GetAllListing();
            //Listing currentListing = (Listing)listboxListings.SelectedItem;

            //ProcessFiles.GetAllListing() = (Listing)listboxListings.SelectedItem;
            //List<Listing> listingsList = ProcessFiles.GetAllListing();
            //LoadList();
            Listing viewListing = (Listing)listboxListings.SelectedItem;

            txtboxListingID.Text = viewListing.listingID;
            txtboxAddress.Text = viewListing.address;
            txtboxEndDate.Text = viewListing.listingEndDate;
            txtboxRentAmount.Text = viewListing.rentalAmount;
            txtboxOwnerEmail.Text = viewListing.ownerEmail;
            //LoadList();
            //once i close this and reopen it the text does not come back
        }

        private void txtboxListingID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Listing viewListing = (Listing)listboxListings.SelectedItem;
            formEditListing editListings = new formEditListing(viewListing);
            if (editListings.ShowDialog() == DialogResult.OK)
            {
                
            }
            else
            {
                listingUtils.SaveListing();
                LoadList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this listing?", "Delete", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                //call class that has delete method
                //reload the list of listings
            }
            else
            {
                LoadList();
            }
           
        }

        private void formListings_Load(object sender, EventArgs e)
        {
            LoadList();

        }
    }
}
