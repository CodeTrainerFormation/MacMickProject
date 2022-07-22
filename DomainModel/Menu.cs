using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    [Table("Menu", Schema = "Production")]
    public class Menu : Product
    {
        [Required]
        public Burger Burger { get; set; }

        public int BurgerId { get; set; }

        [Required]
        public Side Side { get; set; }

        public int SideId { get; set; }

        [Required]
        public Beverage Beverage { get; set; }

        public int BeverageId { get; set; }

        public Dessert? Dessert { get; set; }

        public int? DessertId { get; set; }
    }
}
