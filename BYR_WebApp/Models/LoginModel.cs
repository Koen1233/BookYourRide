using System.ComponentModel.DataAnnotations;

namespace BYR_WebApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [StringLength(maximumLength: 45, MinimumLength = 10)]
        [Display(Name = "Email Address")]

        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage ="Enter your password")]
        [StringLength(maximumLength: 45, MinimumLength = 5)]
        [Display(Name = "Password")]

        public string Password { get; set; } = string.Empty;

    }
}
