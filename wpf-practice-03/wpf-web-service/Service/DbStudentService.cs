using Common.Service;
using System;
using System.Collections.Generic;
using Common.Model;
using System.Linq;

namespace web_service.Service
{
    public class DbStudentService : IStudentService
    {
        private SIMContext _context;

        public DbStudentService()
        {
            _context = new SIMContext();
        }
        public Student Add(Student student)
        {
            var newStudent = _context.Students.Add(student);
            _context.SaveChanges();

            return newStudent;
        }

        public List<Class> GetAllClasses()
        {
            return new List<Class>
            {
                new Class { Name ="" }
            };
        }

        public void Remove(int studentId)
        {
            var deletedStudent = _context.Students.FirstOrDefault(s => s.Id == studentId);

            _context.Students.Remove(deletedStudent);

            _context.SaveChanges();
        }

        public List<Student> SearchStudent(StudentSearchCriteria criteria)
        {
            return _context.Students.Where(s => 
                string.IsNullOrEmpty(criteria.SearchText) ||
                s.FirstName.Contains(criteria.SearchText)
            ).ToList();
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}