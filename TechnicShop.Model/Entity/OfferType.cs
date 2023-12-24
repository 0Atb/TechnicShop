using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class OfferType : AudiTableEntity, IBaseDomain
    {
        public OfferType()
        {
            Offers = new HashSet<Offer>();
        }

        public string? Type { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
