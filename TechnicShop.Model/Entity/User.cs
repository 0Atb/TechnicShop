using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class User : AudiTableEntity, IBaseDomain
    {
        public User()
        {
            Companies = new HashSet<Company>();
            Orders = new HashSet<Order>();
            UserRoles = new HashSet<UserRole>();
        }

        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public Guid? UniqueId { get; set; }
        public int? CityId { get; set; }
        public int? GenderId { get; set; }
        public string? PhoneNumber { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? CountryId { get; set; }

        public virtual City? City { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual MaritalStatus? MaritalStatus { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
