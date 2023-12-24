using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Bank : AudiTableEntity, IBaseDomain
    {
        public string? BankName { get; set; }
        public string? BankIcon { get; set; }
    }
}
