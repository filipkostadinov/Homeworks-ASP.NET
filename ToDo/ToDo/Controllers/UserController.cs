using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models.ViewModels;

namespace ToDo.Controllers
{
    public class UserController : Controller
    {
        public List<UserViewModel> Users = new List<UserViewModel>();

        public UserController()
        {
            foreach (var user in Db.Users)
            {
                Users.Add(
                    new UserViewModel()
                    {
                        Name = $"{user.FirstName} {user.LastName}",
                        Age = user.Age,
                        AverageFreeTime = user.AverageFreeTime,
                        Tasks = user.Tasks.Select(t => new { ShortcutTask = $"{t.Title} - {t.Status}" }).Select(x => x.ShortcutTask)
                    });
            }
        }

        [HttpGet("UserStatistics")]
        public IActionResult UserStatistic()
        {
            List<UserViewModel> users = new List<UserViewModel>();
            users = Users;
            return View(users);
        }
    }
}