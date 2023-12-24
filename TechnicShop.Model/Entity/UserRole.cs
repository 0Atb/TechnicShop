using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class UserRole : AudiTableEntity, IBaseDomain
    {
        public int? UserId { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual User? User { get; set; }
    }
}
