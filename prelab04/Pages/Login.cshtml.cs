using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using prelab04;
using System.Xml.Linq;

namespace prelab04.Pages
{
    public class LoginModel : PageModel
    {

        public LoginModel()
        {
            
        }



        [BindProperty]
        public User ahmed { get; set; } = new User();

        public string username{ get; set; }


        public IActionResult OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return Page();
            }
            else
            {

                username = HttpContext.Session.GetString("username")!;
                return RedirectToPage("/Login");
            }
        }


        public IActionResult OnPost()
        {
            HttpContext.Session.SetString("username", ahmed.Fname);

            if(ModelState.IsValid) 
            {
                return RedirectToPage("/Success", new { name = ahmed.Fname });
            }
            else
            {
                return Page();
            }
            
        }

    }
}
