using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDo.TaskApp.Domain
{
    public class SubTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }
    }
}
