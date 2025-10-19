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
                Response.Cookies.Append("key", loginResult.ID.ToString(), new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(15)
                });
                return Redirect("/Ride/Actions");
                
                //Employee naar een andere pagina redirecten of andere info/buttons laten zien?
            }
            else
            {
                ModelState.AddModelError(string.Empty, loginResult.ErrorMessage);
                return Page();
            }
        }
    }
}
