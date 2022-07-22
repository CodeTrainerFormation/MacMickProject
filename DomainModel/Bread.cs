using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table("Bread", Schema = "Supplier")]
    public class Bread
    {
        public int BreadId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool HasSesameSeed { get; set; }

        public Burger Burger { get; set; }
        public int BurgerId { get; set; }

        public ICollection<Baker> Bakers { get; set; }
    }
}
