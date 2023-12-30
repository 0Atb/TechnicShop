using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Header : AudiTableEntity, IBaseDomain
    {
        public string? Name { get; set; }
        public string? Icon { get; set; }
    }
}
