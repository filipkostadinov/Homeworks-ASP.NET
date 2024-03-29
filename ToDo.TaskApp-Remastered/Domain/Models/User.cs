﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.TaskApp.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AverageFreeTime { get; set; }
        public List<ToDoTask> Tasks { get; set; } = new List<ToDoTask>();

    }
}
