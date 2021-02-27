using GraphQlPractice.Interfaces;
using GraphQlPractice.Models;
using System.Collections.Generic;

namespace GraphQlPractice.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            for (int i = 0; i < 20; i++)
            {
                var newStudent = new Student
                {
                    StudentId = i,
                    Name = $"Student_{i}",
                    Age = i + 10,
                    Gender = (i % 2 == 0) ? "M" : "F",
                    SubjectScore = new Subject
                    {
                        English = 70 + i,
                        Math = 50 + i
                    }
                };
                students.Add(newStudent);
            }
            return students;
        }
    }
}
