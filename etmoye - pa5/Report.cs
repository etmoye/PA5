using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etmoye___pa5
{
    class Report
    {
        Listing[] viewListings;
        Transaction[] viewTransactions;

        //pass the array of get all listings
        //pass the array of all transactions 
        //Control break report for individual customer, historical customer, and historical revenue 

        public Report(Listing[] temp)
        {
            this.viewListings = temp;
        }

        public Report(Transaction[] temp)
        {
            this.viewTransactions = temp;
        }

        //    public void ListingsByEmail(string renterEmail) //need to pass in an email address
        //    {
        //        //instatiate the variables and process the first row
        //        string currentEmail = viewTransactions[0].renterEmail;
        //        int genreCount = 1;

        //        Console.WriteLine(viewTransactions[0].ToString()); //write out first row

        //        //for loop for second row until the end 
        //        for (int i = 1; i < Listing.GetCount(); i++)
        //        {
        //            if (viewTransactions[i].GetGenre() == currentEmail) //check to see if it matches the one before it 
        //            {
        //                Console.WriteLine(viewTransactions[i].ToString());
        //                genreCount++;

        //            }
        //            else
        //            {
        //                //Proceses the break
        //                Console.WriteLine(currentEmail + " count  is : 0" + genreCount); //break line, writing out count for current genre

        //                //resetting two variables
        //                currentEmail = viewTransactions[i].GetGenre();
        //                genreCount = 1;

        //                //writing out the row you are on
        //                Console.WriteLine(viewTransactions[i].ToString());
        //            }
        //        }

        //        //break line - prints last line of file
        //        Console.WriteLine(currentGenre + " count  is : 0" + genreCount);

        //    }

       

    }
}
