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
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        
        //Method to show data from person class
        public void showData()
        {
            Console.WriteLine("Employee Details..!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Employee Name:"+FirstName);
            Console.WriteLine("Employee LastName:"+LastName);
            Console.WriteLine("Employee Age:"+Age);
            return;
            
        }
    }
}
