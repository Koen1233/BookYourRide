using Infrastructure.DataAccess.DTO;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BYR_WebApp.Models
{
    public class CustomerModel
    {
        //Minimale lengte i.i.g. 1, ivm app testing (email, pw = a,a of b,b) makkelijk ingloggen/registreren

        [Required(ErrorMessage = "Please enter your Email address")]
        [StringLength(maximumLength:45, MinimumLength = 1)]
        [Display(Name = "Email Address: ")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your First Name")]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your Last Name")]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your Password")]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "Password: ")]
        public string Password { get; set; } = string.Empty;


        //handig om in het model te zetten of ergens anders controleren?
        [Required(ErrorMessage = "Please confirm your Password")]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "Confirm password: ")]
        public string ConfirmPassword { get; set; } = string.Empty;


        //public List<RideDTO> Rides { get; set; } = new List<RideDTO>();
    }
}
