//using Application.Common.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace WebUI.WorkerServices;

public interface IScopedRoleSeederService
{
    Task DoWork(CancellationToken stoppingToken);
}
public class ScopedRoleSeederService: IScopedRoleSeederService
{
    private readonly ILogger<ScopedRoleSeederService> _logger;
    private static RoleManager<IdentityRole<int>> _roleManager = null!;


    public ScopedRoleSeederService( ILogger<ScopedRoleSeederService> logger, RoleManager<IdentityRole<int>> roleManager)
    {
        _logger = logger;
        _roleManager = roleManager;
    }

    public async Task DoWork(CancellationToken stoppingToken)
    {
        try
        {
            await SeedRoles();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Could not sync shared data");
        }
    }

    private async Task<bool> SeedRoles()
    {
        var claims = CreateClaims();
        //
        // await CreateRole("Administrator", adminClaimsToAdd);
        await CreateRole("Administrator", claims);
        await CreateRole("Super user", claims);
        await CreateRole("Basic user", claims); // FRÅGA: Går det att lägga till calims med vilken Company de har tillgång till?

        return await Task.FromResult(true);
    }

    private Claim[] CreateClaims()
    {
        return Array.Empty<Claim>();
    }

    private static async Task CreateRole(string name, IEnumerable<Claim> claimsToAdd)
    {
        if (await _roleManager.FindByNameAsync(name) == null) await _roleManager.CreateAsync(new IdentityRole<int> { Name = name });


        var role = await _roleManager.FindByNameAsync(name);

        var claims = await _roleManager.GetClaimsAsync(role);

        if (claims != null)
            foreach (var claim in claimsToAdd)
                if (!claims.AsQueryable().Any(x => x.Value == claim.Value))
                    await _roleManager.AddClaimAsync(role, claim);
    }
}
