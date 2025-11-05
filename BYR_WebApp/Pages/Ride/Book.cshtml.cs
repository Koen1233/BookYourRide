using BYR_WebApp.Models;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BYR_WebApp.Pages.Ride
{
    public class BookModel : PageModel
    {
        [BindProperty]
        public RideModel RideModel { get; set; } = new();

        //Nog een model toevoegen of binnen het RideModel toevoegen?
        [BindProperty]
        public VehicleModel VehicleModel { get; set; } = new();

        public List<VehicleType> vehicleTypes { get; set; } = new List<VehicleType>();

        public void OnGet()
        {
            vehicleTypes.Add(VehicleType.Taxi);
            vehicleTypes.Add(VehicleType.Truck);
        }

        public IActionResult OnPost()
        {
            //var cookievalue = Request.Cookies["key"];
            //return Redirect("/Ride/Actions");
            return Page();
        }
    }
}
