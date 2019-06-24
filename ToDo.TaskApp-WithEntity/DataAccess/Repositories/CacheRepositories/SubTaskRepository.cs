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
            _dbContext.SaveChanges();
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
            //CacheDb.SubTaskId++;
            //entity.Id = CacheDb.SubTaskId;
            entity.ToDoTask = _dbContext.ToDoTasks.FirstOrDefault(x => x.Id == entity.ToDoTaskId);
            _dbContext.ToDoTasks.FirstOrDefault(x => x.Id == entity.ToDoTaskId).SubTask.Add(entity);
            _dbContext.SubTasks.Add(entity);
            _dbContext.SaveChanges();

        }

        public void Update(SubTask entity)
        {
            SubTask subTask = _dbContext.SubTasks.FirstOrDefault(x => x.Id == entity.Id);
            if (subTask != null)
            {
                int index = _dbContext.SubTasks.ToList().IndexOf(subTask);
                _dbContext.SubTasks.ToList()[index] = entity;
                _dbContext.SaveChanges();

            }
        }
    }
}
