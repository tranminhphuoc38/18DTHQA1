using System;
using System.Collections.Generic;
using _04_generic_example.Model;

namespace _04_generic_example.Repository
{
    public class ClassRepository : IClassRepository
    {
        private IList<Class> _data;

        public ClassRepository(IList<Class> data)
        {
            _data = data;
        }

        public void Add(Class item) => _data.Add(item);

        public IList<Class> GetAll() => _data;
        
        public void Remove(Class item) => _data.Remove(item);
    }
}
