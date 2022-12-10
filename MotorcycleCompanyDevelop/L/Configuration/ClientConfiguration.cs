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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData(
                new Client
                {
                    DNI = "1049794204",
                    Name = "Kevin",
                    Surname = "Moreno",
                    SecondSurname = "Ramirez",
                    Direction = "cr 82 #42 f 56 sur",
                    City = "Bogota",
                    Phone = "3219250893"
                },
                new Client
                {
                    DNI = "23622563",
                    Name = "Luz",
                    Surname = "Banish",
                    SecondSurname = "Sayns",
                    Direction = "calle 13 #4-37",
                    City = "Guateque",
                    Phone = "3145463634"
                }

           );
        }

    }
}
