using Practica.API.Models;

namespace Practica.API.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student Create(Student student);
        Student Update(int id, Student student);
        Student Delete(int id);
        bool HasApproved(int id);
    }
}