using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    [Table("Burger", Schema = "Production")]
    public class Burger : Product
    {
        [Required]
        public int Weight { get; set; }

        public int? BeefWeight { get; set; }

        public Bread? Bread { get; set; }
    }
}
