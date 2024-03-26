using Infrasctructure.Entities;
namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public UserEntity User { get; set; } = null!;

    public AccountProfileInfoViewModel? ProfileInfo { get; set; }

    public AccountBasicInfoViewModel? BasicInfo { get; set; }
    public AccountAddressInfoViewModel? AddressInfo { get; set; }
}
