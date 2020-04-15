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
    public partial class formTransaction : Form
    {
        Transaction[] viewTransaction;

        public formTransaction()
        {
            InitializeComponent();
        }

        private void formTransaction_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Content saved - not actually saved yet", "Save", MessageBoxButtons.OK);
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
            viewTransaction = TransactionUtilities.GetAllTransactions();
            listboxTransaction.DataSource = viewTransaction;

        }
    }
}
