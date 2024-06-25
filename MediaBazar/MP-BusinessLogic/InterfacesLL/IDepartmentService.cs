using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.InterfacesLL
{
    public interface IDepartmentService
    {
        List<Department> GetAllDepartments();
        bool CreateDepartment(Department department);
        bool UpdateDepartment(Department department);
        bool DeleteDepartment(int id);
        Department GetDepartmentById(int id);
        Department GetDepartmentByName(string name);
    }
}
