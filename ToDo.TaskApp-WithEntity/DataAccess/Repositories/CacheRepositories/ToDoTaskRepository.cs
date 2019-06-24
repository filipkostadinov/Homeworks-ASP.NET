using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.DataAccess.Repositories.CacheRepositories
{
    public class ToDoTaskRepository : IRepository<ToDoTask>
    {
        private ToDoTaskDbContext _dbContext;
        public ToDoTaskRepository(ToDoTaskDbContext context)
        {
            _dbContext = context;
            _dbContext.SaveChanges();
        }
        public void DeleteById(int id)
        {
            ToDoTask task = _dbContext.ToDoTasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _dbContext.ToDoTasks.Remove(task);
                _dbContext.SaveChanges();

            }
        }

        public List<ToDoTask> GetAll()
        {
            var subTasks = _dbContext.SubTasks.ToList();
            var tasks = _dbContext.ToDoTasks.ToList();
            foreach (var task in tasks)
            {
                task.SubTask = subTasks.Where(x => x.ToDoTaskId == task.Id).ToList();
            }
            
            return tasks;
        }

        public ToDoTask GetById(int id)
        {
            return _dbContext.ToDoTasks.FirstOrDefault(t => t.Id == id);
        }

        public void Insert(ToDoTask entity)
        {
            entity.User = _dbContext.Users.FirstOrDefault(x => x.Id == entity.UserId);
            //CacheDb.TaskId++;
            //entity.Id = CacheDb.TaskId;
            _dbContext.ToDoTasks.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(ToDoTask entity)
        {
            ToDoTask task = _dbContext.ToDoTasks.FirstOrDefault(t => t.Id == entity.Id);

            if (task != null)
            {
                int index = _dbContext.ToDoTasks.ToList().IndexOf(task);
                _dbContext.ToDoTasks.ToList()[index] = entity;
                _dbContext.SaveChanges();
            }
        }
    }
}
