using System.Collections.Generic;
using SequoiaRoot.Domain;

namespace SequoiaRoot.Repository
{
    public interface IRepository<T> where T:IEntity<T>
    {
        T Save(T entity);
        T Update(T entity);
        void delete(int id);
        IEnumerable<T> GetAll();
        T GetByID(int id);
    }
}