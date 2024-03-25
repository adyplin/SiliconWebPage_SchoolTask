using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class AccountBasicInfoViewModel
{
    [DataType(DataType.ImageUrl)]
    public string? ProfileImage { get; set; }
    public string UserId { get; set; } = null!;



    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Please enter a valid e-mail adress")]
    public string Email { get; set; } = null!;


    [Display(Name = "Phone (optional)", Prompt = "Enter your phone number", Order = 3)]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }

    [Display(Name = "Bio (optional)", Prompt = "Add a short bio...", Order = 4)]
    [DataType(DataType.MultilineText)]
    public string? Biography { get; set; }
}
