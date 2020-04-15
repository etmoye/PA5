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
        public static Transaction[] GetAllTransactions()
        {

            Transaction[] viewTransactions = new Transaction[100];
            Transaction.SetCount(0);

            StreamReader inFile = new StreamReader("transactions.txt");

            string input = inFile.ReadLine();

            while (input != null)
            {
                string[] tempArray = input.Split('#');
                //Guid guid = new Guid();
                //tempArray[0] = guid.ToString();
                viewTransactions[Transaction.GetCount()] = new Transaction(tempArray[0], tempArray[1], tempArray[2], (tempArray[3]), (tempArray[4]), tempArray[5], tempArray[6]);
                Transaction.IncCount();

                input = inFile.ReadLine();
            }

            inFile.Close();
            //viewListings.ToList convert array to list and return list to listbox
            //List<Listing> listingsList = viewListings.ToList();
            return viewTransactions;
        }

    }
}
