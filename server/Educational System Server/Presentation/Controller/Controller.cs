using Contracts.Domains;
using Contracts.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using persistence;
using Services.Abstractions;

namespace Presentation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class Controller : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public Controller(IServiceManager repositoryDbContext)
        {
            _serviceManager = repositoryDbContext;
        }


        [HttpPost("/defineclass")]
        public async Task<IActionResult> DefineClass(DefineClassDomain domain)
        {
            var result = await _serviceManager.ClassService.DefineClass(domain);

            return Ok(result);
        }
        
        
        [HttpPost("/getclasslist")]
        public async Task<IActionResult> GetClassesList()
        {
            var result = await _serviceManager.ClassService.GetClasses();

            return Ok(result);
        }
        

        [HttpPost("/getteacherlist")]
        public async Task<IActionResult> GetTeachersList()
        {
            var result = await _serviceManager.TeacherService.GetTeachers();

            return Ok(result);
        }


        [HttpPost("/getstudentlist")]
        public async Task<IActionResult> GetStudentsList()
        {
            var result = await _serviceManager.StudentService.GetStudents();

            return Ok(result);
        }


        [HttpPost("/createclass")]
        public async Task<IActionResult> CreateClass(CreateClassDomain domain)
        {
            var result = await _serviceManager.ClassService.CreateClass(domain);

            return Ok(result);
        }
    }
}
