using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table("Baker", Schema = "Supplier")]
    public class Baker
    {
        public int BakerID { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Bread> Breads { get; set; }
    }
}
