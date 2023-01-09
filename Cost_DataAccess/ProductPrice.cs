using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_DataAccess
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public int ComponentId { get; set; }
        public Product Product { get; set; }
        public Component Component { get; set; }
        public string ComponentUoM { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
    }
}
