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
    internal class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MoviesManagementDbContext context) : base(context)
        {
        }
    }
}
