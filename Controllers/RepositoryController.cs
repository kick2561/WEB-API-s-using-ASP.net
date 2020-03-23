using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Interfaces;

namespace WebApplication.Controllers
{
    public class RepositoryController : ApiController
    {
        private IStudentRepository stud;

        public RepositoryController(IStudentRepository _student)
        {
            this.stud = _student;
        }
        public IEnumerable<Student> Get()
        {
            return stud.GetStudents();
        }
        public IHttpActionResult Get(string Name)
        {
            var stu = stud.GetStudentById(Name);
            if (stu == null)
                return NotFound();
            return Ok(stu);
        }
    }
}
