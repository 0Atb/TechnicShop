using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Product : AudiTableEntity, IBaseDomain
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductPrices = new HashSet<ProductPrice>();
        }

        public string? ProductName { get; set; }
        public string? Explanation { get; set; }
        public int? Stock { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
