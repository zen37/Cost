using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_DataAccess
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; } // price per unit of measure
        public string Other { get; set; }

        public List<Component> Components { get; set; }
        public bool IsActive { get; set; }

        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }

    }
}
