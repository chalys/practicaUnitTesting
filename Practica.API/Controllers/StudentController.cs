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
        public IActionResult GetAll()
        {
            return Ok(_studentService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _studentService.GetById(id);
            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            var createdStudent = _studentService.Create(student);
            return CreatedAtAction(nameof(GetById), new { id = createdStudent.Id }, createdStudent);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Student student)
        {
            var updatedStudent = _studentService.Update(id, student);
            if (updatedStudent == null)
                return NotFound();

            return Ok(updatedStudent);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedStudent = _studentService.Delete(id);
            if (deletedStudent == null)
                return NotFound();

            return Ok(deletedStudent);
        }

        [HttpGet("{id}/approval")]
        public IActionResult HasApproved(int id)
        {
            var hasApproved = _studentService.HasApproved(id);
            return Ok(new { Approved = hasApproved });
        }
    }
}