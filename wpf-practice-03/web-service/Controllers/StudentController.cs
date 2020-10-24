using Common.Model;
using Common.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_service.Service;

namespace web_service.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentService service;

        public StudentController()
        {
            service = new DbStudentService();
        }

        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            return service.SearchStudent(new StudentSearchCriteria());
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
