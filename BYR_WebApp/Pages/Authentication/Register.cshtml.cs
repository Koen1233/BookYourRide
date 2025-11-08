using Azure;
using BYR_WebApp.Helpers.Mappers;
using BYR_WebApp.Models;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;
using Core.Domain.Helpers.Services;
using Core.Domain.Helpers.Results;

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
                return Page();
            }

            try
            {
                RegisterResult registerResult = RegisterService.TryRegister(CustomerModel.Map()); //.Map gebruikt het CustomerModel en geeft een Core domain Customer terug 
                if (registerResult.Success == false)
                {
                    ModelState.AddModelError(string.Empty, registerResult.ErrorMessage);
                    return Page();
                }
                else
                {
                    return Redirect("/Authentication/TryLogin");
                }
            }
            catch(Exception ex) 
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return Page();
            }
        }
    }
}
