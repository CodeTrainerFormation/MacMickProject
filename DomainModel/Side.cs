using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table("Side", Schema = "Production")]
    public class Side : Product
    {
        [Required]
        public int Weight { get; set; }

        public int? SaltWeight { get; set; }
    }
}
