using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Order : AudiTableEntity, IBaseDomain
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            OrderOffers = new HashSet<OrderOffer>();
        }

        public DateTime? OrderDate { get; set; }
        public decimal? TotalOrderPrice { get; set; }
        public int? UserId { get; set; }
        public decimal? Discount { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderOffer> OrderOffers { get; set; }
    }
}
