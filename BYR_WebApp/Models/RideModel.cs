using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace BYR_WebApp.Models
{
    public class RideModel
    {
        public int Price { get; set; }//Wordt berekend?

        [Required(ErrorMessage = "Please fill in the pickup location")]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "From")]
        public string Beginning { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please fill in the destination")]
        [StringLength(maximumLength: 45, MinimumLength = 1)]
        [Display(Name = "To")]
        public string End { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please fill in the Distance for this ride")]
        [Display(Name = "Distance (KM)")]
        public int Distance { get; set; }//Wordt berekend?

        [Required(ErrorMessage = "Please fill in the date")]
        [Display(Name = "Date and Time")]
        public DateTime Date { get; set; }

        public VehicleModel Vehicle { get; set; } = new VehicleModel();
    }
}
