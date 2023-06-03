using System.ComponentModel.DataAnnotations;

namespace Cost_Models
{
    public class ComponentDTO
    {
        public int ComponentId { get; set; }

        public string UserId { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required]
        [Range(0.01, int.MaxValue, ErrorMessage = "Price must be greater than 0.01")]
        public double Price { get; set; }
        public double? UnitPrice { get; set; }
        public double Wastage { get; set; }
        public string? Vendor { get; set; }

        [Required]
        [Range(0.01, int.MaxValue, ErrorMessage = "Price must be greater than 0.01")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "Please enter unit of measure")]
        public string UoM { get; set; } //unit of measure kg, liter, kWh, hour, ounce, etc.
        public string? Other { get; set; }
    }
}
