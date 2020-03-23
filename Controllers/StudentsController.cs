using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebApplication.Controllers
{
    public class StudentsController : ApiController
    {
        

        public IEnumerable<Student> Get()
        {
           
            using (StudentDB entities =
                  new StudentDB())
            {
                return entities.Students.ToList();
            }      
        }

        public Student Get(int id)
        {
            using (StudentDB entities = new StudentDB())
            {
                return entities.Students.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
