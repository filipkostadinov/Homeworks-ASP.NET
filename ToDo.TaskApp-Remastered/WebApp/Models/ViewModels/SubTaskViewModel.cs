using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.TaskApp.Domain;

namespace WebApp.Models.ViewModels
{
    public class SubTaskViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public int ToDoTaskId { get; set; }
    }
}
