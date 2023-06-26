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
    public class GenereRepository:GenericRepository<Genere>,IGenereRepository
    {
        public GenereRepository(MoviesManagementDbContext context) : base(context)
        {
            
        }
    }
}
