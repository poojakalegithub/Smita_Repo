using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignments
{
    internal class EmailValidation
    {
    string email1 = "Smitanpradhan33@gmail.com";
    public void validateEmail()
        {
            if (email1.Contains('@') == true && email1.EndsWith(".com") == true)
            {
                Console.WriteLine(email1 + " is validated");
            }
            else
            {
                Console.WriteLine(email1 + " is not validated");
            }
        }
    
        
     public void ValidateUsingRegex()
        {
             Console.Write("Enter a Email : ");
             var Email = Console.ReadLine();

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
