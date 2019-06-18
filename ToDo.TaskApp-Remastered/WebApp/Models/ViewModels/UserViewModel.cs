using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double AverageFreeTime { get; set; }
        public IEnumerable<string> Tasks { get; set; }
    }
}
