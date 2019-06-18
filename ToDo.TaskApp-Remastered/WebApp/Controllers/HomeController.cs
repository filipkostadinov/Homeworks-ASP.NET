using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.TaskApp.Domain;
using ToDo.TaskApp.Services.Services;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IToDoTaskService _toDoTaskService;

        public HomeController(IToDoTaskService toDoTaskService)
        {
            _toDoTaskService = toDoTaskService;
        }

        public IActionResult Index()
        {
            var allUnfinishedTasks = _toDoTaskService.GetAllUnfinishedTasks();
            return View(MappingToViewModels(allUnfinishedTasks));
        }
        [HttpGet("NotDone")]
        public IActionResult NotDone()
        {
            var notDoneTasks = _toDoTaskService.GetAllUnfinishedTasks().Where(x => x.Status == Status.NotDone).ToList();
            return View(MappingToViewModels(notDoneTasks));
        }
        [HttpGet("InProgress")]
        public IActionResult Progress()
        {
            var inProgressTasks = _toDoTaskService.GetAllUnfinishedTasks().Where(x => x.Status == Status.InProgress).ToList();

            return View(MappingToViewModels(inProgressTasks));
        }
        [HttpGet("AllDoneTasks")]
        public IActionResult AllDoneTasks()
        {
            var finishedTasks = _toDoTaskService.GetAllDoneTasks();

            return View(MappingToViewModels(finishedTasks));
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            TaskViewModel model = new TaskViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddTask(TaskViewModel model)
        {
            ToDoTask task = new ToDoTask()
            {
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = Status.NotDone,
                TypeOfTask = model.TypeOfTask
            };

            _toDoTaskService.MakeNewTask(task);

            return View("_SuccessfulCreatedTask");
        }        

        public static List<TaskViewModel> MappingToViewModels(List<ToDoTask> tasks)
        {
            List<TaskViewModel> viewModelTasks = new List<TaskViewModel>();
            foreach (var task in tasks)
            {
                viewModelTasks.Add(
                    new TaskViewModel()
                    {
                        Title = task.Title,
                        Description = task.Description,
                        Priority = task.Priority,
                        Status = task.Status,
                        TypeOfTask = task.TypeOfTask,
                        SubTask = task.SubTask.Select(s => new { SubTask = $"{s.Title} - {s.Description} - {s.Status}" }).Select(x => x.SubTask)
                    });
            }

            return viewModelTasks;
        }
    }
}
