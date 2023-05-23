using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Cost_DataAccess
{
    public class Component
    {
        [Key]
        public int ComponentId { get; set; }
        public string Name { get; set; }
        public string UoM { get; set; } //unit of measure kg, liter, kWh, hour, ounce, etc.
        public double Price { get; set; } // price per unit of measure
        public string? Other { get; set; }
        public string UserId { get; set; }
        public double Wastage { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        //public ICollection<Product>? Products { get; set; }
        //public ICollection<ProductComponent> ProductComponent { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTimestamp { get; set; }

    }
}
