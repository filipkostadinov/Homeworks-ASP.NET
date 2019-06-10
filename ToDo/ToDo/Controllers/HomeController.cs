using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models.DomainModels;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        private List<ToDoTask> _tasksDb;
        private List<User> _usersDb;

        public HomeController()
        {
            #region CreatingTasks
            ToDoTask task1 = new ToDoTask()
            {
                Title = "Html structure",
                Description = "Create html layout with header,nav, section, article, aside, footer",
                Priority = 1,
                Status = "Not Done",
                TypeOfTask = TypeOfTask.Work,
                SubTask = new List<ToDoTask>() { new ToDoTask() { Title = "CSS file", Description = "Link css file", Status = "Not done" } }
            };

            ToDoTask task2 = new ToDoTask()
            {
                Title = "Design",
                Description = "Create css file to beautify the design",
                Priority = 2,
                Status = "Not Done",
                TypeOfTask = TypeOfTask.Hobby,
                SubTask = new List<ToDoTask>() { new ToDoTask() { Title = "Black Navbar", Description = "Navbar color should be black", Status = "Not done" } }
            };

            ToDoTask task3 = new ToDoTask()
            {
                Title = "JavaScript",
                Description = "Create JavaScript file and give some moves to the page",
                Priority = 1,
                Status = "Done",
                TypeOfTask = TypeOfTask.Work,
                SubTask = new List<ToDoTask>() { new ToDoTask() { Title = "Functions to buttons", Description = "Add event listeners to the buttons", Status = "Done" } }
            };

            ToDoTask task4 = new ToDoTask()
            {
                Title = "Database",
                Description = "Create login and register form and use database",
                Priority = 1,
                Status = "In Progress",
                TypeOfTask = TypeOfTask.Personal,
                SubTask = new List<ToDoTask>() { new ToDoTask() { Title = "Id not allows null", Description = "Id column not allows null", Status = "Done" } }
            };
            #endregion

            _tasksDb = new List<ToDoTask>() { task1, task2, task3, task4 };

            #region CreatingUsers
            User user1 = new User()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 20,
                AverageFreeTime = 30,
                Tasks = { task1, task3 }
            };
            User user2 = new User()
            {
                FirstName = "John",
                LastName = "Johnson",
                Age = 23,
                AverageFreeTime = 30,
                Tasks = { task4 }
            };
            User user3 = new User()
            {
                FirstName = "Will",
                LastName = "Wilson",
                Age = 21,
                AverageFreeTime = 30,
                Tasks = { task1, task2, task3, task4 }
            };
            User user4 = new User()
            {
                FirstName = "Peter",
                LastName = "Peterson",
                Age = 24,
                AverageFreeTime = 30,
                Tasks = { task1, task2, task3 }
            };
            #endregion

            _usersDb = new List<User>() { user1, user2, user3, user4 };
        }
        public IActionResult Index()
        {
            IEnumerable<ToDoTask> allNotDoneTasks = new List<ToDoTask>();
            allNotDoneTasks = _tasksDb.Where(t => t.Status != "Done");
            return View(allNotDoneTasks);
        }
        [HttpGet("NotDone")]
        public IActionResult NotDone()
        {
            IEnumerable<ToDoTask> notDoneTasks = new List<ToDoTask>();
            notDoneTasks = _tasksDb.Where(t => t.Status == "Not Done");
            return View(notDoneTasks);
        }
        [HttpGet("InProgress")]
        public IActionResult Progress()
        {
            IEnumerable<ToDoTask> inProgressTasks = new List<ToDoTask>();
            inProgressTasks = _tasksDb.Where(t => t.Status == "In Progress");
            return View(inProgressTasks);
        }
        [HttpGet("AllDoneTasks")]
        public IActionResult AllDoneTasks()
        {
            IEnumerable<ToDoTask> finishedTasks = new List<ToDoTask>();
            finishedTasks = _tasksDb.Where(t => t.Status == "Done");
            return View(finishedTasks);
        }
        [HttpGet("UserStatistics")]
        public IActionResult UserStatistic()
        {
            List<User> users = new List<User>();
            users = _usersDb;
            return View(users);
        }
    }
}