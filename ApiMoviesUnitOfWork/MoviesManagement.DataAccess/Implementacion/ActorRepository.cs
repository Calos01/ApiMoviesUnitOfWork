using Microsoft.EntityFrameworkCore;
using MoviesManagement.DataAccess.Context;
using MoviesManagement.Domain.Entities;
using MoviesManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.DataAccess.Implementacion
{
    public class ActorRepository:GenericRepository<Actor>, IActorRepository 
    {
        public ActorRepository(MoviesManagementDbContext context):base(context)
        {
            
        }

        public IEnumerable<Actor> GetActorWithMovies()
        {
            return _context.Actors.Include(a => a.Movies).ToList();
        }
    }
}
