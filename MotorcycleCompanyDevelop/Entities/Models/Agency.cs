using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Agency
    {
        public object name;

        [Key]
        [Column("AgencyId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Agency name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun lenght for the name is 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Agency direction is required field")]
        [MaxLength(120, ErrorMessage = "Maximun lenght for the direction is 120 characters")]
        public string Direction { get; set; }

        [Required(ErrorMessage = "Agency poblation is required field")]
        [MaxLength(60, ErrorMessage = "Maximun lenght for the poblation is 60 characters")]
        public  string Poblation { get; set; }




        [InverseProperty("Agencia")]
        public ICollection<Rent> Rents_Agency { get; set; } 
        
        
        [InverseProperty("Agencia")]
        public ICollection<Motorcycle> Motorcycle_Agency { get; set; }


        [InverseProperty("Agencia")]
        public ICollection<Phones> Phones_Agency { get; set; }


    }
}
