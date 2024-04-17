using MP_EntityLibrary;
using MP_DataAccess.DALManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Services
{
    public class DepartmentService
    {
        DepartmentDALManager controller = new DepartmentDALManager();
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
