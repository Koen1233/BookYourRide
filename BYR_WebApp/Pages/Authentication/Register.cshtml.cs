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
        public CustomerModel Customer { get; set; } = new();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            //Check if passwords match
            if (Customer.Password != Customer.ConfirmPassword)
            {
                //Text to show emails do not match
                return;
            }

            RegisterService service = new RegisterService();
            if (service.CheckDuplicateEmail(Customer.Email) == true)
            {
                //Show error message for duplicate emails
                return;
            }
            else
            {
                service.TryRegister(Customer.Map());//Map gebruikt het CustomerModel en geeft Customer terug coor de Domain laag
                
                //Redirect to login page
                Response.Redirect("/Authentication/TryLogin");
            }
        }
    }
}
