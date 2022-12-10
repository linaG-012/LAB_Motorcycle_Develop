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
                    DNI = "1000335604",
                    Name = "Lina",
                    Surname = "Guerrero",
                    SecondSurname = "Cantor",
                    Direction = "crra 16 este numero 36-95 ",
                    City = "Bogota",
                    Phone = "3013870998"
                },
                new Client
                {
                    DNI = "2345656",
                    Name = "Ana",
                    Surname = "Bazquez",
                    SecondSurname = "Gomez",
                    Direction = "crra 96 #6-85 sur ",
                    City = "Pasto",
                    Phone = "3229760993"
                },
                new Client
                {
                    DNI = "1022927448",
                    Name = "Alisson",
                    Surname = "Hernandez",
                    SecondSurname = "Cantor",
                    Direction = "crra 25 #8-63 sur ",
                    City = "santa marta",
                    Phone = "3142030357"
                }

           );
        }

    }
}
