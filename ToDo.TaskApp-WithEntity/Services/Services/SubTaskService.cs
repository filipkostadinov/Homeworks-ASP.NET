using System;
using System.Collections.Generic;
using System.Text;
using ToDo.TaskApp.DataAccess.Repositories;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.Services.Services
{
    public class SubTaskService : ISubTaskService
    {
        private IRepository<SubTask> _subTaskRepo;
        public SubTaskService(IRepository<SubTask> subTaskRepo)
        {
            _subTaskRepo = subTaskRepo;
        }
        public void CreateNewSubTask(SubTask entity)
        {
            _subTaskRepo.Insert(entity);
        }

        public List<SubTask> GetAllSubTasks()
        {
            return _subTaskRepo.GetAll();
        }
    }
}
