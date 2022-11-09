using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignments
{
        internal class Employee : Person
        {
            public string JobTitle { get; set; }
            public decimal Salary { get; set; }

            public Employee(string firstName, string lastName, byte age, string jobTitle, decimal salary)
                : base(firstName, lastName, age)
            {
                JobTitle = jobTitle;
                Salary = salary;
                EmployeeDetails();  
            }
            public void EmployeeDetails()
            {
            Console.WriteLine("------------------------------------------");
            showData();
            Console.WriteLine("Job title :", JobTitle);
            Console.WriteLine("Salary :",Salary);
            }
            
            
        }
    }

