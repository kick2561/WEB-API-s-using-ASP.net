using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Interfaces;

namespace WebApplication.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> students = new List<Student>()
        {
            new Student{Name = "Watson",Gender = "Male"},
            new Student{Name = "ronaldo",Gender = "Male"}
        };
        public List<Student> GetStudents()
        {
            return students;
        }
        public Student GetStudentById(string Name)
        {
            var stud = students.FirstOrDefault(x => x.Name == Name);
            return stud;
        }
    }
}