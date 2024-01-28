using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Company : AudiTableEntity, IBaseDomain
    {
        public int? UserId { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxNumber { get; set; }
        public string? TaxAdministration { get; set; }
        public string? Ssnumber { get; set; }

        public virtual User? User { get; set; }
    }
}
