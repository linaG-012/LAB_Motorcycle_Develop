using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("Phone")]
    public partial class Phone
    {
        [Key]
        public Guid AgencyId { get; set; }
        [Key]
        [StringLength(20)]
        public string PhoneId { get; set; } = null!;

        [ForeignKey("AgencyId")]
        [InverseProperty("Phones")]
        public virtual Agency Agency { get; set; } = null!;
    }
}
