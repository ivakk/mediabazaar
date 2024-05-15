using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.InterfacesDal;

namespace MP_BusinessLogic.Services
{
    public class DepartmentService : IDepartmentService
    {
        IDepartmentDalManager controller;

        public DepartmentService(IDepartmentDalManager controller)
        {
            this.controller = controller;
        }

        public List<Department> GetAllDepartments()
        {
            return controller.GetAllDepartments();
        }
        public bool CreateDepartment(Department department)
        {
            return controller.CreateDepartment(department);
        }
        public bool UpdateDepartment(Department department)
        {
            return controller.UpdateDepartment(department);
        }
        public bool DeleteDepartment(int id)
        {
            return controller.DeleteDepartment(id);
        }
        public Department GetDepartmentById(int id)
        {
            return controller.GetDepartmentById(id);
        }
        //public List<Department> GetAllDepartments()
        //{
        //    return controller.GetAllDepartments();
        //}
        //public void CreateDepartment(Department department)
        //{
        //    controller.InsertDepartment(department);
        //}
        //public void UpdateDepartment(Department department)
        //{
        //    controller.UpdateDepartment(department);
        //}
        //public void DeleteDepartment(int id)
        //{
        //    controller.DeleteDepartment(id);
        //}
    }
}
