using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Runtime.CompilerServices;

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

        [Required(ErrorMessage = "Please select a date and time")]
        [Display(Name = "Date and Time")]
        public DateTime Date { get; set; }

        //Zo een Vehicle en Cargo object toevoegen of los als [Bindproperty] in het Pagemodel?
        public VehicleModel VehicleModel { get; set; } = new VehicleModel();
    }
}
