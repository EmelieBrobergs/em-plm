using Domain.Entities;
using System.Security.Claims;

namespace Application.Common.Interfaces;

public interface ITokenService
{
    string GenerateJwtToken(AppUser user, List<System.Security.Claims.Claim> claims);
    //object GenerateJwtToken(AppUser user, Task<IList<Claim>> roles);
}
