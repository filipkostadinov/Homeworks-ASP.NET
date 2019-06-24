using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToDo.TaskApp.Domain
{
    public class ToDoTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public TypeOfTask TypeOfTask { get; set; }
        public List<SubTask> SubTask { get; set; } = new List<SubTask>();
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
