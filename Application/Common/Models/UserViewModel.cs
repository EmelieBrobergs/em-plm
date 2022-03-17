using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Models;

public class UserViewModel : IMapFrom<AppUser>

{
    public string Id { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public int? CompanyId { get; set; }
}
