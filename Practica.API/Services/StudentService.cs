using Practica.API.Models;

namespace Practica.API.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "Juan Pérez", Grade = 85 },
            new Student { Id = 2, Name = "María García", Grade = 45 },
            new Student { Id = 3, Name = "Carlos López", Grade = 60 }
        };

        public List<Student> GetAll() => _students;

        public Student GetById(int id) => _students.FirstOrDefault(s => s.Id == id);

        public Student Create(Student student)
        {
            student.Id = _students.Max(s => s.Id) + 1;
            _students.Add(student);
            return student;
        }

        public Student Update(int id, Student student)
        {
            var existingStudent = GetById(id);
            if (existingStudent == null)
                return null;

            existingStudent.Name = student.Name;
            existingStudent.Grade = student.Grade;
            return existingStudent;
        }

        public Student Delete(int id)
        {
            var student = GetById(id);
            if (student == null)
                return null;

            _students.Remove(student);
            return student;
        }

        public bool HasApproved(int id)
        {
            var student = GetById(id);
            if (student == null)
                return false;

            return student.Grade >= 51;
        }
    }
}