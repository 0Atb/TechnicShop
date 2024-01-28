using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public class AudiTableEntity
    {
        //AuditedEntity,BaseEntity
        public int Id { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }



        //public Guid Id { get; set; } //PostgreSql de yeni ve genelde bu şekilde kullanılıyor.
        //public Nullable<int> CreatedBy { get; set; }
        //public Nullable<DateTime> CreatedDate { get; set; }
        //public Nullable<int> LastProcessUser { get; set; }
        //public Nullable<DateTime> UpdatedDate { get; set; }
        //public Nullable<bool> IsDeleted { get; set; }
    }
}
