using Microsoft.AspNetCore.Identity;

namespace TwoDaysProject.Entities.Identity
{
    public class CustomUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }

    public class CustomRole : IdentityRole
    {

    }
}
