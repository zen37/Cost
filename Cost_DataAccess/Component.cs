using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Cost_DataAccess
{
    public class Component
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UoM { get; set; } //unit of measure kg, liter, kWh, hour, ounce, etc.
        public double Price { get; set; } // price per unit of measure
        public string Other { get; set; }
        public bool IsActive { get; set; }

        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }

    }
}
