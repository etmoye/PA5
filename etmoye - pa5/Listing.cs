using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etmoye___pa5
{
    class Listing
    {

        public string listingID;
        public string address;
        public string listingEndDate;
        public string rentalAmount;
        //public string checkoutDate;
        public string ownerEmail;

        public static int count;

        public Listing(string listingID, string address, string listingEndDate, string rentalAmount, string checkoutDate, string ownerEmail)
        {
            this.listingID = listingID;
            this.address = address;
            this.listingEndDate = listingEndDate;
            this.rentalAmount = rentalAmount;
            //this.checkoutDate = checkoutDate;
            this.ownerEmail = ownerEmail;
        }

        public Listing(string listingID, string address, string listingEndDate, string rentalAmount, string ownerEmail)
        {
            this.listingID = listingID;
            this.address = address;
            this.listingEndDate = listingEndDate;
            this.rentalAmount = rentalAmount;
            this.ownerEmail = ownerEmail;
        }

        public Listing()
        {

        }



        public string GetlistingId()
        {
            return listingID;
        }

        //data shadowing - the local variable is covering up the instance of the instance variable 
        public void SetLisingId(string listingID)
        {
            this.listingID = listingID; //since data shadowing you have to use this.name instead of just the variable name
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetListingEndDate()
        {
            return listingEndDate;
        }

        public void SetListingEndDate(string listingEndDate)
        {
            this.listingEndDate = listingEndDate;
        }

        public string GetRentalAmount()
        {
            return rentalAmount;
        }

        public void SetRentalAmount(string rentalAmount)
        {
            this.rentalAmount = rentalAmount;
        }


        public string GetOwnerEmail()
        {
            return ownerEmail;
        }

        public void SetOwnerEmail(string ownerEmail)
        {
            this.ownerEmail = ownerEmail;
        }


        public override string ToString()
        {
            return this.address;
        }

        public string ToFile()
        {
            return listingID + '#' + address + '#' + listingEndDate + '#' + rentalAmount +  '#' + ownerEmail;
        }

        public static int GetCount()
        {
            return count;
        }

        //do not use this. for class vari
        public static void SetCount(int count)
        {
            Listing.count = count;
        }
        public static void IncCount()
        {
            Listing.count++;
        }

        public static explicit operator Listing(int v)
        {
            throw new NotImplementedException();
        }
    }
}
