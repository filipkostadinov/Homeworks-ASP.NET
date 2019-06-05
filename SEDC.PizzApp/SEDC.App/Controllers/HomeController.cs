using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.App.Models.DomainModels;

namespace SEDC.App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }       
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Nothing()
        {
            return new EmptyResult();
        }

        public IActionResult BackToHome()
        {
            return RedirectToAction("Index");
        }

        public IActionResult JsonData()
        {
            object order = new { OrderId = 12, OrderName = "Zdrave" };
            return new JsonResult(order);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Promotion()
        {
            Pizza kapri = new Pizza() { Id = 1, Name = "Kapri", Size = "Jumbo", Price = 8.5 };

            return View(kapri);
        }
    }
}