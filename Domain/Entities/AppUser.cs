using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
/// <summary>
/// Customized class of IdentityUser from Microsoft.AspNetCore.Identity.
/// Contains all the columns thath exists in the db table: dbo.AspNetUsers.
/// </summary>
public class AppUser : IdentityUser<int>
{
    [MaxLength(50, ErrorMessage = "Maximum {1} characters allowed")]
    public string FirstName { get; set; } = null!;
    [MaxLength(50, ErrorMessage = "Maximum {1} characters allowed")]
    public string LastName { get; set; } = null!;
    public int? CompanyId { get; set; }
    //Foreign key 
    [ForeignKey("CompanyId")]
    public Company? Company { get; set; }
}
