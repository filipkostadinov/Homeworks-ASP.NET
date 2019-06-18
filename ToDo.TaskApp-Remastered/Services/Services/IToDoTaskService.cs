using System;
using System.Collections.Generic;
using System.Text;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.Services.Services
{
    public interface IToDoTaskService
    {
        List<ToDoTask> GetAllTasks();
        List<ToDoTask> GetAllUnfinishedTasks();
        List<ToDoTask> GetAllDoneTasks();
        ToDoTask GetTaskById(int id);
        void MakeNewTask(ToDoTask task);
        ToDoTask GetLastAddedTask();
        int GetNumberOfTasks();
        void UpdateTask(ToDoTask task);
    }
}
