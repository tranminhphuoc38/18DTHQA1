using System;
using System.Collections.Generic;
using _04_generic_example.Model;

namespace _04_generic_example.Repository
{
    public interface IStudentRepository
    {
        void Add(Student item);

        void Remove(Student item);

        IList<Student> GetAll();
    }
}
