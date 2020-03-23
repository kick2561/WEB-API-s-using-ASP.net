using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        Student GetStudentById(string Name);
    }
}
