using Microsoft.AspNetCore.Identity;
namespace Infrasctructure.Entities;

public class UserEntity : IdentityUser
{
    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;

    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;

    public int? AdressId { get; set; }
    public AddressEntity? Address { get; set; }
}
