using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class SocialMedium : AudiTableEntity, IBaseDomain
    {
        public string? SocialMediaName { get; set; }
        public string? SocialMediaPath { get; set; }
        public string? SocialMediaIcon { get; set; }
    }
}
