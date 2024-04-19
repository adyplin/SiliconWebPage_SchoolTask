using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class SubscribeViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "E-mail address", Prompt ="Your Email")]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;
    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupWeekly { get; set; }
    public bool Podcasts { get; set; }


}
