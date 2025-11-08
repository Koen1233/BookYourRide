using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BYR_WebApp.Models;
using BYR_WebApp.Helpers.Mappers;
using Core.Domain.Helpers.Services;
using Core.Domain.Helpers.Results;

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

            
            try
            {
                LoginResult loginResult = LoginService.TryLogin(LoginModel.Map());

                if (loginResult.Success == true)
                {
                    Response.Cookies.Append("key", loginResult.ID.ToString(), new CookieOptions
                    {
                        Expires = DateTime.Now.AddHours(1)
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
            catch(Exception ex) //for catching faults in the datarepository
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
