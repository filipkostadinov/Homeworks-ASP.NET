using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToDo.TaskApp.Domain
{
    public enum Priority
    {
        Important = 1,
        [Display(Name = "Medium Importance")]
        MeduimImportance = 2,
        [Display(Name = "Not Important")]
        NotImportant = 3
    }
}
