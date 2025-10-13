using Azure;
using BYR_WebApp.Helpers.Mappers;
using BYR_WebApp.Models;
using Core.Domain;
using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;

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
            if (!ModelState.IsValid)//kan het model ooit invalid zijn icm client side validatie in het model?
            {
                return Page();
            }
            if (CustomerModel.Password != CustomerModel.ConfirmPassword)
            {
                ModelState.AddModelError(string.Empty, "Passwords do not match");
            }

            RegisterService service = new RegisterService();
            try
            {
                service.CheckDuplicateEmail(CustomerModel.Email);
                service.TryRegister(CustomerModel.Map()); //.Map gebruikt het CustomerModel en geeft een Core domain Customer terug 
                return Redirect("/Authentication/TryLogin");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
