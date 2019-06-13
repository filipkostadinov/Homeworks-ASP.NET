using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models.Enums
{
    public enum Status
    {        
        Done,
        [Display(Name = "Not Done")]
        NotDone,
        [Display(Name = "In Progress")]
        InProgress
    }
}
