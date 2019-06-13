using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models.DomainModels;
using ToDo.Models.Enums;
using ToDo.Models.ViewModels;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        public List<TaskViewModel> Tasks = new List<TaskViewModel>();

        public HomeController()
        { 
            foreach (var task in Db.Tasks)
            {
                Tasks.Add(
                    new TaskViewModel()
                    {
                        Title = task.Title,
                        Description = task.Description,
                        Priority = task.Priority,
                        Status = task.Status,
                        TypeOfTask = task.TypeOfTask,
                        SubTask = task.SubTask.Select(s => new { SubTask = $"{s.Title} - {s.Description} - {s.Status}"}).Select(x => x.SubTask)
                    });
            }

        }

        public IActionResult Index()
        {
            IEnumerable<TaskViewModel> allNotDoneTasks = new List<TaskViewModel>();
            allNotDoneTasks = Tasks.Where(t => t.Status != Status.Done);
            return View(allNotDoneTasks);
        }
        [HttpGet("NotDone")]
        public IActionResult NotDone()
        {
            IEnumerable<TaskViewModel> notDoneTasks = new List<TaskViewModel>();
            notDoneTasks = Tasks.Where(t => t.Status == Status.NotDone);
            return View(notDoneTasks);
        }
        [HttpGet("InProgress")]
        public IActionResult Progress()
        {
            IEnumerable<TaskViewModel> inProgressTasks = new List<TaskViewModel>();
            inProgressTasks = Tasks.Where(t => t.Status == Status.InProgress);
            return View(inProgressTasks);
        }
        [HttpGet("AllDoneTasks")]
        public IActionResult AllDoneTasks()
        {
            IEnumerable<TaskViewModel> finishedTasks = new List<TaskViewModel>();
            finishedTasks = Tasks.Where(t => t.Status == Status.Done);
            return View(finishedTasks);
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
            Db.TaskId++;
            ToDoTask task = new ToDoTask()
            {
                Id = Db.TaskId,
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = Status.NotDone,
                TypeOfTask = model.TypeOfTask
            };
            Db.Tasks.Add(task);

            return View("_SuccessfulCreatedTask");
        }

        [HttpGet]
        public IActionResult AddSubTask(string error)
        {
            ViewBag.Error = error == null ? "" : error;
            SubTask model = new SubTask();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddSubTask(SubTask model)
        {
            if (Db.Tasks.Where(x => x.Title == model.TaskName && x.Status != Status.Done).Count() == 0)
            {
                return RedirectToAction("AddSubTask", new { error = "There is no task with name like that"});
            }

            SubTask subTask = new SubTask()
            {
                Title = model.Title,
                Description = model.Description,
                Status = Status.NotDone,
                TaskName = model.TaskName
            };
            
            foreach (var task in Db.Tasks)
            {
                if (task.Title == subTask.TaskName)
                    task.SubTask.Add(subTask);
            }
            return View("_SuccessfulCreatedTask");
        }

    }
}