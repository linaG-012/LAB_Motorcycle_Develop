using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public List<Garage> Garages { get; set; }

        //[Required(ErrorMessage = "City Name is required field")]
        //[MaxLength(30, ErrorMessage = "Maximun lenght for the Name is 30 characters")]
        //public string? Name { get; set; }

        //[Required(ErrorMessage = "City Province is required field")]
        //[MaxLength(30, ErrorMessage = "Maximun lenght for the Province is 30 characters")]
        //public string Province { get; set; }

        //[Required(ErrorMessage = "City Population is required field")]
        //public int Population { get; set; }



        //[InverseProperty("Garaje")]
        //public ICollection<Garage> Garage_City { get; set; }

    }
}
