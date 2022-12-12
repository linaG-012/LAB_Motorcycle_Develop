using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Phones
    {

        [Key]
        public int Id { get; set; }

        //[Key]
        //public int IdAgency { get; set; }

        //[Key]
        [MaxLength(30)]
        public string phone { get; set; }

        //public Agency Agencia { get; set; }

        public Agency Agency { get; set; }
    }
}
