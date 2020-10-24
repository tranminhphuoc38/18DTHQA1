using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Service
{
    public interface IStudentService
    {
        List<Student> SearchStudent(StudentSearchCriteria criteria);

        List<Class> GetAllClasses();

        Student Add(Student student);

        Student Update(Student student);

        void Remove(int studentId);
        
    }
}
