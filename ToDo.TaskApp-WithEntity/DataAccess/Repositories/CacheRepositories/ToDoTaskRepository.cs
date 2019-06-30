using DataAccess;
using Microsoft.EntityFrameworkCore;
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
            return _dbContext.ToDoTasks
                .Include(x => x.SubTask)
                .ToList();
        }

        public ToDoTask GetById(int id)
        {
            return _dbContext.ToDoTasks
                .Include(x => x.SubTask)
                .FirstOrDefault(t => t.Id == id);
        }

        public void Insert(ToDoTask entity)
        {
            _dbContext.ToDoTasks.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(ToDoTask entity)
        {
            ToDoTask task = _dbContext.ToDoTasks.FirstOrDefault(t => t.Id == entity.Id);

            if (task != null)
            {
                task.Id = entity.Id;
                task.Title = entity.Title;
                task.Description = entity.Description;
                task.Priority = entity.Priority;
                task.Status = entity.Status;
                task.TypeOfTask = entity.TypeOfTask;
                task.UserId = entity.UserId;

                _dbContext.Update(task);
                _dbContext.SaveChanges();
            }
        }
    }
}
