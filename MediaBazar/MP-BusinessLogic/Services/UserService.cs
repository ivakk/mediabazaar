using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Services
{
    public class UserService: IUserService

    {
        IUserDalManager controller;

        public UserService(IUserDalManager controller)
        {
            this.controller = controller;
        }

        public bool IsPasswordCorrect(string email, string password)
        {
            return controller.IsPasswordCorrect(email, password);
        }
        public User GetUserByEmail(string email)
        {
            return controller.GetUserByEmail(email);
        }
        public bool InsertUser(User newUser)
        {
            return controller.InsertUser(newUser);
        }
        public User GetUserById(int id)
        {
            return controller.GetUserById(id);
        }

        public bool UpdateUser(User newUser)
        {
            return controller.UpdateUser(newUser);
        }
        public List<User> GetAllUsers()
        {
            return controller.GetAllUsers();
        }
        public bool DeleteUser(int id)
        {
            return controller.DeleteUser(id);
        }

        public List<User> GetUsersByDepartment(int departmentId)
        {
            return controller.GetUsersByDepartment(departmentId);
        }

        public bool ChangePassword(string email, string newPassword) 
        { return controller.ChangePassword(email, newPassword); }


        public User GetUserByUserName(string userName)
        {
            return controller.GetUserByUserName(userName);
        }

        public Dictionary<DateTime, int> GetMonthlyExEmployeeStatistics()
        {
            return controller.GetMonthlyExEmployeeStatistics();
        }
        public Dictionary<DateTime, int> GetMonthlyHireStatistics()
        {
            return controller.GetMonthlyHireStatistics();
        }
        public Dictionary<int, string> GetAllDepartments() { return controller.GetAllDepartments(); }

        public int GetEmployeeCountByDepartment(int departmentId) { return controller.GetEmployeeCountByDepartment(departmentId); }

        public Dictionary<int, int> GetAllDepartmentEmployeeCounts() { return controller.GetAllDepartmentEmployeeCounts(); }
    }
}
