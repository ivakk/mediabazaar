using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.Services;
using MP_DataAccess;
using MP_EntityLibrary;
using System.ComponentModel.DataAnnotations;

namespace MP_WebApplication.Pages
{
    [Authorize]
    public class AccountModel : PageModel
    {
        UserService userService = new UserService();
       
        User ? UserLogic;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Current Password is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        [BindProperty]
        public string? CurrentPassword { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        [BindProperty]
        public string? NewPassword { get; set; }

        
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [BindProperty]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required!")]
        [Compare(nameof(NewPassword), ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

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

            ViewData["FirstName"] = UserLogic.FirstName;
            ViewData["Email"] = UserLogic.Email;
        }

        public void OnPost()
        {
            try
            {
                UserLogic = userService.GetUserById(int.Parse(User.FindFirst("id").Value));

                

                try
                {
                    new User(UserLogic.Email, CurrentPassword);

                    PasswordHashing passwordHasher = new PasswordHashing();

                    string newSalt = passwordHasher.GenerateRandomSalt(16);
                    string newHash = passwordHasher.GenerateSHA256Hash(NewPassword, newSalt);

                    UserService usersManager = new UserService();
                    User newUser = usersManager.GetUserById(UserLogic.Id);
                    newUser.PasswordHash = newHash;
                    newUser.PasswordSalt = newSalt;

                    usersManager.UpdateUser(newUser);

                    ViewData["Success"] = "Password changed successfully";
                }
                catch (ArgumentException ex)
                {
                    ViewData["Error"] = "Current password is incorrect";
                }
            }
            catch (NullReferenceException)
            {
                Response.Redirect("/Login");
                return;
            }
        }


    }
}
