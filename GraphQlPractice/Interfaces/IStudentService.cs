using GraphQlPractice.Models;
using System.Collections.Generic;

namespace GraphQlPractice.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
