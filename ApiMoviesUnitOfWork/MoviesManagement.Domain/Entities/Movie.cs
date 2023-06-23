using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public Actor? Actor { get; set; }   
        public int ActorId { get; set; }   
        public List<Genere>? Generes { get; set; }   
    }
}
