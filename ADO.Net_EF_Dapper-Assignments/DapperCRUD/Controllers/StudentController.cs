// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace DapperCRUD.Controllers
{
    using DapperCRUD.Models;
    using DapperCRUD.Repostory;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepo _studentrepo;

        public StudentController(IConfiguration configuration)
        {
            _studentrepo = new StudentRepo(configuration);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentrepo.Get());
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            return Ok(_studentrepo.Create(student));
        }

        [HttpPut]
        public IActionResult Put(Student student, int StudId)
        {
            return Ok(_studentrepo.Update(student, StudId));
        }

        [HttpDelete]
        public IActionResult Delete(int StudId)
        {
            return Ok(_studentrepo.Delete(StudId));
        }
    }
}
