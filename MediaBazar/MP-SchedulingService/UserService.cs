using Microsoft.TeamFoundation.Test.WebApi;
using MP_SchedulingDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_SchedulingService
{
    public class UserService
    {
        UserController controller = new UserController();
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
    }
}
