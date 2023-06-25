using MoviesManagement.DataAccess.Context;
using MoviesManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.DataAccess.Implementacion
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly MoviesManagementDbContext _context;

        public GenericRepository(MoviesManagementDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Find(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetbyId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void RangeAdd(IEnumerable<T> listentity)
        {
            _context.Set<T>().AddRange(listentity);
        }

        public void RangeRemove(IEnumerable<T> listentity)
        {
            _context.Set<T>().RemoveRange(listentity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

    }
}
