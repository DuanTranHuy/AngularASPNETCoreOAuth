using AuthServer.Infrastructure.Data.Identity;

namespace AuthServer.Models
{
    public class RegisterResponseViewModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public RegisterResponseViewModel(AppUser user)
        {
            Id = user.Id;
            FullName = user.FullName;
            Email = user.Email;
        }
    }
}
