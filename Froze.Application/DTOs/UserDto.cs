using Froze.Domain.Entities;

namespace Froze.Application.DTOs;

public class UserDto
{
    public int UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public int? IdentityServerUserId { get; set; }
    public bool IsActive { get; set; } = true;
    public string UserType { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

}
