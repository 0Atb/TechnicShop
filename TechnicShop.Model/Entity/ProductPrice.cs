using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class ProductPrice : AudiTableEntity, IBaseDomain
    {
        public int? ProductId { get; set; }
        public string? Header { get; set; }
        public string? Explanation { get; set; }
        public decimal? Price { get; set; }

        public virtual Product? Product { get; set; }
    }
}
