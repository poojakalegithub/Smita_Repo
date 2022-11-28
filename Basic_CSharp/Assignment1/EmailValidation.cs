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
    string email = "Smitanpradhan33@gmail.com";
    public void validateEmail()
        {
            if (email.Contains('@') == true && email.EndsWith(".com") == true || email.EndsWith(".in") == true || email.EndsWith(".org") == true) 
            {
                Console.WriteLine(email + " is validated");
            }
            else
            {
                Console.WriteLine(email + " is not validated");
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
