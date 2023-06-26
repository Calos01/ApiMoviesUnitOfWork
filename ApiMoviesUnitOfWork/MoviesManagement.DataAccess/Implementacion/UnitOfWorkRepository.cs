using MoviesManagement.DataAccess.Context;
using MoviesManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.DataAccess.Implementacion
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly MoviesManagementDbContext _context;

        public UnitOfWorkRepository(MoviesManagementDbContext context)
        {
            _context = context;

            Actor = new ActorRepository(_context);
            Biografia = new BiografiaRepository(_context);
            Movie = new MovieRepository(_context);
            Genere=new GenereRepository(_context);
        }
        public IActorRepository Actor { get; private set; }

        public IBiografiaRepository Biografia { get; private set; }

        public IMovieRepository Movie { get; private set; }

        public IGenereRepository Genere { get; private set; }


        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
