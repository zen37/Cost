using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
