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
    public partial class formTransaction : Form
    {
        private Transaction viewTransaction;
        //Listing[] viewListing;

        string listingID;
        string rentAmount;
        string ownerEmail;
        public formTransaction()
        {
           
            InitializeComponent();
          
        }

        public formTransaction(Object tempTransaction, string listingID, string rentAmount, string ownerEmail)
        {
            this.listingID = listingID;
            this.rentAmount = rentAmount;
            this.ownerEmail = ownerEmail;
            //viewTransaction = new Transaction[500];
            viewTransaction = (Transaction)tempTransaction;
            InitializeComponent();
        }



        private void formTransaction_Load(object sender, EventArgs e)
        {
            txtboxListingID.Text = listingID;
            txtboxRentAmount.Text = rentAmount;
            txtboxOwnerEmail.Text = ownerEmail;
            LoadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Transaction[] viewTransactions = new Transaction[100];

            viewTransaction.listingID = txtboxListingID.Text;
            viewTransaction.renterName = txtboxRenterName.Text;
            viewTransaction.renterEmail = txtboxRenterEmail.Text;
            viewTransaction.rentDate = txboxRentDate.Text;
            viewTransaction.rentAmount = txtboxRentAmount.Text;
            viewTransaction.checkoutDate = txtboxCheckout.Text;
            viewTransaction.ownerEmail = txtboxOwnerEmail.Text;

            StreamWriter outfile = new StreamWriter("transactions.txt", true); //("output.txt", true) use if you want to append
            outfile.WriteLine(viewTransaction.listingID + "#" + viewTransaction.renterName + "#" + viewTransaction.renterEmail + "#" + viewTransaction.rentDate + "#" + viewTransaction.rentAmount + "#" + viewTransaction.checkoutDate + "#" + viewTransaction.ownerEmail); // " should show student");

            outfile.Close();
            DialogResult dialogResult = MessageBox.Show("Content saved", "Save", MessageBoxButtons.OK);
            this.Close();
        }

        private void listboxTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transaction viewTransaction = (Transaction)listboxTransaction.SelectedItem;

            txtboxListingID.Text = viewTransaction.listingID;
            txtboxRenterName.Text = viewTransaction.renterName;
            txtboxRenterEmail.Text = viewTransaction.renterEmail;
            txboxRentDate.Text = viewTransaction.rentDate;
            txtboxRentAmount .Text = viewTransaction.rentAmount;
            txtboxCheckout.Text = viewTransaction.checkoutDate;
            txtboxOwnerEmail.Text = viewTransaction.ownerEmail;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxListingID_TextChanged(object sender, EventArgs e)
        {
           // this. =txtboxListingID();
        }

        public void LoadList()
        {
            Transaction[] tempArray = TransactionUtilities.GetAllTransactions(); 
           // viewTransaction = TransactionUtilities.GetAllTransactions();
            listboxTransaction.DataSource = tempArray;

        }
    }
}
