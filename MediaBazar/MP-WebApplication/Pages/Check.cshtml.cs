using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.Entities;
using MP_BusinessLogic.InterfacesLL;
using System;

public class CheckModel : PageModel
{
    private readonly IUserService _userService;

    public CheckModel(IUserService userService)
    {
        _userService = userService;
    }

    [BindProperty]
    public CheckStatus CheckStatus { get; set; }

    public void OnGet()
    {
        try
        {
            int userId = int.Parse(User.FindFirst("id").Value);
            CheckStatus = _userService.GetLatestCheckStatus(userId);
            if (CheckStatus == null)
            {
                CheckStatus = new CheckStatus { IsCheckedIn = false, CheckTime = null };
            }
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
            CheckStatus = new CheckStatus { IsCheckedIn = true, CheckTime = DateTime.Now };
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
            CheckStatus = new CheckStatus { IsCheckedIn = false, CheckTime = DateTime.Now };
            return RedirectToPage();
        }
        catch (NullReferenceException)
        {
            Response.Redirect("/Login");
            return Page();
        }
    }
}
