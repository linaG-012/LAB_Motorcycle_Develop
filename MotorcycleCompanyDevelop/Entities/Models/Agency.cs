using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Agency")]
    public partial class Agency
    {

        [Key]
        [Column("AgencyId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Agency name is required field")]
        [MaxLength(60, ErrorMessage = "Maximun lenght for the name is 60 characters")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Agency direction is required field")]
        [MaxLength(120, ErrorMessage = "Maximun lenght for the direction is 120 characters")]
        public string Direction { get; set; }

        [Required(ErrorMessage = "Agency poblation is required field")]
        [MaxLength(60, ErrorMessage = "Maximun lenght for the poblation is 60 characters")]
        public string Poblation { get; set; }

        public List<Phones> Phones { get; set; }
    }
}
