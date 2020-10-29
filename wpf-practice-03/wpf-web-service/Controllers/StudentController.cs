using Common.Model;
using Common.Service;
using System.Collections.Generic;
using System.Web.Http;
using web_service.Service;

namespace web_service.Controllers {
    public class StudentController : ApiController
    {
        private IStudentService service;

        public StudentController()
        {
            service = new DbStudentService();
        }

        public IEnumerable<Student> GetSearchStudent(string searchText = null, string studentClass= null)
        {
            return service.SearchStudent(new StudentSearchCriteria { 
                ClassName = studentClass, 
                SearchText = searchText 
            });
        }

        public void PostNewStudept([FromBody]Student student)
        {
            service.Add(student);
        }

        public void PutUpdateStudent(int id, [FromBody] Student student)
        {
            service.Add(student);
        }

        public void Delete(int id)
        {
            service.Remove(id);
        }
    }
}
