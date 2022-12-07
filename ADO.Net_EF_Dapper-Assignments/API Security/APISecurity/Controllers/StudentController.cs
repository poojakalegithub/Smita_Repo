namespace APISecurity.Controllers
{
    using APISecurity.Models;
    using APISecurity.Repository;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepo _studentrepo;

        public StudentController(IConfiguration configuration)
        {
            _studentrepo = new StudentRepo(configuration);
        }
       
        [HttpGet,Authorize]
        public IActionResult GetAllStudentsDetails()
        {
            return Ok(_studentrepo.GetAllStudents());
        }
        
        [HttpPost,Authorize]
        public IActionResult AddStudent(Student student)
        {
            return Ok(_studentrepo.AddStudent(student));
        }

        [HttpPut,Authorize]
        public IActionResult UpdateStudent(Student student, int StudId)
        {
            return Ok(_studentrepo.UpdateStudent(student, StudId));
        }

        [HttpDelete,Authorize]
        public IActionResult DeleteStudent(int StudId)
        {
            return Ok(_studentrepo.DeleteStudent(StudId));
        }
    }
}
