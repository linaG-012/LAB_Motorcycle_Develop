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
    public class PhonesConfiguration : IEntityTypeConfiguration<Phones>
    {
        public void Configure(EntityTypeBuilder<Phones> builder)
        {
            builder.HasData(
                new Phones
                {
                    Id = 1,
                    IdAgency = 1,
                    phone = "3219250893",

                },
                new Phones
                {
                    Id = 2,
                    IdAgency = 2,
                    phone = "3514567895",

                }

           );
        }
    }
}
