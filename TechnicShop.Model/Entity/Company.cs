using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Company : AudiTableEntity, IBaseDomain
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxNumber { get; set; }
        public string? TaxAdministration { get; set; }
        public string? Ssnumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? User { get; set; }
    }
}
