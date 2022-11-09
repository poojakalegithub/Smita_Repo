using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//1.Write a C# program to validate an Email ID – Using Regex

namespace PracticeCSharp.Assignment2
{
    internal class ValidatioUsingRegex
    {
        public void ValidateUsingRegex()
        {
            //User input for email
            Console.Write("Enter a Email : ");
            var Email = Console.ReadLine();

            //regex pattern to validate email
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            if (Regex.IsMatch(Email, pattern))
            {

                Console.WriteLine(Email + " is a valididated");
            }
            else
            {
                Console.WriteLine(Email + " is not a valididated");
            }
        }
    }
}
