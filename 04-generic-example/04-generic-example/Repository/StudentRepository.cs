using System;
using System.Collections.Generic;
using _04_generic_example.Model;

namespace _04_generic_example.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository()
        {
        }

        public void Add(Student item) => Program.s_students.Add(item);
        
        public IList<Student> GetAll() => Program.s_students; 

        public void Remove(Student item) => Program.s_students.Remove(item);
        
    }
}
