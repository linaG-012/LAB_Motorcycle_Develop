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
    public class MotorcycleConfiguration : IEntityTypeConfiguration<Motorcycle>
    {
        public void Configure(EntityTypeBuilder<Motorcycle> builder)
        {
            builder.HasData(
                new Motorcycle
                {
                    Id = 1,
                    NumBast = "White",
                    Color = "Blue",
                    Brand = "Ferrari",
                    model = "C-666",
                    IdGarage =1,
                    Street ="Griislong",
                    Num=123,
                    Date = DateTime.Today,
                    IdAgency =1,

                },
                new Motorcycle
                {
                    Id = 2,
                    NumBast = "Dark",
                    Color = "Red",
                    Brand = "Supra",
                    model = "Z-333",
                    IdGarage =2,
                    Street ="Smile",
                    Num =345,
                    Date =DateTime.Today,
                    IdAgency =2,
                }

           );
        }
    }
}
