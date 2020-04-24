using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace etmoye___pa5
{
    class TransactionUtilities
    {
        Transaction[] viewTransactions;
        public TransactionUtilities(Transaction[] tempTransaction)
        {
            this.viewTransactions = tempTransaction;

        }

        //DO NOT DELETE****************************************************

        public static Transaction[] GetAllTransactions()
        {

            Transaction[] viewTransactions = new Transaction[100];
            Transaction.SetCount(0);

            StreamReader inFile = new StreamReader("transactions.txt");

            string input = inFile.ReadLine();

            while (input != null)
            {
                string[] tempArray = input.Split('#');

                viewTransactions[Transaction.GetCount()] = new Transaction(tempArray[0], tempArray[1], tempArray[2], (tempArray[3]), (tempArray[4]), tempArray[5], tempArray[6]);
                Transaction.IncCount();

                input = inFile.ReadLine();
            }

            inFile.Close();
            //viewListings.ToList convert array to list and return list to listbox
            //List<Listing> listingsList = viewListings.ToList();

            return viewTransactions;

        }

        //public void ListingsByEmail(string renterEmail) //need to pass in an email address
        //{
        //    //instatiate the variables and process the first row
        //    string currentEmail = viewTransactions[0].renterEmail;
        //    int emailCount = 1;


        //    Console.WriteLine(viewTransactions[0].ToString()); //write out first row

        //    //for loop for second row until the end 
        //    for (int i = 1; i < Listing.GetCount(); i++)
        //    {
        //        if (viewTransactions[i].GetRenterEmail() == currentEmail) //check to see if it matches the one before it 
        //        {
        //            Console.WriteLine(viewTransactions[i].ToString());
        //            emailCount++;

        //        }
        //        else
        //        {
        //            //Proceses the break
        //            Console.WriteLine(currentEmail + " count  is : 0" + emailCount); //break line, writing out count for current genre

        //            //resetting two variables
        //            currentEmail = viewTransactions[i].GetRenterEmail();
        //            emailCount = 1;

        //            //writing out the row you are on
        //            Console.WriteLine(viewTransactions[i].ToString());
        //        }
        //    }

        //    //break line - prints last line of file
        //    Console.WriteLine(currentEmail + " count  is : 0" + emailCount);

        //}

    }
}
