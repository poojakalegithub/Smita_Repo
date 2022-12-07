using DapperCRUD.Domain.Interface;
using DapperCRUD.Domain.Interfaces;
using DapperCRUD.Domain.Models;
using DapperCRUD_ClassLibrary_Domain.Models;
using DapperCRUD_ClassLibrary_Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;

namespace DapperCRUD.Controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjects _subjectrepo;

        public SubjectsController(ISubjects subjects)
        {
            _subjectrepo = subjects;
        }

        [HttpGet]
        [Route("GetSubjects")]
        public IActionResult GetStudents()
        {
            try
            {
                Log.Information("Fetch student details");
                var subject_details = _subjectrepo.GetSubjects();
                if (subject_details != null)
                {
                    return Ok(subject_details);
                }
                else
                {
                    return NoContent();
                }

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("AddSubjects")]
        public IActionResult AddStudent(Subjects subjects)
        {
            try
            {
                Log.Information("Add subject details");
                return Ok(_subjectrepo.AddSubjects(subjects));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        [Route("UpdateSubjects")]
        public IActionResult UpdateStudents(Subjects subject, int SubjectID)
        {
            try
            {
                Log.Information("Update subject details");
                if (SubjectID > 0)
                {
                    return Ok(_subjectrepo.UpdateSubjects(subject, SubjectID));
                }
                else
                {
                    return BadRequest("Enter Correct subject Id to update details");
                }

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteSubjects")]
        public IActionResult DeleteStudent(int SubjectID)
        {
            try
            {
                Log.Information("Delete subject details");
                if (SubjectID > 0)
                {
                    var deleteSubject = _subjectrepo.DeleteSubjects(SubjectID);
                    return Ok(deleteSubject);
                }
                else
                {
                    return BadRequest("Enter valid subject Id");
                }

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
    }
}
