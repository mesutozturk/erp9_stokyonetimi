using Sy.Core.Enums;

namespace Sy.Core.ViewModels
{
    public class UserInfoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public ApplicationRole ApplicationRole { get; set; }
        public string Display => $"{Name} {Surname} - {ApplicationRole}";
    }
}
