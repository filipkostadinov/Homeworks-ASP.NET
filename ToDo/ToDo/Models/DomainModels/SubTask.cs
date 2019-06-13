using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models.Enums;

namespace ToDo.Models.DomainModels
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
