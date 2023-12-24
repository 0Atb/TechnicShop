using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Role : AudiTableEntity, IBaseDomain
    {
        public Role()
        {
            AdminRoles = new HashSet<AdminRole>();
            UserRoles = new HashSet<UserRole>();
        }

        public string? RoleName { get; set; }

        public virtual ICollection<AdminRole> AdminRoles { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
