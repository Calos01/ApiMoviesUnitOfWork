using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetbyId(int id);
        T Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void RangeAdd(IEnumerable<T> listentity);
        void RangeRemove(IEnumerable<T> listentity);
        void Remove(T entity);

    }
}
