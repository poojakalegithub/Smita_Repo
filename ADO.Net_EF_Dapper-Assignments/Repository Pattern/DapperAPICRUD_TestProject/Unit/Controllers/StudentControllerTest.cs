namespace DapperAPICRUD_TestProject.DapperAPICRUD_TestProject.controller
{
    using AutoFixture;
    using DapperCRUD_ClassLibrary_Domain.Models;
    using FluentAssertions;
    using global::DapperAPICRUD_TestProject.Helper;
    using global::DapperCRUD.Controllers;
    using global::DapperCRUD.Domain.Interface;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using System.Linq;
    using Xunit;

    public class StudentControllerTest
    {
        private readonly Mock<IStudent> _studentRepo;
        private readonly Fixture _fixture;
        private StudentController _StudentController;
        public StudentControllerTest()
        {
            _fixture = new Fixture();
            _studentRepo = new Mock<IStudent>();
        }

        [Fact]
        public void GetStudentDetails_ShouldResturnOk()
        {
            var Getstudent = _fixture.CreateMany<Student>(3).ToList();
            _studentRepo.Setup(_ => _.GetStudents()).Returns(Getstudent);
            _StudentController = new StudentController(_studentRepo.Object);
            var result = _StudentController.GetStudents();
            var obj = result as ObjectResult;
            Assert.Equal(200, obj.StatusCode);          
        }

        [Fact]
        public void AddStudents()
        {
            var Addstudent = _fixture.Create<Student>();
            _studentRepo.Setup(_studentRepo => _studentRepo.AddStudent(It.IsAny<Student>()));
            _StudentController = new StudentController(_studentRepo.Object);
            var result = _StudentController.AddStudent(Addstudent);
            var obj = result as ObjectResult;
            Assert.Equal(200, obj.StatusCode);
        }

        [Fact]
        public void UpdateStudent_shouldReturnOk_WhenUpdatedStudent()
        {
            var updatStudent = _fixture.Create<Student>();
            int StudId = 1;
            _studentRepo.Setup(_studentRepo => _studentRepo.UpdateStudent(It.IsAny<Student>(),StudId));
            _StudentController = new StudentController(_studentRepo.Object);
            var result = _StudentController.UpdateStudents(updatStudent,StudId);
            var obj = result as ObjectResult;
            Assert.Equal(200, obj.StatusCode);
        }

        [Fact]
        public void DeleteStudentDetails()
        {
            var updatStudent = _fixture.Create<Student>();
            int StudId = 1;
            _studentRepo.Setup(_studentRepo => _studentRepo.DeleteStudent(StudId));
            _StudentController = new StudentController(_studentRepo.Object);
            var result = _StudentController.DeleteStudent(StudId);
            var obj = result as ObjectResult;
            Assert.Equal(200, obj.StatusCode);
        }     
    }
}
