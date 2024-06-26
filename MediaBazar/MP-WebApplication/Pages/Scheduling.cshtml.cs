using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_SchedulingDAL;
using MP_SchedulingService;

namespace MP_WebApplication.Pages
{
    public class SchedulingModel : PageModel
    {
        private readonly ILogger<SchedulingModel> _logger;
        UserController UserController = new UserController();
        ShiftController shiftController = new ShiftController();

        User? UserLogic;

        public List<Shift> Shifts { get; set; }

        [BindProperty]
        public Shift NewShift { get; set; }

        public SchedulingModel(ILogger<SchedulingModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                UserLogic = UserController.GetUserById(int.Parse(User.FindFirst("id").Value));
            }
            catch (NullReferenceException)
            {
                Response.Redirect("/Account/Login");
                return;
            }

            ShiftController shiftsManager = new ShiftController();
            Shifts = shiftsManager.GetAllShiftsOfUser(UserLogic.Id);

            ViewData["FirstName"] = UserLogic.FirstName;
            
        }

        public void OnPost()
        {
            try
            {
                UserLogic = UserController.GetUserById(int.Parse(User.FindFirst("id").Value));
            }
            catch (NullReferenceException)
            {
                Response.Redirect("/Account/Login");
                return;
            }

            UserLogic = UserController.GetUserById(int.Parse(User.FindFirst("id").Value));
            NewShift.User = UserLogic;
            NewShift.State = 0;
            if (NewShift.Description == null || NewShift.Type == "Availability")
                NewShift.Description = "";

            if (NewShift.StartTime > DateTime.Now)
            {
                TimeSpan duration = NewShift.EndTime - NewShift.StartTime;
                for (int i = 0; i < duration.TotalHours/4; i++)
                {
                    Shift temp = NewShift;
                    temp.StartTime = new DateTime(NewShift.StartTime.Year, NewShift.StartTime.Month, NewShift.StartTime.Day,
                        NewShift.StartTime.Hour + 4 * i, 0,0);
                    temp.EndTime = new DateTime(NewShift.StartTime.Year, NewShift.StartTime.Month, NewShift.StartTime.Day,
                        temp.StartTime.Hour + 4, 0, 0);
                    shiftController.CreateShift(NewShift);
                }

                Response.Redirect("/");
            }
            else
            {
                ShiftController shiftsManager = new ShiftController();
                Shifts = shiftsManager.GetAllShiftsOfUser(UserLogic.Id);

                ViewData["FirstName"] = UserLogic.FirstName;
                ViewData["Error"] = "Cannot schedule something in the past! Try again.";
            }
                
        }
    }
}