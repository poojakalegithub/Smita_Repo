namespace DapperCRUD.Repostory
{
    using DapperCRUD.Models;
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using DapperCRUD.Models;
    using Microsoft.Extensions.Configuration;
    using System.Linq;
    using Dapper;
    using System.Data.SqlClient;

    public class StudentRepo
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public StudentRepo(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:StudentConn"];
        }

        public IEnumerable<Student> Get()
        {
            string sql = "select * from Student";
            using var connetion = new SqlConnection(_connectionString);
            connetion.Open();
            var result = connetion.Query<Student>(sql);
            return result.ToList();
        }

        public int Create(Student student)
        {
            var sql = "Insert into Student (Name,Age,Address) VALUES (@Name,@Age,@Address)";
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute(sql, student);
            return result;
        }

        public int Update(Student student, int StudId)
        {
            var sql = "UPDATE Student SET Name = @Name, Age = @Age, Address=@Address WHERE StudId = @StudId";
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute(sql, student);
            return result;
        }

        public int Delete(int StudId)
        {
            var sql = "DELETE FROM Student WHERE StudId = @StudId";
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var result = connection.Execute(sql, new { StudId = StudId });
            return result;
        }

    }
}
