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
                viewListings[Listing.GetCount()] = new Listing(tempArray[0], tempArray[1], tempArray[2], (tempArray[3]), tempArray[4]);
                Listing.IncCount();

                input = inFile.ReadLine();
            }
            SortByID();
            inFile.Close();
            //viewListings.ToList convert array to list and return list to listbox
            //List<Listing> listingsList = viewListings.ToList();
           // return viewListings;
        }

        public void SortByID()
        {
            for (int i = 0; i < Listing.GetCount() - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < Listing.GetCount(); j++)
                {
                    if (viewListings[min].GetlistingId().CompareTo(viewListings[j].GetlistingId()) > 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(min, i);
                }

            }
        }



        // when creating the method to save to file pass in the array returned



        public void SaveListing()
        {
             //Listing[] viewListings = new Listing[100]; // creates new blank array??
              //Listing.SetCount(0);

            StreamWriter outfile = new StreamWriter("newListing.txt",true); //("output.txt", true) use if you want to pick up a file where you left off

            for (int i = 0; i < Listing.GetCount() - 1; i++)
            {
                //Console.WriteLine(movieArray[i].ToString());
                outfile.WriteLine(viewListings[i].ToFile());
               //Listing.IncCount();

            }
            outfile.Write(viewListings[Listing.GetCount() - 1].ToFile());

            outfile.Close();
        }

        public int SearchByID(string searchVal)
        {

            int first = 0;
            int last = Listing.GetCount() - 1;
            int mid = (first + last) / 2;

            while (last >= first)
            {
                if ((viewListings[mid].GetlistingId()) == searchVal)
                {
                    return mid;
                }
                if (int.Parse(viewListings[mid].GetlistingId()) > int.Parse(searchVal))
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

        public Listing[] DeleteListing(int deleteID)
        {
            StreamWriter outfile = new StreamWriter("listings.txt");

            for (int i =0; i<Listing.GetCount()-1; i++)
            {
                if(viewListings[i] == viewListings[deleteID])
                {
                    for(i = deleteID; i < Listing.GetCount()-1; i++)
                    {
                        viewListings[i] = viewListings[i + 1];
                    }
                }

            }
            for (int j = 0; j < Listing.GetCount() - 1; j++)
            {
                outfile.WriteLine(viewListings[j].ToFile());
            }
            outfile.Close();

            return viewListings;
        }

        //public int StringSearchByID(string searchVal)
        //{

        //    int first = 0;
        //    int last = Listing.GetCount() - 1;
        //    int mid = (first + last) / 2;

        //    while (last >= first)
        //    {
        //        if ((viewListings[mid].GetlistingId()) == searchVal)
        //        {
        //            return mid;
        //        }
        //        if (int.Parse(viewListings[mid].GetlistingId()) > searchVal)
        //        {
        //            last = mid - 1;
        //        }
        //        else
        //        {
        //            first = mid + 1;
        //        }
        //        mid = (first + last) / 2;

        //    }

        //    return -1;
        //}

        public void Swap(int x, int y)
        {
            Listing temp = viewListings[x];
            viewListings[x] = viewListings[y];
            viewListings[y] = temp;
        }
    }
}
