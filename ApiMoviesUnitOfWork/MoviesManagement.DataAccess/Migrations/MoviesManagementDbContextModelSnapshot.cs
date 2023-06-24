﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesManagement.DataAccess.Context;

#nullable disable

namespace MoviesManagement.DataAccess.Migrations
{
    [DbContext(typeof(MoviesManagementDbContext))]
    partial class MoviesManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenereMovie", b =>
                {
                    b.Property<int>("GeneresId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("GeneresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenereMovie");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Chacalon",
                            LastName = "Junior"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Chapita",
                            LastName = "Scalante"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Jorsh",
                            LastName = "Bush"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Chicarita",
                            LastName = "Lissent"
                        });
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Biografia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ActorId")
                        .IsUnique();

                    b.ToTable("Biografias");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Genere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generes");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            Description = "Pelicula bored",
                            Name = "La Laland"
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 1,
                            Description = "Pelicula para nacos",
                            Name = "Moonlight"
                        },
                        new
                        {
                            Id = 3,
                            ActorId = 2,
                            Description = "Obra Maestra",
                            Name = "Barry"
                        });
                });

            modelBuilder.Entity("GenereMovie", b =>
                {
                    b.HasOne("MoviesManagement.Domain.Entities.Genere", null)
                        .WithMany()
                        .HasForeignKey("GeneresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesManagement.Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Biografia", b =>
                {
                    b.HasOne("MoviesManagement.Domain.Entities.Actor", "Actor")
                        .WithOne("Biografia")
                        .HasForeignKey("MoviesManagement.Domain.Entities.Biografia", "ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Movie", b =>
                {
                    b.HasOne("MoviesManagement.Domain.Entities.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("MoviesManagement.Domain.Entities.Actor", b =>
                {
                    b.Navigation("Biografia");

                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}