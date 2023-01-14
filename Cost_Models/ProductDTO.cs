using Cost_DataAccess;
using System.ComponentModel.DataAnnotations;


namespace Cost_Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = "Please enter name..")]
        public string Name { get; set; }
        public double Cost { get; set; }
        public string? Other { get; set; }

        //[Required(ErrorMessage = "Please enter at least one ingredient..")]
        //public List<Component> Components { get; set; }
    }
}
