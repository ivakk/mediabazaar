using Microsoft.TeamFoundation.Test.WebApi;
using MP_DataAccess;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_BusinessLogic.Services
{
    public class UserService
    {
        UserDALManager controller = new UserDALManager();
        public List<User> GetAllUsers()
        {
            return controller.GetAll();
        }

        public User GetUserById(int id)
        {
            return controller.GetUserById(id);
        }
        
        public bool CreateUser(User user)
        {
            return controller.InsertUser(user);
        }

        public List<User> GetUsersByDepartment(int departmentId)
        {
            return controller.GetUserByDepartment(departmentId);
        }

        public List<User> GetBySearch(string search)
        {
            List<User> result = new List<User>();
            foreach (User User in GetAllUsers())
            {
                if (User.GetObjectString().Contains(search))
                {
                    result.Add(User);
                }
            }
            return result;
        }
        public bool UpdateUser(User user)
        {
            return controller.UpdateUser(user);
        }
        public void DeleteUser(int id)
        {
            controller.DeleteUser(id);
        }

        public User GetUserByEmail(string email)
        {
            return controller.GetUserByEmail(email);
        }
        public bool IsPasswordCorrect(string email,string password)
        {
           return controller.IsPasswordCorrect(email, password);
        }
    }
}
