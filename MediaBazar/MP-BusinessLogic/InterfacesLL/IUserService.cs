using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.InterfacesLL
{
    public interface IUserService
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
    }
}
