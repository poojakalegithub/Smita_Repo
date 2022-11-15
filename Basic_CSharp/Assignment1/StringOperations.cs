using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignments
{
    internal class StringOperations
    {
        String firstName = "Smita";
        String lastName = "Pradhan";

        //Method to concat two Strings
        public void concatStrings()
        {
            Console.WriteLine("First name: " +firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("After Concatination Using concat() method :");
            Console.WriteLine(String.Concat(firstName, lastName));
        }

        //Method to compare two Strings
        public void compareStrings()
        {
            Console.WriteLine("Compairing Strings using Equals() method :");
            bool res2 = firstName.Equals(lastName);
            if (res2 == true)
            {
                Console.WriteLine("Both Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are NOT equal");
            }   

        }

        //Method to get subString from string
        public void findSubString()
        {
            //this will start from index 2
            Console.WriteLine(firstName.Substring(2));

            //this will start from index 1 and will take length as 3
            Console.WriteLine(lastName.Substring(1,3));
        }

        //Method to reverse the string
        public void reverse()
        {
            String str = "Smita";
            Console.WriteLine("Actual String:"+str);
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Revered String:"+new string(charArray));
        }
    }
}
