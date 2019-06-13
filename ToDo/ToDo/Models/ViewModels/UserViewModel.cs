using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models.DomainModels;

namespace ToDo.Models.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double AverageFreeTime { get; set; }
        public IEnumerable<string> Tasks { get; set; }
    }
}
