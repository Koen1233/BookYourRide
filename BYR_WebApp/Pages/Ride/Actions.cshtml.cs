using Core.Domain;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BYR_WebApp.Pages.Ride
{
    public class ActionsModel : PageModel
    {
        public void OnGet()
        {
            //Alle ritten van de ingelogde customer ophalen
            //Voor nu 1 customer uit de database halen, straks via Cookies de ingelogde customer ophalen

            //Core.Domain.Ride omdat Ride ook deze namespace is
            List<Core.Domain.Ride> rides = CustomerService.GetRides(1);
            
        }

        public void OnPost()
        {
        }
    }
}
