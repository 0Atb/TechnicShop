using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Offer : AudiTableEntity, IBaseDomain
    {
        public Offer()
        {
            OrderOffers = new HashSet<OrderOffer>();
        }

        public string? Header { get; set; }
        public string? Explanation { get; set; }
        public decimal? Sale { get; set; }
        public bool? SpecialOffer { get; set; }
        public int? OfferTypeId { get; set; }

        public virtual OfferType? OfferType { get; set; }
        public virtual ICollection<OrderOffer> OrderOffers { get; set; }
    }
}
