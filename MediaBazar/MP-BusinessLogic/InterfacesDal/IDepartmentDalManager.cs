using MP_EntityLibrary;
using System.Collections.Generic;

namespace MP_BusinessLogic.InterfacesDal
{
    public interface IDepartmentDalManager
    {
        List<Department> GetAllDepartments();
        bool CreateDepartment(Department department);
        bool UpdateDepartment(Department department);
        bool DeleteDepartment(int id);
        Department GetDepartmentById(int id);
        Department GetDepartmentByName(string name);
    }
}
