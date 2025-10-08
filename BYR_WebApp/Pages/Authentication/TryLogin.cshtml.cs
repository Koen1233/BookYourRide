using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Core.Domain.Services;
using BYR_WebApp.Models;
using BYR_WebApp.Helpers.Mappers;

namespace BYR_WebApp.Pages.Authentication
{
    public class TryLoginModel : PageModel
    {
        [BindProperty]
        public LoginModel LoginModel { get; set; } = new();

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            LoginService service = new LoginService();
            if(service.TryLogin(LoginModel.Map()) == true)
            {
                //Employee naar een andere pagina redirecten, of obv cookies bepalen wat er te zien is?
                return Redirect("/Ride/Actions");
            }
            else //if login failed
            {
                ModelState.AddModelError(string.Empty, "Email or Password is incorrect.");
                return Page();
            }
            
        }
    }
}
