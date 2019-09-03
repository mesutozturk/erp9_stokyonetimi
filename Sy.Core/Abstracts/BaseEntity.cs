using System.ComponentModel.DataAnnotations;

namespace Sy.Core.Abstracts
{
    public abstract class BaseEntity<TKey> : AuditBase, IEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
