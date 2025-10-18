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

        public void OnGet()
        {
            //Alle ritten van de ingelogde customer ophalen
            //Voor nu 1 customer uit de database halen, straks via Cookies de ingelogde customer ophalen
            Rides = CustomerService.GetRides(1);
        }

        public void OnPost()
        {
        }
    }
}
