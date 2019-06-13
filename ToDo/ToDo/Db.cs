using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models.DomainModels;
using ToDo.Models.Enums;

namespace ToDo
{
    public static class Db
    {
        public static List<ToDoTask> Tasks;
        public static List<User> Users;
        public static int TaskId;
        public static int UserId;

        static Db()
        {
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
                    SubTask = { new SubTask() { Title = "CSS file", Description = "Link css file", Status = Status.NotDone } }
                },
                    new ToDoTask()
                {
                    Id = 2,
                    Title = "Design",
                    Description = "Create css file to beautify the design",
                    Priority = Priority.MeduimImportance,
                    Status = Status.NotDone,
                    TypeOfTask = TypeOfTask.Hobby,
                    SubTask = { new SubTask() { Title = "Black Navbar", Description = "Navbar color should be black", Status = Status.NotDone } }
                },
                    new ToDoTask()
                {
                    Id = 3,
                    Title = "JavaScript",
                    Description = "Create JavaScript file and give some moves to the page",
                    Priority = Priority.Important,
                    Status = Status.Done,
                    TypeOfTask = TypeOfTask.Work,
                    SubTask = {new SubTask() { Title = "Functions to buttons", Description = "Add event listeners to the buttons", Status = Status.Done } }
                },
                    new ToDoTask()
                {
                    Id = 4,
                    Title = "Database",
                    Description = "Create login and register form and use database",
                    Priority = Priority.Important,
                    Status = Status.InProgress,
                    TypeOfTask = TypeOfTask.Personal,
                    SubTask = 
                    {
                        new SubTask() { Title = "Id not allows null", Description = "Id column not allows null", Status = Status.Done }
                    }
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
        }
    }
}
