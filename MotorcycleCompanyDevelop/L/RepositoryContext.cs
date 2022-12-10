using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgencyConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new GarageConfiguration());
            modelBuilder.ApplyConfiguration(new MotorcycleConfiguration());
            modelBuilder.ApplyConfiguration(new PhonesConfiguration());
            modelBuilder.ApplyConfiguration(new RentConfiguration());

            modelBuilder.Entity<Garage>()
           .HasKey("Id");

            modelBuilder.Entity<Phones>()
          .HasKey("Id");
        }

        public DbSet<Agency> Agencias { get; set; }
        public DbSet<City> Ciudad { get; set; }
        public DbSet<Client> Cliente { get; set; }
        public DbSet<Garage> Garaje { get; set; }
        public DbSet<Motorcycle> Motocicleta { get; set; }
        public DbSet<Phones> Celular { get; set; }
        public DbSet<Rent> Renta { get; set; }
    }
}
