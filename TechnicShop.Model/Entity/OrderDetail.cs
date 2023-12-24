using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class OrderDetail : AudiTableEntity, IBaseDomain
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Count { get; set; }
        public int? UnitPrice { get; set; }
        public int? Discount { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
