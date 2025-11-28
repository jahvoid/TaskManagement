using Microsoft.AspNetCore.Identity;
namespace IdentityManagement.Core.Models;
public class ApplicationRole : IdentityRole
{
public string? Description { get; set; }
}