using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etmoye___pa5
{
    class Transaction
    {
        public string listingID;
        public string renterName;
        public string renterEmail;
        public string rentDate;
        public string rentAmount;
        public string checkoutDate;
        public string ownerEmail;

        public static int count;

        public Transaction(string listingID, string renterName, string renterEmail, string rentDate, string rentAmount, string checkoutDate, string ownerEmail)
        {
            this.listingID = listingID;
            this.renterName = renterName;
            this.renterEmail = renterEmail;
            this.rentDate = rentDate;
            this.rentAmount = rentAmount;
            this.checkoutDate = checkoutDate;
            this.ownerEmail = ownerEmail;
        }

        public Transaction()
        {

        }

        public Transaction(string tempID)
        {
            this.listingID = tempID;
        }

        //public static explicit operator Transaction(ListBox v)
        //{
        //    throw new NotImplementedException();
        //}

        public string GetlistingId()
        {
            return listingID;
        }

        //data shadowing - the local variable is covering up the instance of the instance variable 
        public void SetLisingId(string listingID)
        {
            this.listingID = listingID; //since data shadowing you have to use this.name instead of just the variable name
        }

        public string GetRenterName()
        {
            return renterName;
        }

        public void SetRenterName(string renterName)
        {
            this.renterName = renterName;
        }

        public string GetRenterEmail()
        {
            return renterEmail;
        }

        public void SetRenterEmail(string renterEmail)
        {
            this.renterEmail = renterEmail;
        }

        public string GetRentDate()
        {
            return rentDate;
        }

        public void SetRentDate(string rentDate)
        {
            this.rentDate = rentDate;
        }

        public string GetRentAmount()
        {
            return rentAmount;
        }

        public void SetRentAmount(string rentAmount)
        {
            this.rentAmount = rentAmount;
        }

        public string GetCheckoutDate()
        {
            return checkoutDate;
        }

        public void SetCheckoutDare(string checkoutDate)
        {
            this.checkoutDate = checkoutDate;
        }

        public string GetOwnerEmail()
        {
            return ownerEmail;
        }

        public void SetOwnerEmail(string ownerEmail)
        {
            this.ownerEmail = ownerEmail;
        }


        //DO NOT KNOW IF I NEED THESE SINCE THEY ARE ALSO IN THE LISTINGS.CS CLASS
        public override string ToString()
        {
            return this.renterName;
        }

        public string ToFile()
        {
            return listingID + '#' + renterName + '#' + renterEmail + '#' + rentDate + '#' + rentAmount + '#' + checkoutDate + '#' + ownerEmail;
        }
        public static int GetCount()
        {
            return count;
        }
        public static void IncCount()
        {
            count++;
        }
        public static void SetCount(int count)
        {
            Transaction.count = count;
        }

        public string PrettyFormat()
        { 
            return "Listing ID: "  + listingID + "\nRenter: " + renterName + "\nRenter Email: " + renterEmail + "\nRent Date: " + rentDate + "\nRent Amount: " + rentAmount + "\nCheckout Date: " + checkoutDate + "\nOwner Email: " + ownerEmail + "\n";
        }


    }
}
