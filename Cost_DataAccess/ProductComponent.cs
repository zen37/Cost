using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_DataAccess
{
    public class ProductComponent
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? ComponentIngredientId { get; set; }
        public int? ComponentProductId { get; set; }
        public double Amount { get; set; }
    }
}
