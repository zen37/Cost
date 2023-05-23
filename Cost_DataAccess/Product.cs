using Azure;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cost_DataAccess
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public DateTime CostCalculatedLast { get; set; }
        [NotMapped]
        public double CostDynamic{ get; set; }
        public double CostWastage { get; set; }
        public string? Other { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        //public ICollection<Component>? Components { get; set; }
        //public ICollection<ProductComponent> ProductComponent { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTimestamp { get; set; }

    }
}
