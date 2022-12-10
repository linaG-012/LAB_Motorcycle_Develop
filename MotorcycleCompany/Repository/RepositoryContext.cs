using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
//using Microsoft.EntityFrameworkCore.Sq;

namespace Repository
{
    public partial class RepositoryContext : DbContext
    {
        public RepositoryContext()
        {

        }
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
                
        }

        public virtual DbSet<Agency> Agencies { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Garage> Garages { get; set; } = null!;
        public virtual DbSet<Motorcycle> Motorcycles { get; set; } = null!;
        public virtual DbSet<Phone> Phones { get; set; } = null!;
        public virtual DbSet<Rent> Rents { get; set; } = null!;

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

               
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Agency>(entity =>
            {
                entity.Property(e => e.AgencyId).ValueGeneratedNever();
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Garage>(entity =>
            {
                entity.HasKey(e => new { e.GarageId, e.Address });

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Garages)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Garage_City");
            });

            modelBuilder.Entity<Motorcycle>(entity =>
            {
                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Motorcycles)
                    .HasForeignKey(d => new { d.GarageId, d.Address })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Motorcycle_Garage");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasKey(e => new { e.AgencyId, e.PhoneId });

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.AgencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phone_Agency");
            });

            modelBuilder.Entity<Rent>(entity =>
            {
                entity.HasKey(e => new { e.RentId, e.MotorcycleId, e.ClientId, e.AgencyId });

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Rents)
                    .HasForeignKey(d => d.AgencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rent_Agency");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Rents)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rent_Client");

                entity.HasOne(d => d.Motorcycle)
                    .WithMany(p => p.Rents)
                    .HasForeignKey(d => d.MotorcycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rent_Motorcycle");
            });

            // Invocar las clases que contienen las semillas
            modelBuilder.ApplyConfiguration(new AgencyConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
