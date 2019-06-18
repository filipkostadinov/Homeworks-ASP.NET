using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.DataAccess.Repositories.CacheRepositories
{
    public class ToDoTaskRepository : IRepository<ToDoTask>
    {
        public void DeleteById(int id)
        {
            ToDoTask task = CacheDb.Tasks.FirstOrDefault(t => t.Id == id);
            if (task != null) CacheDb.Tasks.Remove(task);
        }

        public List<ToDoTask> GetAll()
        {
            return CacheDb.Tasks;
        }

        public ToDoTask GetById(int id)
        {
            return CacheDb.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Insert(ToDoTask entity)
        {
            CacheDb.TaskId++;
            entity.Id = CacheDb.TaskId;
            CacheDb.Tasks.Add(entity);
        }

        public void Update(ToDoTask entity)
        {
            ToDoTask task = CacheDb.Tasks.FirstOrDefault(t => t.Id == entity.Id);

            if (task != null)
            {
                int index = CacheDb.Tasks.IndexOf(task);
                CacheDb.Tasks[index] = entity;
            }
        }
    }
}
