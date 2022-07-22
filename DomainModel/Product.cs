using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace DomainModel
{
    [Table("Product", Schema = "Production")]
    public abstract class Product
    {
        public int ProductID { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        [Required]
        public decimal Price { get; set; }

        [StringLength(350)]
        public string? Description { get; set; }

        [Required]
        public int Stockpiled { get; set; }

        public Nutrition? Nutrition { get; set; }

        public ICollection<Discount>? Discounts { get; set; }
    }
}

