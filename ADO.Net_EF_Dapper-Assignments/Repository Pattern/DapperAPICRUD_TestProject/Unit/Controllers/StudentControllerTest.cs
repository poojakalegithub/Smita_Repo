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

        //[Fact]
        //public void DeleteStudentDetails()
        //{

        ////Arrange
        //var studentService = new Mock<IStudent>();
        //var sut = new StudentController(studentService.Object);
        //int StudId = 11;
        //// Act
        //var result = sut.DeleteStudent(StudId);

        //// Assert
        //result.GetType().Should().Be(typeof(OkObjectResult));
        //(result as OkObjectResult).StatusCode.Should().Be(200);
        //}


        //[Fact]
        //public void AddStudentDetails_ShouldAddStudentsInDatabase()
        //{
        //    //Arrange         
        //    var studentService = new Mock<IStudent>();
        //    studentService.Setup(_ => _.AddStudent(_studentController)).Returns(It.IsAny<int>());
        //    var sut = new StudentController(studentService.Object);

        //    // Act
        //    var result = sut.AddStudent(_studentController);

        //    // Assert
        //    result.GetType().Should().Be(typeof(OkObjectResult));
        //    (result as OkObjectResult).StatusCode.Should().Be(200);
        //}


        //[Fact]
        //public void GetStudentDetails_shouldReturnEmptyList()
        //{
        //    //Arrange
        //    var studentService = new Mock<IStudent>();
        //    studentService.Setup(_ => _.GetStudents()).Returns(StudentMock.EmptyStudentsList());
        //    var sut = new StudentController(studentService.Object);

        //    // Act
        //    var result = sut.GetStudents();

        //    // Assert
        //    result.GetType().Should().Be(typeof(OkObjectResult));
        //    (result as OkObjectResult).StatusCode.Should().Be(200);
        //}

        //[Fact]
        //public void GetStudentDetails_ShouldResturnOk()
        //{


        ////Arrange
        //var studentService = new Mock<IStudent>();
        //studentService.Setup(_ => _.GetStudents()).Returns(StudentMock.GetStudents());
        //var sut = new StudentController(studentService.Object);

        //// Act
        //var result = sut.GetStudents();

        //// Assert
        //result.GetType().Should().Be(typeof(OkObjectResult));
        //(result as OkObjectResult).StatusCode.Should().Be(200);
        //}
        //craete helper
        //Student student=call method from helper
        //mock repo
        //then write return id, while passing student object.
    }
}
