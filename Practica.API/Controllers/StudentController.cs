using Microsoft.AspNetCore.Mvc;
using Practica.API.Models;
using Practica.API.Services;

namespace Practica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Student> GetAll()
        {
            return _studentService.GetAll();
        }

        [HttpGet("{id}")]
        public Student GetById(int id)
        {
            return _studentService.GetById(id);
        }

        [HttpPost]
        public Student Create(Student student)
        {            
            return _studentService.Create(student);
        }

        [HttpPut("{id}")]
        public Student Update(int id, Student student)
        {
            return _studentService.Update(id, student);            
        }

        [HttpDelete("{id}")]
        public Student Delete(int id)
        {
            return _studentService.Delete(id);
        }

        [HttpGet("{id}/approval")]
        public Boolean HasApproved(int id)
        {            
            return _studentService.HasApproved(id);
        }

    }
}