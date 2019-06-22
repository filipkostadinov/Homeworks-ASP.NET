using System;
using System.Collections.Generic;
using System.Text;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.Services.Services
{
    public interface ISubTaskService
    {
        void CreateNewSubTask(SubTask entity);
    }
}
