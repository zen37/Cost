using Cost_DataAccess;
using System.ComponentModel.DataAnnotations;


namespace Cost_Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter name..")]
        public string Name { get; set; }
        public double Cost { get; set; }
        public double CostWastage { get; set; }
        public double? CostPercentage { get; set; }
        public double? CostWastagePercentage { get; set; }
        public string? Other { get; set; }
    }
}
