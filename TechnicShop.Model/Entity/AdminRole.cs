using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class AdminRole : AudiTableEntity, IBaseDomain
    {
        public int? AdminId { get; set; }
        public int? RoleId { get; set; }

        public virtual Admin? Admin { get; set; }
        public virtual Role? Role { get; set; }
    }
}
