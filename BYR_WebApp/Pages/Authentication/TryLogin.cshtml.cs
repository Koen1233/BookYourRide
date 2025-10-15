using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Core.Domain.Services;
using Core.Domain.Results;
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

            LoginResult loginResult = LoginService.TryLogin(LoginModel.Map());
            if (loginResult.Success == true)
            {
                return Redirect("/Ride/Actions");
                //Employee naar een andere pagina redirecten?
                //Cookies toewijzen voor ingelogde gebruiker
            }
            else
            {
                ModelState.AddModelError(string.Empty, loginResult.ErrorMessage);
                return Page();
            }
        }
    }
}
