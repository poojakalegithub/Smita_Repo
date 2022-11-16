using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignment2
{
    class Student
    {
        int ID;
        string Name;
        int Age;
        int Class;

        public override string ToString()
        {
            return ID + "  " + Name + "   " +Age + "   " + Class;
        }

        public void StudentList()
        {
            // Creating list of type Student 
            List<Student> students = new List<Student>()
            {
                new Student{ ID = 101, Name = "Mark",Age=9,Class = 2 },
                new Student{ ID = 102, Name = "Smith",Age=6,Class = 1 },
                new Student{ ID = 103, Name = "John",Age=10,Class= 3},
            };
            IEnumerable<Student> Query = from student in students select student;
            Console.WriteLine("ID  Name  Department Semester");
            Console.WriteLine("------------------------------");
            foreach (Student e in Query)
            {
                // Calling toString()
                Console.WriteLine(e.ToString());
            }
        }
    }
}

    
