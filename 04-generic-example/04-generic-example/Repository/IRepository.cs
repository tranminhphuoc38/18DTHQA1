using System.Collections.Generic;

namespace _04_generic_example.Repository
{
    public interface IRepository<T>
    {
        void Add(T item);

        void Remove(T item);

        IList<T> GetAll();
    }
}
