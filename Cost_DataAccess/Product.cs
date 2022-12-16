﻿using Microsoft.AspNetCore.Identity;
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
        public string Other { get; set; }
        public List<Component> Components { get; set; }
        public bool IsActive { get; set; }
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTimestamp { get; set; }

    }
}
