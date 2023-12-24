using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Header : AudiTableEntity, IBaseDomain
    {
        public string? HeaderName { get; set; }
        public string? HeaderIcon { get; set; }
    }
}
