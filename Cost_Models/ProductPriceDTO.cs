using Cost_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Models
{
    public class ProductPriceDTO
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        [Required]
        public int ComponentId { get; set; }
        public string ComponentUoM { get; set; }
        [Required]
        public double Amount { get; set; }
    }
}
