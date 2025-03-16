using Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using WebAPI.models;
using System.Text;
using WebAPI.interfaces;
using WebAPI.services;

namespace WebAPI.extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ITokenService, TokenService>();
        return services;
    }
    public static IServiceCollection AddIdentityServices(this IServiceCollection services,
            IConfiguration config)
    {
        var builder = services.AddIdentityCore<ApplicationUser>();

        builder = new IdentityBuilder(builder.UserType, builder.Services);
        builder.AddEntityFrameworkStores<ApplicationDbContext>();
        builder.AddSignInManager<SignInManager<ApplicationUser>>();

        var secretKey = config["Token:Key"] ?? "";

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                    ValidIssuer = config["Token:Issuer"],
                    ValidateIssuer = true,
                    ValidateAudience = false
                };
            });

        return services;
    }
}
