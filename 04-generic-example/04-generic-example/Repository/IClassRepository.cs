using System;
using System.Collections.Generic;
using _04_generic_example.Model;

namespace _04_generic_example.Repository
{
    public interface IClassRepository
    {
        void Add(Class item);

        void Remove(Class item);

        IList<Class> GetAll();
    }
}
