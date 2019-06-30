using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.TaskApp.DataAccess;
using ToDo.TaskApp.DataAccess.Repositories;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.DataAccess.Repositories.CacheRepositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {
        private ToDoTaskDbContext _dbContext;
        public SubTaskRepository(ToDoTaskDbContext context)
        {
            _dbContext = context;
        }
        public void DeleteById(int id)
        {
            SubTask subTask = _dbContext.SubTasks.FirstOrDefault(x => x.Id == id);
            if (subTask != null)
            {
                _dbContext.SubTasks.Remove(subTask);
                _dbContext.SaveChanges();
            }
        }

        public List<SubTask> GetAll()
        {
            return _dbContext.SubTasks.ToList();
        }

        public SubTask GetById(int id)
        {
            return _dbContext.SubTasks.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(SubTask entity)
        {
            _dbContext.SubTasks.Add(entity);
            _dbContext.SaveChanges();

        }

        public void Update(SubTask entity)
        {
            SubTask subTask = _dbContext.SubTasks.FirstOrDefault(x => x.Id == entity.Id);
            if (subTask != null)
            {
                subTask.Id = entity.Id;
                subTask.Title = entity.Title;
                subTask.Description = entity.Description;
                subTask.Status = entity.Status;
                subTask.ToDoTaskId = entity.ToDoTaskId;

                _dbContext.Update(subTask);
                _dbContext.SaveChanges();
            }
        }
    }
}
