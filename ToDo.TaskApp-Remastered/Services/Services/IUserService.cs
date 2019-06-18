using System;
using System.Collections.Generic;
using System.Text;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.Services.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetUserById(int id);
        void UpdateUser(User user);
        void CreateNewUser(User user);
    }
}
