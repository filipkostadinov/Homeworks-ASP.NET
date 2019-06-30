using DataAccess;
using Microsoft.EntityFrameworkCore;
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
            return _dbContext.Users
                .Include(x => x.Tasks)
                .ToList();
        }

        public User GetById(int id)
        {
            return _dbContext.Users.Include(x => x.Tasks).FirstOrDefault(u => u.Id == id);
        }

        public void Insert(User entity)
        {
            _dbContext.Users.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(User entity)
        {
            User user = _dbContext.Users.FirstOrDefault(u => u.Id == entity.Id);

            if (user != null)
            {
                user.Id = entity.Id;
                user.FirstName = entity.FirstName;
                user.LastName = entity.LastName;
                user.Age = entity.Age;
                user.AverageFreeTime = entity.AverageFreeTime;
                _dbContext.SaveChanges();

            }
        }
    }
}
