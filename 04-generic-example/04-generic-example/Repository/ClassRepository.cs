using System;
using System.Collections.Generic;
using _04_generic_example.Model;

namespace _04_generic_example.Repository
{
    public class ClassRepository : IClassRepository
    {
        public ClassRepository()
        {
        }

        public void Add(Class item) => Program.s_classes.Add(item);

        public IList<Class> GetAll() => Program.s_classes;
        
        public void Remove(Class item) => Program.s_classes.Remove(item);
    }
}
