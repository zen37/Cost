using System.ComponentModel.DataAnnotations;

namespace Cost_Models
{
    public class ComponentDTO
    {
        public int Id { get; set; }
        public string UserID { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required]
        //  [Range(typeof(double), "0.01", "2000000000", ErrorMessage = "Price must be greater than 0.01")]
        [Range(0.01, int.MaxValue, ErrorMessage = "Price must be greater than 0.01")]
        public double Price { get; set; } // price per unit of measure

        [Required(ErrorMessage = "Please enter unit of measure")]
        public string UoM { get; set; } //unit of measure kg, liter, kWh, hour, ounce, etc.
        public string? Other { get; set; }
    }
}
