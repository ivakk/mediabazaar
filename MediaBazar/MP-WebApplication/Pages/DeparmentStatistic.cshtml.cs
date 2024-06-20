using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MP_BusinessLogic.InterfacesLL;

namespace MP_WebApplication.Pages
{
    public class DeparmentStatisticModel : PageModel
    {
        private readonly IUserService userService;

        public DeparmentStatisticModel(IUserService userService)
        {
            this.userService = userService;
        }

        [BindProperty]
        public int SelectedDepartmentId { get; set; }
        public Dictionary<int, string> Departments { get; set; }
        public int EmployeeCount { get; set; }
        public Dictionary<int, int> DepartmentEmployeeCounts { get; set; }
        public string[] DepartmentNames { get; set; }
        public int[] EmployeeCounts { get; set; }

        public void OnGet()
        {
            Departments = userService.GetAllDepartments();
            DepartmentEmployeeCounts = userService.GetAllDepartmentEmployeeCounts();
            DepartmentNames = Departments.Values.ToArray();
            EmployeeCounts = Departments.Keys.Select(id => DepartmentEmployeeCounts.ContainsKey(id) ? DepartmentEmployeeCounts[id] : 0).ToArray();
        }

        public void OnPost()
        {
            Departments = userService.GetAllDepartments();
            DepartmentEmployeeCounts = userService.GetAllDepartmentEmployeeCounts();
            EmployeeCount = userService.GetEmployeeCountByDepartment(SelectedDepartmentId);
            DepartmentNames = Departments.Values.ToArray();
            EmployeeCounts = Departments.Keys.Select(id => DepartmentEmployeeCounts.ContainsKey(id) ? DepartmentEmployeeCounts[id] : 0).ToArray();
        }
    }
}
