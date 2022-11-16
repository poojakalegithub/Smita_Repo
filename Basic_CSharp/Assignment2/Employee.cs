using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeCSharp.Assignment2
{
    internal class Employee
    {
        int ID;
        string Name;
        int Salary;
        string Department;

        public override string ToString()
        {
            return ID + " " + Name + " " + Salary + " " + Department;
        }

        public void sortEmployee()
        {
            List<Employee> employees = new List<Employee>()
        {
             new Employee {ID=1,   Name="John  "    , Salary=10000,Department="XYZ"},
             new Employee {ID=2,   Name="Mark"    , Salary=9000,Department="ABC"},
             new Employee {ID=3,   Name="Remo"    , Salary=1000,Department="XYZ"},
             new Employee {ID=4,   Name="Smith"   , Salary=8000,Department="ABC"},
             new Employee {ID=5,   Name="Deo "    , Salary=9000,Department="XYZ"},
             new Employee {ID=6,   Name="Niya"    , Salary=1000,Department="ABC"},
        };


            var result = employees.Where(employee => employee.Department == "XYZ").OrderByDescending(salary => salary.Salary);


            Console.WriteLine("ID  Name  Salary  Department");
            Console.WriteLine("------------------------------");
            foreach (Employee employee in result)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine("------------------------------");
        }
    }
}