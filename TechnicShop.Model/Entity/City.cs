using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class City : AudiTableEntity, IBaseDomain
    {
        public City()
        {
            Admins = new HashSet<Admin>();
            Users = new HashSet<User>();
        }

        public string? Name { get; set; }
        public string? PlateCode { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
