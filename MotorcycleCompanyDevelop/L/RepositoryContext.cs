using Entities.Models;
using Microsoft.EntityFrameworkCore;
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

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Phones> Phones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* modelBuilder.ApplyConfiguration(new AgencyConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new GarageConfiguration());
            modelBuilder.ApplyConfiguration(new MotorcycleConfiguration());
            modelBuilder.ApplyConfiguration(new PhonesConfiguration());
            modelBuilder.ApplyConfiguration(new RentConfiguration());
           */
           /* modelBuilder.Entity<Garage>()
           .HasKey("Id");

            modelBuilder.Entity<Phones>()
          .HasKey("Id"); */
        }

        
    }
}
