using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.InterfacesLL;
using System;
using System.Linq;

public class CheckModel : PageModel
{
    private readonly IUserService _userService;

    public CheckModel(IUserService userService)
    {
        _userService = userService;
    }

    [BindProperty]
    public bool IsCheckedIn { get; set; }

    public void OnGet()
    {
        try
        {
            int userId = int.Parse(User.FindFirst("id").Value);
            var latestStatus = _userService.GetLatestCheckStatus(userId);
            IsCheckedIn = latestStatus ?? false;
        }
        catch (NullReferenceException)
        {
            Response.Redirect("/Login");
            return;
        }
    }

    public IActionResult OnPostCheckIn()
    {
        try
        {
            int userId = int.Parse(User.FindFirst("id").Value);
            _userService.CheckIn(userId);
            IsCheckedIn = true;
            return RedirectToPage();
        }
        catch (NullReferenceException)
        {
            Response.Redirect("/Login");
            return Page();
        }
    }

    public IActionResult OnPostCheckOut()
    {
        try
        {
            int userId = int.Parse(User.FindFirst("id").Value);
            _userService.CheckOut(userId);
            IsCheckedIn = false;
            return RedirectToPage();
        }
        catch (NullReferenceException)
        {
            Response.Redirect("/Login");
            return Page();
        }
    }
}
