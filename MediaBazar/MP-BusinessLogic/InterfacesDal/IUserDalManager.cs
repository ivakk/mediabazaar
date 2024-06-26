using MP_BusinessLogic.Entities;
using MP_EntityLibrary;
using System;
using System.Collections.Generic;

namespace MP_BusinessLogic.InterfacesDal
{
    public interface IUserDalManager
    {
        bool InsertUser(User newUser);
        User GetUserByEmail(string email);
        bool IsPasswordCorrect(string email, string password);
        User GetUserById(int id);
        bool UpdateUser(User newUser);
        List<User> GetAllUsers();
        bool DeleteUser(int id);
        List<User> GetUsersByDepartment(int departmentId);
        bool ChangePassword(string email, string newPassword);
        User GetUserByUserName(string userName);
        Dictionary<int, string> GetAllDepartments();
        Dictionary<DateTime, int> GetMonthlyHireStatistics();
        Dictionary<DateTime, int> GetMonthlyExEmployeeStatistics();
        int GetEmployeeCountByDepartment(int departmentId);
        Dictionary<int, int> GetAllDepartmentEmployeeCounts();
        bool InsertCheckRecord(int userId, bool isCheckIn);
        public CheckStatus GetLatestCheckStatus(int userId);

    }
}
