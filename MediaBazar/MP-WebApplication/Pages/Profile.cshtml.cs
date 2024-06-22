using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_EntityLibrary;
using System.Security.Claims;

namespace MP_WebApplication.Pages
{
    public class ProfileModel : PageModel
    {

        [BindProperty]
        public User NewUser { get; set; }/* = new User();*/
        public User UserLogic { get; set; }
        [BindProperty]
        public DateTime BirthDay { get; set; }

        private readonly IUserService userService;
        //private readonly UserService userService;
        User user;
        public ProfileModel(IUserService userService)
        {
            this.userService = userService;
        }

            public void OnGet()
            {
                try
                {
                    // Retrieve the authenticated user's claims
                    var userClaims = HttpContext.User.Claims;

                    var userEmailClaim = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Name);

                    if (userEmailClaim == null)
                    {

                        RedirectToPage("/Login");

                    }
                    else
                    {
                        UserLogic = userService.GetUserById(int.Parse(User.FindFirst("id").Value));
                        DateTime dateTime = UserLogic.Birthdate;
                        BirthDay = dateTime;
                    }
                }
                catch (NullReferenceException)
                {
                    Response.Redirect("/Account/Login");
                    return;
                }
            }
        public void OnPost()
        {
            try
            {
                UserLogic = userService.GetUserById(int.Parse(User.FindFirst("id").Value));
            }
            catch (NullReferenceException)
            {
                Response.Redirect("/Account/Login");
                return;
            }
            try
            {
                UserLogic.PhoneNumber = NewUser.PhoneNumber;
                userService.UpdateUser(UserLogic);
                Response.Redirect("/Profile");
            }
            catch (Exception ex)
            {
                ViewData["Error"] = "Please input valid data!";
            }
        }

    }
}
