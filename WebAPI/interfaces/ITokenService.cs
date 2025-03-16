using WebAPI.models;

namespace WebAPI.interfaces;

public interface ITokenService
{
    string CreateToken(ApplicationUser user);
}
