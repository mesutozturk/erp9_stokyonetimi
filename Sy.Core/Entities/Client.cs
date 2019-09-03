using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sy.Core.Abstracts;

namespace Sy.Core.Entities
{
    [Table("Clients")]
    public class Client : BaseEntity<int>
    {
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Surname { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
    }
}
