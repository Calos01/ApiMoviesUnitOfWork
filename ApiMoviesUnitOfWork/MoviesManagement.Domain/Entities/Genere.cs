using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Entities
{
    public class Genere
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public List<Movie>? Movies { get; set; } 
    }
}
