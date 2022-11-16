using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignments
{
    internal class countriesEnum
    {
        public void showData()
        {
        Console.WriteLine("Enter Country Name:");
        //to take input from user
        String Country=Console.ReadLine();  

        //to convert user input into upper case
        String CountryName=Country.ToUpper();

            switch (CountryName)
            {
                case "INDIA":
                    Console.WriteLine("You have selected :"+countries.INDIA);
                    break;
                case "AUSTRALIA":
                    Console.WriteLine("You have selected"+countries.AUSTRALIA);
                    break;
                case "USA":
                    Console.WriteLine("You have selected"+countries.USA);
                    break;
                case "JAPAN":
                    Console.WriteLine("You have selected"+countries.JAPAN);
                    break;
                case "FRANCE":
                    Console.WriteLine("You have selected"+countries.FRANCE);
                    break;
                case "ENGLAND":
                    Console.WriteLine("You have selected"+countries.ENGLAND);
                    break;
                default:
                    Console.WriteLine("Invalid Country");
                    break;
            }

        }
        //declaring enum for countries
        enum countries
        {
            INDIA, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND
        }
    }
   

}
