namespace DapperCRUD_ClassLibrary_Infrastructure.Repository
{
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using System.Linq;
    using Dapper;
    using System.Data.SqlClient;
    using DapperCRUD_ClassLibrary_Domain.Models;
    using DapperCRUD.Domain;
    using DapperCRUD.Domain.Interface;

    //Class to implement methods from IStudent interface
    public class StudentRepo : IStudent
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public StudentRepo(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:StudentConn"];
        }

        //Method to Get All Students
        public IEnumerable<Student> GetStudents()
        {
            using var connetion = new SqlConnection(_connectionString);
            connetion.Open();
            var results = connetion.Query<Student>("spGetStudentDeatils");
            return results.ToList();
        }

        //Method to Add Student details
        public int AddStudent(Student student)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute("spAddStudentDeatils @Name,@Age,@Address", student);
            return result;
        }

        //Method to Update Student details
        public int UpdateStudent(Student student, int StudId)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute("spUpdateStudentDetils @Name,@Age,@Address,@StudId", student);      
            return result;
        }

        //Method to Delete Student details
        public int DeleteStudent(int StudId)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute("spDeleteStudentDetails @StudId", new { StudId = @StudId });
            return result;
        }

    }
}
