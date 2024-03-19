using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace prelab04.Pages
{
    public class SuccessModel : PageModel
    {
        [BindProperty (SupportsGet =true)]
        public string name{ get; set; }

        public IActionResult OnGet()
        {
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return RedirectToPage("/Login");
            }
            else
            {
                name = HttpContext.Session.GetString("username")!;
                return Page();
            }
        }
    }
}
