﻿using MoviesManagement.DataAccess.Context;
using MoviesManagement.Domain.Entities;
using MoviesManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.DataAccess.Implementacion
{
    public class BiografiaRepository:GenericRepository<Biografia>, IBiografiaRepository
    {
        public BiografiaRepository(MoviesManagementDbContext context) : base(context)
        {
            
        }
    }
}
