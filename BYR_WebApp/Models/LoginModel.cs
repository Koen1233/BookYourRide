using System.ComponentModel.DataAnnotations;

namespace BYR_WebApp.Models
{
    public class LoginModel
    {

        //Minimale lengte i.i.g. 1, ivm app testing (email, pw = a,a of b,b) makkelijk ingloggen/registreren

        [Required(ErrorMessage = "Please enter your email address")]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "Email Address")]

        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage ="Enter your password")]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "Password")]

        public string Password { get; set; } = string.Empty;

    }
}
