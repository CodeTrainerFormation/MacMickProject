using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table("Nutrition", Schema = "Information")]
    public class Nutrition
    {
        public int NutritionID { get; set; }

        public int? Calories { get; set; }

        public int? Protein { get; set; }

        public int? Fat { get; set; }

        public int? Carbohydrates { get; set; }

        public int? Sodium { get; set; }

        [Required]
        public Product Product { get; set; }
        public int ProductID { get; set; }
    }
}
