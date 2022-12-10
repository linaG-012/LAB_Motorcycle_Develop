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
    public class AgencyConfiguration : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.HasData(
                new Agency
                {
                    Id = 1,
                    Name = "Kevin",
                    Direction = "Calle del recuerdo",
                    Poblation = "Santa Barbara"
                },
                new Agency
                {
                    Id = 2,
                    Name = "Jose",
                    Direction = "Calle de la soledad",
                    Poblation = "Santa Ana"
                }

           );
        }
    }
}
