using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace etmoye___pa5
{
    class TransactionReports
    {
        Transaction[] viewTransaction;

        public TransactionReports(Transaction[] temp)
        {

            this.viewTransaction = temp;
        }

        public void ByRenterEmail(string searchVal)
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

            // SortByEmail();

            for (int i = 0; i < Transaction.GetCount() - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < Transaction.GetCount(); j++)
                {
                    if (viewTransactions[min].GetRenterEmail().CompareTo(viewTransactions[j].GetRenterEmail()) > 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(min, i);
                }

            }

            string currentRenterEmail = searchVal;
            int emailCount = 0;

            StreamWriter outFile = new StreamWriter("IndividualCustomer.txt");
            // outFile.WriteLine(viewTransaction[0].ToString());

            for (int i = 0; i < Transaction.GetCount(); i++)
            {
                if (viewTransactions[i].GetRenterEmail() == currentRenterEmail)
                {
                    outFile.WriteLine(viewTransactions[i].PrettyFormat());
                    emailCount++;
                }
                else
                {
                    //proceess the break
                    //emailCount--;
                    // outFile.WriteLine(currentRenterEmail + " has had " + emailCount + " rentals");
                }


            }

            outFile.WriteLine(currentRenterEmail + " has had " + emailCount + " rental(s)");



            outFile.Close();
        }


        public void HistoricalCustomerRental()
        {
            //Get from file
            Transaction[] viewTransactions = new Transaction[100];
            Transaction.SetCount(0);

            StreamReader inFile = new StreamReader("transactions.txt");

            string input = inFile.ReadLine();

            while (input != null)
            {
                string[] tempArray = input.Split('#');

                viewTransaction[Transaction.GetCount()] = new Transaction(tempArray[0], tempArray[1], tempArray[2], (tempArray[3]), (tempArray[4]), tempArray[5], tempArray[6]);
                Transaction.IncCount();

                input = inFile.ReadLine();
            }

            inFile.Close();


            // SortCustomerName

            for (int i = 0; i < Transaction.GetCount(); i++)
            {
                int min = i;

                for (int j = i + 1; j < Transaction.GetCount(); j++)
                {
                    if (viewTransaction[min].GetRenterEmail().CompareTo(viewTransaction[j].GetRenterEmail()) > 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(min, i);
                }

            }

            StreamWriter test = new StreamWriter("sort.txt");
            for (int i = 0; i < Transaction.GetCount(); i++)
            {

                test.WriteLine(viewTransaction[i].ToFile());
            }

            test.Close();


            string currentRenter = viewTransaction[0].GetRenterName();
            int rentalCount = 1;
            int totalRentAmount = int.Parse(viewTransaction[0].GetRentAmount());
            double averageRent = 0.0;

            StreamWriter outFile = new StreamWriter("HistoricalCustomer.txt");



            //outFile.WriteLine(viewTransactions[0].ToFile());

            for (int i = 0; i < Transaction.GetCount(); i++)
            {
                if (viewTransaction[i].GetRenterName() == currentRenter)
                {
                    // outFile.WriteLine(viewTransactions[0].ToFile());

                    rentalCount++;
                    totalRentAmount =+ totalRentAmount + int.Parse(viewTransaction[i].GetRentAmount()) + totalRentAmount;
                }

                else
                {
                    averageRent = totalRentAmount / rentalCount;
                    outFile.WriteLine(currentRenter + " has rented: " + rentalCount + " time(s) with an average rental price of $" + averageRent + "\n");

                    totalRentAmount = +int.Parse(viewTransaction[i].GetRentAmount());
                    currentRenter = viewTransaction[i].GetRenterName();
                    rentalCount = 1;
                }

            }
            averageRent = totalRentAmount / rentalCount;
            outFile.WriteLine(currentRenter + " has rented: " + rentalCount + " time(s) with an average rental price of $" + averageRent + "\n");


            outFile.Close();

        }

        public void RevenueReport()
        {

            //Get from file
            Transaction[] viewTransactions = new Transaction[100];
            Transaction.SetCount(0);

            StreamReader inFile = new StreamReader("transactions.txt");

            string input = inFile.ReadLine();

            while (input != null)
            {
                string[] tempArray = input.Split('#');

                viewTransaction[Transaction.GetCount()] = new Transaction(tempArray[0], tempArray[1], tempArray[2], (tempArray[3]), (tempArray[4]), tempArray[5], tempArray[6]);
                Transaction.IncCount();

                input = inFile.ReadLine();
            }

            inFile.Close();


            //SortByDate
            for (int i = 0; i < Transaction.GetCount() - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < Transaction.GetCount(); j++)
                {
                    if (viewTransaction[min].GetRentDate().CompareTo(viewTransaction[j].GetRentDate()) > 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(min, i);
                }

            }

            // will print sorted dates to file with corresponding month and year
            StreamWriter test = new StreamWriter("RevenueReport.txt");

            //
            double revTotal = 0;

            test.WriteLine("Displayed MM/YYYY: " + "\n");
            for (int i = 0; i < Transaction.GetCount() - 1; i++)
            {
                int min = 1;

                string thisDate = viewTransaction[i].GetRentDate();
                DateTime dateValue1 = (Convert.ToDateTime(thisDate.ToString()));
                //DateTime dateValue2 = Convert.ToDateTime(thatDate.ToString()));
                string dateMonth1 = dateValue1.Month.ToString();
                string dateYear1 = dateValue1.Year.ToString();


                for (int j = i + 1; j < Transaction.GetCount(); j++)
                {

                    //string thisDate = viewTransaction[i].GetRentDate();
                    //DateTime dateValue1 = (Convert.ToDateTime(thisDate.ToString()));
                    ////DateTime dateValue2 = Convert.ToDateTime(thatDate.ToString()));
                    //string dateMonth1 = dateValue1.Month.ToString();
                    //string dateYear1 = dateValue1.Year.ToString();

                    string thatDate = viewTransaction[j].GetRentDate();
                    DateTime dateValue2 = (Convert.ToDateTime(thatDate.ToString()));
                    string dateMonth2 = dateValue2.Month.ToString();
                    string dateYear2 = dateValue2.Year.ToString();


                    //DateTime dateValue2 = Convert.ToDateTime(thatDate.ToString()));
                    //string dateMonth2 = dateValue2.Month.ToString();
                    //string dateYear2 = dateValue2.Year.ToString();

                    if (dateYear1 == dateYear2 && dateMonth1 == dateMonth2)
                    {
                        revTotal = double.Parse(viewTransaction[i].GetRentAmount()) + double.Parse(viewTransaction[j].GetRentAmount());
                        // test.WriteLine("month : " + dateMonth1 + " year: " + dateYear1 + " had a revenue of $" + revTotal);
                    }
                    //test.WriteLine("month : " + dateMonth1 + " year: " + dateYear1 + " had a revenue of $" + revTotal);
                    if (dateYear1 != dateYear2 || dateMonth1 != dateMonth2)
                    {
                        revTotal = double.Parse(viewTransaction[i].GetRentAmount());
                        // test.WriteLine("month : " + dateMonth1 + " year: " + dateYear1 + " had a revenue of $" + revTotal);
                    }

                }

                test.WriteLine("During 0" + dateMonth1 + "/" + dateYear1 + " there was a revenue of $" + revTotal + "\n");


            }

            test.Close();

        }

        public void Swap(int x, int y)
        {
            Transaction temp = viewTransaction[x];
            viewTransaction[x] = viewTransaction[y];
            viewTransaction[y] = temp;
        }

        //public void SortByEmail()
        //{


        //    for (int i = 0; i < Transaction.GetCount() - 1; i++)
        //    {
        //        int min = i;

        //        for (int j = i + 1; j < Transaction.GetCount(); j++)
        //        {
        //            if (viewTransaction[min].GetRenterEmail().CompareTo(viewTransaction[j].GetRenterEmail()) > 0)
        //            {
        //                min = j;
        //            }
        //        }

        //        if (min != i)
        //        {
        //            Swap(min, i);
        //        }

        //    }

        //}

        //public void EmailSearch(string searchVal)
        //{
        //    string currentRenterEmail = searchVal;
        //    int emailCount = 1;

        //    StreamWriter outFile = new StreamWriter("report");
        //    // outFile.WriteLine(viewTransaction[0].ToString());

        //    for (int i = 1; i < Transaction.GetCount(); i++)
        //    {
        //        if (viewTransactions[i].GetRenterEmail() == currentRenterEmail)
        //        {
        //            outFile.WriteLine(viewTransaction[i].ToString());
        //            emailCount++;
        //        }
        //        else
        //        {
        //            //proceess the break
        //            emailCount--;
        //            outFile.WriteLine(currentRenterEmail + " has had " + emailCount + " rentals");
        //        }
        //        outFile.Close();
        //    }

        //    //  Console.WriteLine(currentRenterEmail + " count is : " + emailCount);

        //}




    }
}


