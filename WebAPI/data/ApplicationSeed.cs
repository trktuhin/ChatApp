using Microsoft.AspNetCore.Identity;
using WebAPI.models;

namespace WebAPI.data;

public class ApplicationSeed
{
    public static async Task SeedUsersAsync(UserManager<ApplicationUser> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new ApplicationUser
            {
                Name = "Robin",
                Email = "robin@gmail.com",
                UserName = "robin@gmail.com"
            };
            await userManager.CreateAsync(user, "Pa$$w0rd");
        }
    }
}
