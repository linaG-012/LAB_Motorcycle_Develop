using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Garage
    {

        [Key]
        public int Id { get; set; }



        public int CityId { get; set; }
        public City City { get; set; }

        //[Key]
        //public int IdCity { get; set; }

        //[Key]
        //[MaxLength(30, ErrorMessage = "Maximun lenght for the Street is 30 characters")]
        //public string Street { get; set; }

        //[Key]
        //public int Num { get; set; }

        //[Required(ErrorMessage = "Garage Name is required field")]
        //[MaxLength(30, ErrorMessage = "Maximun lenght for the Name is 30 characters")]
        //public string Name { get; set; }



        //[InverseProperty("Garaje")]
        //public ICollection<Motorcycle> Motorcycle_Garage { get; set; }


        //[ForeignKey("IdCity")]
        //[InverseProperty("Garage_City")]
        //public City Garaje { get; set; }


    }
}
