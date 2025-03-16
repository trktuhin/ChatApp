using Microsoft.AspNetCore.Identity;

namespace WebAPI.models;
public class ApplicationUser : IdentityUser
{
    public required string Name { get; set; }
}

