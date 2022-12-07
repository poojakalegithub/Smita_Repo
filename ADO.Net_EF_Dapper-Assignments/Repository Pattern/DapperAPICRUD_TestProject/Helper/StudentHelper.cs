namespace DapperAPICRUD_TestProject.Helper
{
    using DapperCRUD_ClassLibrary_Domain.Models;
    using System.Collections.Generic;
    public class StudentHelper
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student
                {
                    StudId = 1,
                    Name="john",
                    Address="Japan",
                    Age=40
                }
            };
        }
        public static List<Student> AddStudent()
        {
            return new List<Student>()
            {
                new Student
                {
                    StudId = 1,
                    Name="john",
                    Address="Japan",
                    Age=40
                }
            };
        }
        public static List<Student> EmptyStudentsList()
        {
            return new List<Student>();
            
        }
    }
}
