using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.InterfacesLL;

namespace MP_WebApplication.Pages
{
    public class StatisticModel : PageModel
    {
        private readonly IUserService userService;
        public StatisticModel(IUserService userService)
        {
            this.userService = userService;
        }

        public void OnGet()
        {
            var hiredStats = userService.GetMonthlyHireStatistics();
            var firedStats = userService.GetMonthlyExEmployeeStatistics();

            ViewData["HiredCounts"] = hiredStats.Values.ToArray();
            ViewData["FiredCounts"] = firedStats.Values.ToArray();
            ViewData["Months"] = hiredStats.Keys.Select(date => date.ToString("MMMM")).ToArray();
        }
    }
}