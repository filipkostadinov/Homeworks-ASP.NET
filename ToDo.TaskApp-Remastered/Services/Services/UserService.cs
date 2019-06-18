using System;
using System.Collections.Generic;
using System.Text;
using ToDo.TaskApp.DataAccess.Repositories;
using ToDo.TaskApp.DataAccess.Repositories.CacheRepositories;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void CreateNewUser(User user)
        {
            _userRepository.Insert(user);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
    }
}
