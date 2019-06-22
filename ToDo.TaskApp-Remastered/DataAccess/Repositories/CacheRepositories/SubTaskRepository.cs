using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.TaskApp.DataAccess;
using ToDo.TaskApp.DataAccess.Repositories;
using ToDo.TaskApp.Domain;

namespace  ToDo.TaskApp.DataAccess.Repositories.CacheRepositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {
        public void DeleteById(int id)
        {
            SubTask subTask = CacheDb.SubTasks.FirstOrDefault(x => x.Id == id);
            if (subTask != null)
            {
                CacheDb.SubTasks.Remove(subTask);                
            }
        }

        public List<SubTask> GetAll()
        {
            return CacheDb.SubTasks;
        }

        public SubTask GetById(int id)
        {
            return CacheDb.SubTasks.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(SubTask entity)
        {
            CacheDb.SubTaskId++;
            entity.Id = CacheDb.SubTaskId;
            CacheDb.SubTasks.Add(entity);
            CacheDb.Tasks.FirstOrDefault(x => x.Id == entity.ToDoTaskId).SubTask.Add(entity);
        }

        public void Update(SubTask entity)
        {
            SubTask subTask = CacheDb.SubTasks.FirstOrDefault(x => x.Id == entity.Id);
            if (subTask != null)
            {
                int index = CacheDb.SubTasks.IndexOf(subTask);
                CacheDb.SubTasks[index] = entity;
            }
        }
    }
}
