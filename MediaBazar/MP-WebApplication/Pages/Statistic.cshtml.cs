using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.InterfacesLL;
using System.Globalization;
using System.IO;

namespace MP_WebApplication.Pages
{
    [Authorize(Roles = "admin,manager")]
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

            var allMonths = hiredStats.Keys.Union(firedStats.Keys).OrderBy(date => date).ToList();
            var hiredCounts = new Dictionary<DateTime, int>();
            var firedCounts = new Dictionary<DateTime, int>();

            foreach (var month in allMonths)
            {
                hiredCounts[month] = hiredStats.ContainsKey(month) ? hiredStats[month] : 0;
                firedCounts[month] = firedStats.ContainsKey(month) ? firedStats[month] : 0;
            }

            ViewData["HiredCounts"] = hiredCounts.Values.ToArray();
            ViewData["FiredCounts"] = firedCounts.Values.ToArray();
            ViewData["Months"] = hiredCounts.Keys.Select(date => date.ToString("MMMM yyyy", CultureInfo.InvariantCulture)).ToArray();
        }

        public IActionResult OnPostExportToPdf()
        {
            var hiredStats = userService.GetMonthlyHireStatistics();
            var firedStats = userService.GetMonthlyExEmployeeStatistics();

            var allMonths = hiredStats.Keys.Union(firedStats.Keys).OrderBy(date => date).ToList();
            var hiredCounts = new Dictionary<DateTime, int>();
            var firedCounts = new Dictionary<DateTime, int>();

            foreach (var month in allMonths)
            {
                hiredCounts[month] = hiredStats.ContainsKey(month) ? hiredStats[month] : 0;
                firedCounts[month] = firedStats.ContainsKey(month) ? firedStats[month] : 0;
            }

            // Create a PDF document
            MemoryStream stream = new MemoryStream();
            PdfWriter writer = new PdfWriter(stream);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            document.Add(new Paragraph("Monthly Hire and Fire Statistics").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
            Table table = new Table(3);
            table.AddCell("Month");
            table.AddCell("Hired");
            table.AddCell("Fired");

            foreach (var month in allMonths)
            {
                table.AddCell(month.ToString("MMMM yyyy", CultureInfo.InvariantCulture));
                table.AddCell(hiredCounts[month].ToString());
                table.AddCell(firedCounts[month].ToString());
            }

            document.Add(table);
            document.Close();

            stream.Position = 0;
            return File(stream, "application/pdf", "Statistics.pdf");
        }
    }
}
