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
            //Ophalen emails??
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }


            //Implement login service
            LoginService service = new LoginService();
            //if(service.TryLogin(Login.Email, Login.Password) == true)
            if(service.TryLogin(LoginModel.Map()) == true)
            {
                Response.Redirect("/Ride/Actions");
            }
            else
            {
                //Show errormessage in display
                return;
            }
            
        }
    }
}
