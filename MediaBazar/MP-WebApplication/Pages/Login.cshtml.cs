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
using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;

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

        private readonly IUserService userService;
        User user;
        public LoginModel(IUserService userService)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["Error"] = "Please fill in all fields";
                return Page();
            }

            try
            {
                User user = userService.GetUserByEmail(Email);
                bool isPasswordCorrect = userService.IsPasswordCorrect(Email, Password);

                if (!isPasswordCorrect)
                {
                    ViewData["Error"] = "Invalid email or password";
                    return Page();
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email.ToLower()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Position),
                    new Claim("id", user.Id.ToString()),
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(new ClaimsPrincipal(identity));

                if (user.Position == "admin" || user.Position == "manager")
                {
                    return RedirectToPage("/Statistic");
                }
                else
                {
                    return RedirectToPage("/Account");
                }
            }
            catch (ArgumentException ex)
            {
                ViewData["Error"] = ex.Message;
                return Page();
            }
        }
    }
}
