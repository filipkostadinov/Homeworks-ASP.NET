using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.TaskApp.Domain;
using ToDo.TaskApp.Services.Services;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;       

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("UserStatistics")]
        public IActionResult UserStatistic()
        {
            var users = _userService.GetAll();           
            return View(MappingToUserViewModels(users));
        }

        public static List<UserViewModel> MappingToUserViewModels(List<User> users)
        {
            List<UserViewModel> viewModelUsers = new List<UserViewModel>();
            foreach (var user in users)
            {
                viewModelUsers.Add(
                    new UserViewModel()
                    {
                        Id = user.Id,
                        Name = $"{user.FirstName} {user.LastName}",
                        Age = user.Age,
                        AverageFreeTime = user.AverageFreeTime,
                        Tasks = user.Tasks.Select(t => new { ShortcutTask = $"{t.Title} - {t.Status}" }).Select(x => x.ShortcutTask).ToList()
                    });
            }

            return viewModelUsers;
        }
    }
}