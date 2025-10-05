using BYR_WebApp.Models;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Core.Domain;

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
                //Text to show email already exists
                return;
            }
            else
            {
                service.TryRegister(Customer.Email, Customer.FirstName, Customer.LastName, Customer.Password);
                //Text to show registration successful
                return;
            }
        }
    }
}
