using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models.DomainModels;
using ToDo.Models.Enums;

namespace ToDo.Models.ViewModels
{
    public class TaskViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        [Display(Name = "Type Of Task")]
        public TypeOfTask TypeOfTask { get; set; }
        public IEnumerable<string> SubTask { get; set; }
    }
}
