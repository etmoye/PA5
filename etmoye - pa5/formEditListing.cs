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
    public partial class formEditListing : Form
    {
        private Listing viewListing;
        Listing[] listingArray;
        ListingUtilities listingUtils;

        public formEditListing(Object tempListing) //pass in generic object
        {
            viewListing = (Listing)tempListing;
            listingUtils = new ListingUtilities(listingArray);
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
            outfile.WriteLine(viewListing.listingID + "#" + viewListing.address + "#" + viewListing.listingEndDate + "#" + viewListing.rentalAmount + "#" +viewListing.ownerEmail); // " should show student");

            outfile.Close();
            this.Close();

            //int deleteID = listingUtils.SearchByID(searchVal);
            //listingUtils.DeleteListing(deleteID);

            DialogResult dialogResult = MessageBox.Show("Report saved.", "Save", MessageBoxButtons.OK);

            formListings showListings = new formListings();
            if (showListings.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                //LoadList();
            }
            this.Close();

        }
        

        private void formEditListing_Load(object sender, EventArgs e)
        {
            txtboxListingID.Text = viewListing.listingID;
            txtboxAddress.Text = viewListing.address;
            txtboxEndDate.Text = viewListing.listingEndDate;
            txtboxRentAmount.Text = viewListing.rentalAmount;
            txtboxOwnerEmail.Text = viewListing.ownerEmail;

        }


        public int SearchByID(string searchVal)
        {

            int first = 0;
            int last = Listing.GetCount() - 1;
            int mid = (first + last) / 2;

            while (last >= first)
            {
                if ((listingArray[mid].GetlistingId()) == searchVal)
                {
                    return mid;
                }
                if (int.Parse(listingArray[mid].GetlistingId()) > int.Parse(searchVal))
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
                mid = (first + last) / 2;

            }

            return -1;
        }

        public void DeleteListing(int deleteID)
        {
            StreamWriter outfile = new StreamWriter("listings.txt");

            for (int i = 0; i < Listing.GetCount() - 1; i++)
            {
                if (listingArray[i] == listingArray[deleteID])
                {
                    for (i = deleteID; i < Listing.GetCount() - 1; i++)
                    {
                        listingArray[i] = listingArray[i + 1];
                    }
                }

            }
            for (int j = 0; j < Listing.GetCount() - 1; j++)
            {
                outfile.WriteLine(listingArray[j].ToFile());
            }
            outfile.Close();
        }


    }
}
