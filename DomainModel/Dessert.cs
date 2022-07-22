using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table("Dessert", Schema = "Production")]
    public class Dessert : Product
    {
        [Required]
        public double Milliliter { get; set; }

        [Required]
        public bool IsFrozen { get; set; }
    }
}
