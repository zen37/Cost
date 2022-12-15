using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Models
{
    public class ComponentDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name..")]
        public string Name { get; set; }

        [Required]
        [Range(0.01, int.MaxValue, ErrorMessage = "Price must be greater than 0.01")]
        public double Price { get; set; } // price per unit of measure

        [Required]
        public string UoM { get; set; } //unit of measure kg, liter, kWh, hour, ounce, etc.
        public string Other { get; set; }
    }
}
