using System.Collections.Generic;
using _04_generic_example.Model;

namespace _04_generic_example.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private IList<Student> _data;

        public StudentRepository(IList<Student> data)
        {
            _data = data;
        }

        public void Add(Student item) => _data.Add(item);
        
        public IList<Student> GetAll() => _data; 

        public void Remove(Student item) => _data.Remove(item);
        
    }
}
