using System;
using System.ComponentModel.DataAnnotations;

namespace Sy.Core.Abstracts
{
    public abstract class AuditBase
    {
        [StringLength(50)]
        public string CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [StringLength(50)]
        public string UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
