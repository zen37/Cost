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
    public class ProductComponentDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int? ComponentIngredientId { get; set; }
        public int? ComponentProductId { get; set; }
        public double Amount { get; set; }
        public string? FromUoM { get; set; }
        public string UoM { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public double FromPrice { get; set; } = 0;
        public double FromPriceWastage { get; set; } = 0;
        public double Price { get; set; } = 0;
        public double PriceWastage { get; set; } = 0;
    }
}
