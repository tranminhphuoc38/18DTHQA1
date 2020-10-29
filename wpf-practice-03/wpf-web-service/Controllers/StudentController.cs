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

        [HttpPost]
        public IEnumerable<Student> SearchStudent()
        {
            return service.SearchStudent(new StudentSearchCriteria());
        }

        public IEnumerable<Student> Get()
        {
            return service.SearchStudent(new StudentSearchCriteria());
        }

        public void Post([FromBody]Student student)
        {
        }

        public void Put(int id, [FromBody] Student student)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
