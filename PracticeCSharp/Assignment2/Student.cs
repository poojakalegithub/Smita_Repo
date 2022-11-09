using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignment2

{    
    internal class Student
    {
        public Student(String name, int age, int Class)
        {
            this.name = name;
            this.age = age;
            this.Class = Class;
        }
        public String name { set; get; }
        public int age { set; get; }
        public int Class { set; get; }
        public void StudentsList()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("John",16,10));
            students.Add(new Student("Mark", 12, 6));
            students.Add(new Student("Smith", 10, 5));
            students.Add(new Student("Doe", 17, 10));

            IEnumerable<Student> StudentList = from student in students select student;

            foreach (Student e in StudentList)
            {
                Console.WriteLine(e+"\n");
            }
        }
        

    }
}
