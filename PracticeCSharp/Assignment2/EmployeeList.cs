using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignment2
{
    internal class EmployeeList
    { 
        public void showEmployee()
        {
           var EmployeeLists = new List<(String name,int salary)>
                {
               ("John Smith", 2300),
                ("Adam Robin", 3340),
                ("Robin Brown", 5098),
                ("Rowan Cruise", 5678),
                ("Joe Adam", 2345),
                ("Brown Doe", 2345),
                ("Dow Smith", 2345),
                ("Thomas John", 2341)
            };

            //Soring in Ascending order

            Console.WriteLine("Sorting Employee List by salary in Ascending Order");
            Console.WriteLine("------------------------------");
            EmployeeLists.Sort((s1, s2) => s1.salary.CompareTo(s2.salary));
            Console.Write(string.Join("\n ", EmployeeLists));

            Console.WriteLine("------------------------------");
            //Soring in Descending order

            Console.WriteLine("\n Sorting Employee List by salary in Descending Order");
            Console.WriteLine("------------------------------");
            var emplist = EmployeeLists.OrderByDescending(e => e.salary);
            foreach (var emp in emplist)
            {
                Console.WriteLine(emp);
            }

        }

    }
}
