using Infrastructure.DataAccess.DTO;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BYR_WebApp.Models
{
    public class CustomerModel
    {
        [Required]
        [StringLength(maximumLength:45, MinimumLength = 10)]
        [Display(Name = "Email Address: ")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "First Name: ")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(maximumLength: 45, MinimumLength = 10)]
        [Display(Name = "Password: ")]
        public string Password { get; set; } = string.Empty;


        //handig om in het model te zetten of ergens anders controleren?
        [Required]
        [StringLength(maximumLength: 45, MinimumLength = 10)]
        [Display(Name = "Confirm your Password: ")]
        public string ConfirmPassword { get; set; } = string.Empty;


        //public List<RideDTO> Rides { get; set; } = new List<RideDTO>();
    }
}
