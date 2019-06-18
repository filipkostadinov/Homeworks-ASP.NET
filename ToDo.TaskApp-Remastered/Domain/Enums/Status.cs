using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDo.TaskApp.Domain
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
