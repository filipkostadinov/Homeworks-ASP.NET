using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models.DomainModels
{
    public class ToDoTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public byte Priority { get; set; }
        public string Status { get; set; }
        public TypeOfTask TypeOfTask { get; set; }
        public List<ToDoTask> SubTask { get; set; }

    }
}
