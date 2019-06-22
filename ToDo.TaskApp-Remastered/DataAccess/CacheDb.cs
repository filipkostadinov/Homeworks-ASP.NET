using System;
using System.Collections.Generic;
using System.Text;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.DataAccess
{
    public static class CacheDb
    {
        public static List<ToDoTask> Tasks;
        public static List<User> Users;
        public static List<SubTask> SubTasks;
        public static int TaskId;
        public static int UserId;
        public static int SubTaskId;

        static CacheDb()
        {
            SubTasks = new List<SubTask>()
            {
                new SubTask() { Id = 1 ,Title = "CSS file", Description = "Link css file", Status = Status.NotDone, ToDoTaskId = 1 },
                new SubTask() { Id = 2, Title = "Black Navbar", Description = "Navbar color should be black", Status = Status.NotDone, ToDoTaskId = 2 },
                new SubTask() { Id = 3, Title = "Functions to buttons", Description = "Add event listeners to the buttons", Status = Status.Done, ToDoTaskId = 3 },
                new SubTask() { Id = 4 ,Title = "Id not allows null", Description = "Id column not allows null", Status = Status.Done, ToDoTaskId = 4 }
            };
            Tasks = new List<ToDoTask>()
            {
                    new ToDoTask()
                {
                    Id = 1,
                    Title = "Html structure",
                    Description = "Create html layout with header,nav, section, article, aside, footer",
                    Priority = Priority.Important,
                    Status = Status.NotDone,
                    TypeOfTask = TypeOfTask.Work,
                    SubTask = { SubTasks[0]}
                },
                    new ToDoTask()
                {
                    Id = 2,
                    Title = "Design",
                    Description = "Create css file to beautify the design",
                    Priority = Priority.MeduimImportance,
                    Status = Status.NotDone,
                    TypeOfTask = TypeOfTask.Hobby,
                    SubTask = { SubTasks[1]}
                },
                    new ToDoTask()
                {
                    Id = 3,
                    Title = "JavaScript",
                    Description = "Create JavaScript file and give some moves to the page",
                    Priority = Priority.Important,
                    Status = Status.Done,
                    TypeOfTask = TypeOfTask.Work,
                    SubTask = { SubTasks[2]}
                },
                    new ToDoTask()
                {
                    Id = 4,
                    Title = "Database",
                    Description = "Create login and register form and use database",
                    Priority = Priority.Important,
                    Status = Status.InProgress,
                    TypeOfTask = TypeOfTask.Personal,
                    SubTask = { SubTasks[3]}
                }
            };

            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Age = 20,
                    AverageFreeTime = 30,
                    Tasks = { Tasks[0], Tasks[2] }
                },
                new User()
                {
                    Id = 2,
                    FirstName = "John",
                    LastName = "Johnson",
                    Age = 23,
                    AverageFreeTime = 30,
                    Tasks = { Tasks[3] }
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Will",
                    LastName = "Wilson",
                    Age = 21,
                    AverageFreeTime = 30,
                    Tasks = { Tasks[0], Tasks[1], Tasks[2], Tasks[3] }
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Peter",
                    LastName = "Peterson",
                    Age = 24,
                    AverageFreeTime = 30,
                    Tasks = { Tasks[0], Tasks[1], Tasks[2] }
                }
            };

            TaskId = 4;
            UserId = 4;
            SubTaskId = 4;
        }
    }
}
