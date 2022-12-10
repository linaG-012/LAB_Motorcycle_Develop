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
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City
                {
                    Id = 1,
                    Name = "Kevin",
                    Province = "Kennedy",
                    Population = 1000
                },
                new City
                {
                    Id = 2,
                    Name = "Jose",
                    Province = "Guateque",
                    Population = 10000
                }

           );
        }
    }
}
