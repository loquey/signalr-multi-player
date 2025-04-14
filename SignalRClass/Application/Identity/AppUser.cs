using Microsoft.AspNetCore.Identity;

namespace SignalRClass.Application.Identity
{
    public class AppUser :IdentityUser
    {
        public string Nickname { get; set; } = default;
        public string FirstName { get; set; } = default;
        public string LastName { get; set; } = default;
    }
}
