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
    public class GarageConfiguration : IEntityTypeConfiguration<Garage>
    {
        public void Configure(EntityTypeBuilder<Garage> builder)
        {
            builder.HasData(
                new Garage
                {
                    Id = 1,
                    Name = "Kevin",
                    IdCity = 1,
                    Street = "cr 82 #42 f 56 sur",
                    Num = 123,
                    
                },
                new Garage
                {
                    Id = 2,
                    Name = "Jose",
                    IdCity = 2,
                    Street = "cr 82 #42 f 56 sur",
                    Num = 456,
                }

           );
        }
    }
}
