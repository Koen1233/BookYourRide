using Azure;
using BYR_WebApp.Helpers.Mappers;
using BYR_WebApp.Models;
using Core.Domain;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BYR_WebApp.Pages.Authentication
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public CustomerModel CustomerModel { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
           
            //Check if passwords match
            if (CustomerModel.Password != CustomerModel.ConfirmPassword)
            {
                ModelState.AddModelError(string.Empty, "Passwords do not match");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
            RegisterService service = new RegisterService();
            if (service.CheckDuplicateEmail(CustomerModel.Email) == true)
            {
                ModelState.AddModelError(string.Empty, "Email is already in use");
                return Page();
            }
           

            service.TryRegister(CustomerModel.Map());//Map gebruikt het CustomerModel en geeft Customer terug voor de Domain laag

            //Redirect to login page
            //Response.Redirect("/Authentication/TryLogin");
            return Redirect("/Authentication/TryLogin");
        }
    }
}
