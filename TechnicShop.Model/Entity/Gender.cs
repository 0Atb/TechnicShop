using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Gender : AudiTableEntity, IBaseDomain
    {
        public Gender()
        {
            Admins = new HashSet<Admin>();
            Users = new HashSet<User>();
        }

        public string? GenderName { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
