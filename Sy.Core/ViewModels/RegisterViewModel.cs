using System.ComponentModel.DataAnnotations;

namespace Sy.Core.ViewModels
{
    public class RegisterViewModel
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Surname { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
    }
}
