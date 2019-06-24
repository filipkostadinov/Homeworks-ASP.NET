using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.DataAccess.Repositories.CacheRepositories
{
    public class UserRepository : IRepository<User>
    {
        private ToDoTaskDbContext _dbContext;
        public UserRepository(ToDoTaskDbContext context)
        {
            _dbContext = context;
            _dbContext.SaveChanges();
        }
        public void DeleteById(int id)
        {
            User user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();

            }
        }

        public List<User> GetAll()
        {
            var tasks = _dbContext.ToDoTasks.ToList();
            var users = _dbContext.Users.ToList();
            foreach (var user in users)
            {
                user.Tasks = tasks.Where(x => x.UserId == user.Id).ToList();
            }

            return users;
        }

        public User GetById(int id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Insert(User entity)
        {
            //CacheDb.UserId++;
            //entity.Id = CacheDb.UserId;
            _dbContext.Users.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(User entity)
        {
            User user = _dbContext.Users.FirstOrDefault(u => u.Id == entity.Id);

            if (user != null)
            {
                int index = _dbContext.Users.ToList().IndexOf(user);
                _dbContext.Users.ToList()[index] = entity;
                _dbContext.SaveChanges();

            }
        }
    }
}
