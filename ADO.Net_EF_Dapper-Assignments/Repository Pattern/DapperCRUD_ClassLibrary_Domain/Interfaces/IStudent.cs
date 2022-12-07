namespace DapperCRUD.Domain.Interface
{
    using DapperCRUD.Domain.Models;
    using DapperCRUD_ClassLibrary_Domain.Models;
    using System.Collections.Generic;
    public interface IStudent
    {
        public IEnumerable<Student> GetStudents();

        public int AddStudent(Student student);

        public int UpdateStudent(Student student, int StudId);

        public int DeleteStudent(int StudId);

        public IEnumerable<Subjects> GetStudentSubjectDetails();
    }
}
