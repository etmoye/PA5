using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace etmoye___pa5
{
    class ListingUtilities
    {
        Listing[] viewListings;

        public ListingUtilities(Listing[] temp)
        {
            this.viewListings = temp;
        }

        //IN THIS CLASS
        //GetAllListing - read in data from file to populate an array and then convert array to list
        //SaveListing - Save listings to an output txt file
        //DeleteListing - 
        //SortListing
        //Binary search 

        public void GetAllListing()
        {

            Listing.SetCount(0);

            StreamReader inFile = new StreamReader("listings.txt");

            string input = inFile.ReadLine();

            while (input != null)
            {
                string[] tempArray = input.Split('#');
                //Guid guid = new Guid();
                //tempArray[0] = guid.ToString();
                viewListings[Listing.GetCount()] = new Listing(tempArray[0], tempArray[1], tempArray[2], (tempArray[3]), tempArray[4], tempArray[5]);
                Listing.IncCount();

                input = inFile.ReadLine();
            }

            inFile.Close();
            //viewListings.ToList convert array to list and return list to listbox
            //List<Listing> listingsList = viewListings.ToList();
           // return viewListings;
        }



        // when creating the method to save to file pass in the array returned



        public void SaveListing()
        {
             //Listing[] viewListings = new Listing[100]; // creates new blank array??
            //Listing.SetCount(0);

            StreamWriter outfile = new StreamWriter("output.txt"); //("output.txt", true) use if you want to pick up a file where you left off

            for (int i = 0; i < Listing.GetCount() - 1; i++)
            {
                //Console.WriteLine(movieArray[i].ToString());
                outfile.WriteLine(viewListings[i].ToFile());
               //Listing.IncCount();

            }
            outfile.Write(viewListings[Listing.GetCount() - 1].ToFile());

            outfile.Close();
        }
    }
}
