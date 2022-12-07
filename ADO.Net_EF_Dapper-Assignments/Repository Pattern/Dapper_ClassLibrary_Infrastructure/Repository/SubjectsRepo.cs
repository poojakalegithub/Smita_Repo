using Dapper;
using DapperCRUD.Domain.Interfaces;
using DapperCRUD.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DapperCRUD.Infrastructure.Repository
{
    public  class SubjectsRepo:ISubjects
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public SubjectsRepo(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:StudentConn"];
        }

        public IEnumerable<Subjects> GetSubjects()
        {
            string sql = "select * from Subjects";
            using var connetion = new SqlConnection(_connectionString);
            connetion.Open();
            var result = connetion.Query<Subjects>(sql);
            return result.ToList();
        }
        public IEnumerable<Subjects> GetStudentSubjectDetails(int StudId)
        {
            string sql = "select stud.Name,sub.SubjectName from Student stud inner join Subjects sub on stud.StudId=sub.StudId AND sub.StudId=9;\r\n";
            using var connetion = new SqlConnection(_connectionString);
            connetion.Open();
            var result = connetion.Query<Subjects>(sql);
            return result.ToList();
        }
        public int AddSubjects(Subjects subjects)
        {
            var sql = "Insert into Subjects (SubjectName,StudId) VALUES (@SubjectName,@StudId)";
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute(sql, subjects);
            return result;
        }

        public int UpdateSubjects(Subjects subjects, int SubjectID)
        {
            var sql = "UPDATE Subjects SET SubjectName = @SubjectName WHERE SubjectID = @SubjectID";
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute(sql, subjects);
            return result;
        }

        public int DeleteSubjects(int SubjectID)
        {
            var sql = "DELETE FROM Subjects WHERE SubjectID = @SubjectID";
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute(sql, new { SubjectID = SubjectID });
            return result;
        }
    }
}
