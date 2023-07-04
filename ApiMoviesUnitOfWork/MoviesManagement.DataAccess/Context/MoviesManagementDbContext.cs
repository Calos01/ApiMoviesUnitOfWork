using Microsoft.EntityFrameworkCore;
using MoviesManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.DataAccess.Context
{
    //jalamos DbContext de los core
    public class MoviesManagementDbContext:DbContext
    {
        //Usamos DbContextOptions para usar DbSet ->Nos permite  generar las tablas en la bd
        //options usaras en el program.cs quien es el contenedor de injeccion de dependencias
        public MoviesManagementDbContext(DbContextOptions<MoviesManagementDbContext> options):base (options)
        {
  
        }
        //DbSet se guia de nuestros entities(models) para generar las Tablas en la bd
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Biografia> Biografias { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genere> Generes { get; set; }

        //Override significa que debe hacer algo mas
        //Mientras genera las tablas se ira creando los datos que queramos OnModelCreating-snippet
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                    new Actor{ Id= 1, FirstName="Chacalon", LastName="Junior"},
                    new Actor{ Id= 2, FirstName="Chapita", LastName="Scalante"},
                    new Actor{ Id= 3, FirstName="Jorsh", LastName="Bush"},
                    new Actor{ Id= 4, FirstName="Chicarita", LastName="Lissent"}
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie{ Id= 1, Name="La Laland", Description="Pelicula bored", ActorId=1},
                    new Movie{ Id= 2, Name="Moonlight", Description="Pelicula para nacos", ActorId=1},
                    new Movie{ Id= 3, Name="Barry", Description="Obra Maestra", ActorId=2}
                );

        }
    }
}
