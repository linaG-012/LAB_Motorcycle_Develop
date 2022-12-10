using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.HasData(
                new Rent
                {
                    Id = 1,
                    IdAgency = 1,
                    IdMotorcycle = 1,
                    DNIClient = "1049794204",
                    dateI = DateTime.Today,
                    dateF = DateTime.Today,
                    dateR = DateTime.Today,
                    Price = 1000,
                    Paidout = "Yes"
                },
                new Rent
                {
                    Id = 2,
                    IdAgency = 2,
                    IdMotorcycle = 2,
                    DNIClient = "23622563",
                    dateI = DateTime.Today,
                    dateF = DateTime.Today,
                    dateR = DateTime.Today,
                    Price = 2000,
                    Paidout = "No"
                }

           );
        }
    }
}
