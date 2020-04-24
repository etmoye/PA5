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
        private Transaction[] viewTransaction;

        public formListings()
        {
            InitializeComponent();
            viewListing = new Listing[500];
            listingUtils = new ListingUtilities(viewListing);
            viewTransaction = new Transaction[100];
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            Listing viewListing = (Listing)listboxListings.SelectedItem;
            string delete = txtboxListingID.Text;
            int deleteID = listingUtils.SearchByID(delete);
            listingUtils.DeleteListing(deleteID);
            formEditListing editListings = new formEditListing(viewListing);
            if (editListings.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //listingUtils.SaveListing();
                LoadList();
            }

            
            //string delete = txtboxListingID.Text;
            //int deleteID = listingUtils.SearchByID(delete);
            //listingUtils.DeleteListing(deleteID);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
            Listing viewListing = new Listing();
            formNewListing newListing = new formNewListing(viewListing);
            if (newListing.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //listingUtils.SaveListing();
                //LoadList();
            }
        }
        private void btnRent_Click(object sender, EventArgs e)
        {

            Listing viewListing = (Listing)listboxListings.SelectedItem;
            
            txtboxListingID.Text = viewListing.listingID;
            txtboxRentAmount.Text = viewListing.rentalAmount;
            txtboxOwnerEmail.Text = viewListing.ownerEmail;

            Transaction viewTransaction = new Transaction();
            int remove = int.Parse(viewListing.listingID);
            listingUtils.DeleteListing(remove);

            //Transaction viewTransaction = (Transaction)listboxListings.SelectedItem;
            //Transaction viewTransaction = (Transaction)listboxListings.SelectedItem;
            formTransaction  currentTransaction = new formTransaction(viewTransaction, viewListing.listingID, viewListing.rentalAmount, viewListing.ownerEmail);
            if (currentTransaction.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
              // LoadList();
            }

            formListings updateListing = new formListings();
            if (updateListing.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public void LoadList()
        {
            listingUtils.GetAllListing();
            listboxListings.DataSource = viewListing;

            

        }

        private void listboxListings_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Listing viewListing = (Listing)listboxListings.SelectedItem;

            txtboxListingID.Text = viewListing.listingID;
            txtboxAddress.Text = viewListing.address;
            txtboxEndDate.Text = viewListing.listingEndDate;
            txtboxRentAmount.Text = viewListing.rentalAmount;
            txtboxOwnerEmail.Text = viewListing.ownerEmail;
          
        }

        private void txtboxListingID_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Listing viewListing = (Listing)listboxListings.SelectedItem;
            string searchVal = viewListing.listingID;

            int deleteID = listingUtils.SearchByID(searchVal);
            listingUtils.DeleteListing(deleteID);
            listingUtils.GetAllListing();
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this listing?", "Delete", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LoadList();
            }

            formListings showListings = new formListings();
            if (showListings.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //LoadList();
            }
        }

        private void formListings_Load(object sender, EventArgs e)
        {

            LoadList();

        }

        private void txtboxEndDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEndDate_Click(object sender, EventArgs e)
        {

        }

     
    }
}
