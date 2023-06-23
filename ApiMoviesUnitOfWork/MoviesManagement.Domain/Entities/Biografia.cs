using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Entities
{
    public class Biografia
    {
        public int Id { get; set; }
        public string Description { get; set; }=string.Empty;
        public Actor? Actor { get; set; }
        public int ActorId { get; set; }
    }
}
