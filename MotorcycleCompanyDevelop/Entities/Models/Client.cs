using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Client
    {
        [Key]
        [MaxLength(9, ErrorMessage = "Maximun lenght for the DNI is 9 characters")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Client Name is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the Name is 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Client FirstName is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the PrimerApellido is 60 characters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Client SecondName is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the SegundoApellido is 60 characters")]
        public string SecondSurname { get; set; }

        [Required(ErrorMessage = "Client Direction is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the Direccion is 60 characters")]
        public string Direction { get; set; }

        [Required(ErrorMessage = "Client City is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the Ciudad is 60 characters")]
        public string City { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Client Phone is required field")]
        public string Phone { get; set; }


        [InverseProperty("Cliente")]
        public  ICollection<Rent> Rents_Client { get; set; }


    }
}
