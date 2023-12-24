using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TechnicShop.Model.Entity
{
    public partial class Category : AudiTableEntity, IBaseDomain
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string? CategoryName { get; set; }
        public int? MainCategoryId { get; set; }
        public string? CategoryInformation { get; set; }
        public int? Sorting { get; set; }
        public string? Explanation { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
