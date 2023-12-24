using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class ProductImage : AudiTableEntity, IBaseDomain
    {
        public int? ProcutId { get; set; }
        public string? ImagePath { get; set; }
        public byte[]? Image { get; set; }

        public virtual Product? Procut { get; set; }
    }
}
