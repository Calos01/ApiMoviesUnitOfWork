using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Repository
{
    public interface IUnitOfWorkRepository:IDisposable
    {
        IActorRepository Actor { get; }
        IBiografiaRepository Biografia { get; }
        IMovieRepository Movie { get; }
        IGenereRepository Genere { get; }
        int Save();
    }
}
