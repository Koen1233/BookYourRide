using Core.Domain;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BYR_WebApp.Pages.Ride
{
    public class ActionsModel : PageModel
    {
        //Core.Domain.Ride omdat Ride ook deze namespace is
        public IReadOnlyList<Core.Domain.Ride> Rides { get; private set; } = [];

        public IActionResult OnGet()
        {
            var cookievalue = Request.Cookies["key"];
            if (cookievalue != null)
            {
                int.TryParse(cookievalue, out int id);    
                Rides = CustomerService.GetRides(id);
                return Page();
            }      
            return Page(); 
        }

        public void OnPost()
        {
            //moet uiteindelijk weg, en doorverwijzen naar bepaalde pagina
            var cookievalue = Request.Cookies["key"];
            int.TryParse(cookievalue, out int id);
            Rides = CustomerService.GetRides(id);
        }
    }
}
