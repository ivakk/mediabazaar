using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.Services;
using MP_EntityLibrary;

namespace MP_WebApplication.Pages
{
    public class ProfileModel : PageModel
    {
        UserService userService = new UserService();
        [BindProperty]
        public User NewUser { get; set; } = new User();
        public User UserLogic { get; set; }
        public void OnGet()
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
