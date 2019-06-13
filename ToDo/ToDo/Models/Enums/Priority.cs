using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models.Enums
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
