using MP_SchedulingDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_SchedulingService
{
    public class DepartmentService
    {
        DepartmentController controller = new DepartmentController();
        public List<Department> GetAllDepartments()
        {
            return controller.GetAllDepartments();
        }
        public void CreateDepartment(Department department)
        {
            controller.InsertDepartment(department);
        }
        public void UpdateDepartment(Department department)
        {
            controller.UpdateDepartment(department);
        }
        public void DeleteDepartment(int id)
        {
            controller.DeleteDepartment(id);
        }
    }
}
