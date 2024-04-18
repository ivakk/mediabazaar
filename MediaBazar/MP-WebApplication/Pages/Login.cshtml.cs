using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using MP_EntityLibrary;
using System.Net.Mail;

namespace MP_WebApplication.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [EmailAddress(ErrorMessage = "Enter a valid email address!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required!")]
        public string? Email { get; set; }

        [BindProperty]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required!")]
        public string? Password { get; set; }

        List<Claim> claims = new List<Claim>();
       
        private readonly UserService userService;
        User user;
        public LoginModel(UserService userService)
        {
            this.userService = userService;
        }

        public void OnGet()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {

                Response.Redirect("/Account");
                return;
            }

        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                ViewData["Error"] = "Please fill in all fields";
                return;
            }

            try
            {
                User user = new User(Email, Password);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email.ToLower()),
                    new Claim("id", user.Id.ToString()),
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(identity));

                Response.Redirect("/Account");
            }
            catch (ArgumentException ex)
            {
                ViewData["Error"] = ex.Message;
            }

        }

    }

    
}
