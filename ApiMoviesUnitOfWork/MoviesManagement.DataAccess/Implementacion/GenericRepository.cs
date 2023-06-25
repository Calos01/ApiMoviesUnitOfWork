using MoviesManagement.DataAccess.Context;
using MoviesManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.DataAccess.Implementacion
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MoviesManagementDbContext _context;

        public GenericRepository(MoviesManagementDbContext context)
        {
            _context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetForId(T entity)
        {
            
        }
    }
}
