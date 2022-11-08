using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    
        
            
    }
}
