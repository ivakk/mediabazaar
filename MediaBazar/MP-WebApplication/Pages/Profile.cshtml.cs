using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_EntityLibrary;
using System.Security.Claims;

namespace MP_WebApplication.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string PhoneNumber { get; set; }
        public User UserLogic { get; set; }
        [BindProperty]
        public DateTime BirthDay { get; set; }

        private readonly IUserService userService;

        public ProfileModel(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult OnGet()
        {
            try
            {
                var userClaims = HttpContext.User.Claims;
                var userEmailClaim = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Name);

                if (userEmailClaim == null)
                {
                    return RedirectToPage("/Login");
                }

                UserLogic = userService.GetUserById(int.Parse(User.FindFirst("id").Value));

                if (UserLogic == null)
                {
                    return RedirectToPage("/Login");
                }

                FirstName = UserLogic.FirstName;
                LastName = UserLogic.LastName;
                Email = UserLogic.Email;
                PhoneNumber = UserLogic.PhoneNumber;
                BirthDay = UserLogic.Birthdate;

                return Page();
            }
            catch (Exception)
            {
                return RedirectToPage("/Account/Login");
            }
        }

        public IActionResult OnPostEdit()
        {
            try
            {
                UserLogic = userService.GetUserById(int.Parse(User.FindFirst("id").Value));
                if (UserLogic == null)
                {
                    return RedirectToPage("/Login");
                }

                if (!string.IsNullOrEmpty(FirstName) && FirstName != UserLogic.FirstName)
                {
                    UserLogic.FirstName = FirstName;
                }
                if (!string.IsNullOrEmpty(LastName) && LastName != UserLogic.LastName)
                {
                    UserLogic.LastName = LastName;
                }
                if (!string.IsNullOrEmpty(Email) && Email != UserLogic.Email)
                {
                    UserLogic.Email = Email;
                }
                if (!string.IsNullOrEmpty(PhoneNumber) && PhoneNumber != UserLogic.PhoneNumber)
                {
                    UserLogic.PhoneNumber = PhoneNumber;
                }

                userService.UpdateUser(UserLogic);
                return RedirectToPage("/Profile");
            }
            catch (Exception)
            {
                ViewData["Error"] = "Please input valid data!";
                return Page();
            }
        }
    }
}
