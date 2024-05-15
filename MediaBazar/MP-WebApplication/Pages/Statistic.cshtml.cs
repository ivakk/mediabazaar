using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MP_WebApplication.Pages
{
    public class StatisticModel : PageModel
    {
        public void OnGet()
        {
            ViewData["HiredCounts"] = new int[] { 5, 10, 15, 20 }; // Example data
            ViewData["FiredCounts"] = new int[] { 3, 7, 9, 4 };    // Example data
            ViewData["Months"] = new string[] { "January", "February", "March", "April" };
        }
    }
}
