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
        private ISubTaskService _subTaskService;

        public HomeController(IToDoTaskService toDoTaskService, ISubTaskService subTaskService)
        {
            _toDoTaskService = toDoTaskService;
            _subTaskService = subTaskService;
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
        public IActionResult AddSubTask(int? id)
        {
            SubTaskViewModel model = new SubTaskViewModel() { ToDoTaskId = id.Value};
            return View(model);
        }
        [HttpPost]
        public IActionResult AddSubTask(SubTaskViewModel model)
        {
            SubTask subTask = new SubTask()
            {
                Title = model.Title,
                Description = model.Description,
                Status = Status.NotDone,
                ToDoTaskId = model.ToDoTaskId
            };
            _subTaskService.CreateNewSubTask(subTask);

            return View("_AddedNewSubTask");
        }
        public IActionResult Details(int? id)
        {
            ToDoTask task = _toDoTaskService.GetAllTasks().SingleOrDefault(x => x.Id == id);
            List<SubTaskViewModel> subTasksModel = new List<SubTaskViewModel>();

            foreach (var subTask in task.SubTask)
            {
                subTasksModel.Add(new SubTaskViewModel()
                {
                    Id = subTask.Id,
                    Title = subTask.Title,
                    Description = subTask.Description,
                    Status = subTask.Status,
                    ToDoTaskId = subTask.ToDoTaskId
                });
            }

            TaskViewModel model = new TaskViewModel()
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                Priority = task.Priority,
                Status = task.Status,
                TypeOfTask = task.TypeOfTask,
                SubTask = subTasksModel
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Details(TaskViewModel model)
        {
            List<SubTask> subTasks = _toDoTaskService.GetTaskById(model.Id).SubTask;
            
            ToDoTask task = new ToDoTask()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = model.Status,
                TypeOfTask = model.TypeOfTask,
                SubTask = subTasks
            };
            _toDoTaskService.UpdateTask(task);

            return RedirectToAction("Index");
        }


            public static List<TaskViewModel> MappingToViewModels(List<ToDoTask> tasks)
        {
            List<TaskViewModel> viewModelTasks = new List<TaskViewModel>();
            foreach (var task in tasks)
            {
                List<SubTaskViewModel> subTasks = new List<SubTaskViewModel>();
                foreach (var subTask in task.SubTask)
                {
                    subTasks.Add(new SubTaskViewModel()
                    {
                        Id = subTask.Id,
                        Title = subTask.Title,
                        Description = subTask.Description,
                        Status = subTask.Status,
                        ToDoTaskId = subTask.ToDoTaskId
                    });
                }

                viewModelTasks.Add(
                    new TaskViewModel()
                    {
                        Id = task.Id,
                        Title = task.Title,
                        Description = task.Description,
                        Priority = task.Priority,
                        Status = task.Status,
                        TypeOfTask = task.TypeOfTask,
                        SubTask = subTasks
                    });
            }

            return viewModelTasks;
        }
    }
}
