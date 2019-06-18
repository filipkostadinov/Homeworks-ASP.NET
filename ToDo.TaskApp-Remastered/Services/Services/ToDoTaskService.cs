using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.TaskApp.DataAccess.Repositories;
using ToDo.TaskApp.DataAccess.Repositories.CacheRepositories;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.Services.Services
{
    public class ToDoTaskService : IToDoTaskService
    {
        private IRepository<ToDoTask> _toDoRepository;
        public ToDoTaskService()
        {
            _toDoRepository = new ToDoTaskRepository();
        }

        public void UpdateTask(ToDoTask task)
        {
            _toDoRepository.Update(task);
        }

        public List<ToDoTask> GetAllDoneTasks()
        {
            return _toDoRepository.GetAll().Where(x => x.Status == Status.Done).ToList();
        }

        public List<ToDoTask> GetAllTasks()
        {
            return _toDoRepository.GetAll();
        }

        public List<ToDoTask> GetAllUnfinishedTasks()
        {
            return _toDoRepository.GetAll().Where(x => x.Status != Status.Done).ToList();
        }

        public ToDoTask GetLastAddedTask()
        {
            return _toDoRepository.GetAll().LastOrDefault();
        }

        public int GetNumberOfTasks()
        {
            return _toDoRepository.GetAll().Count();
        }

        public ToDoTask GetTaskById(int id)
        {
            return _toDoRepository.GetById(id);
        }

        public void MakeNewTask(ToDoTask task)
        {
            _toDoRepository.Insert(task);
        }
    }
}
