// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace DapperCRUD.Controllers
{
    using DapperCRUD.Domain.Interface;
    using DapperCRUD.Domain.Models;
    using DapperCRUD_ClassLibrary_Domain.Models;
    using Microsoft.AspNetCore.Mvc;
    using Serilog;
    using System;

    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {   
        private readonly IStudent _studentrepo;
        
        public StudentController(IStudent student)
        {
            _studentrepo = student;
        }
       
        [HttpGet]
        [Route("GetStudents")]
        public IActionResult GetStudents()
        {
            try 
            {               
                Log.Information("Fetch student details");
                var student_details = _studentrepo.GetStudents();
                if(student_details  != null)
                {
                    return Ok(student_details);
                }
                else
                {
                    return NoContent();
                }
                
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            try
            {
                Log.Information("Add student details");
                return Ok(_studentrepo.AddStudent(student));
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        [Route("UpdateStudents")]
        public IActionResult UpdateStudents(Student student, int StudId)
        {
            try
            {          
                Log.Information("Update student details");
                if(StudId > 0)
                {
                    return Ok(_studentrepo.UpdateStudent(student, StudId));
                }
                else
                {
                    return BadRequest("Enter Correct Student Id to update details");
                }
                
            }
            catch(Exception e)
            {
                 return BadRequest(e.Message);
            }       
        }

        [HttpDelete]
        [Route("DeleteStudent")]
        public IActionResult DeleteStudent(int StudId)
        {
            try
            {
                Log.Information("Delete student details");
                if(StudId>0)
                {
                    var deleteStudent = _studentrepo.DeleteStudent(StudId);
                    return Ok(deleteStudent);
                }
                else
                {
                    return BadRequest("Enter valid Student Id");
                }
                
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }           
        }       
       
    }
}
