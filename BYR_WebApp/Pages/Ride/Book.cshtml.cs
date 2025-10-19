using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BYR_WebApp.Pages.Ride
{
    public class BookModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var cookievalue = Request.Cookies["key"];
            return Redirect("/Ride/Actions");
        }
    }
}
