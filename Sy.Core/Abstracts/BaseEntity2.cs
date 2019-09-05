using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sy.Core.Abstracts
{
    public abstract class BaseEntity2<TKey1, TKey2> : AuditBase, IEntity2<TKey1, TKey2>
    {
        [Key]
        [Column(Order = 1)]
        public TKey1 Id { get; set; }
        [Key]
        [Column(Order = 2)]
        public TKey2 Id2 { get; set; }
    }
}
