using Core.Domain;
using System.ComponentModel.DataAnnotations;

namespace BYR_WebApp.Models
{
    public class VehicleModel
    {
        public int Mileage { get;  set; } // int ranging from 0 to 100 (100%)
        public int WriteOff { get;  set; } //KM
        public int MaxLoad { get;  set; }//Kilo's
        public int PassengerSeats { get;  set; }
        public bool Status { get;  set; }

        [Required(ErrorMessage = "Please select the type of transport")]
        [Display(Name = "Type of Transport")]
        public VehicleType Type { get; set; }
    }
}
