using PracticeCSharp.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignments
{
    internal class Person
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Age { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Person(string firstName, string lastName, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        
        //Method to show data from person class
        public void showData()
        {
            Console.WriteLine("Employee Details..!");
            Console.WriteLine("------------------------------------------");
           Console.WriteLine("Full Name : " + FullName);
            Console.WriteLine("Age : "+Age);
            return;
            
        }
    }
}
