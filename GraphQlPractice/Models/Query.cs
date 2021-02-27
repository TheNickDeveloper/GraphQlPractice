using GraphQlPractice.Interfaces;
using System.Collections.Generic;

namespace GraphQlPractice.Models
{
    public class Query
    {
        readonly IStudentService _studentService = null;
        public Query(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public List<Student> Students => _studentService.GetStudents();
    }
}
