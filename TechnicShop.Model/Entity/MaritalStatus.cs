using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class MaritalStatus : AudiTableEntity, IBaseDomain
    {
        public MaritalStatus()
        {
            Admins = new HashSet<Admin>();
            Users = new HashSet<User>();
        }

        public string? MartialStatusName { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
