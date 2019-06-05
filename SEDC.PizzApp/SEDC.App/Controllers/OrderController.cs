using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.App.Models.DomainModels;
using SEDC.App.Models.ViewModels;

namespace SEDC.App.Controllers
{
    //[Route("port/orders/[Action]")]
    public class OrderController : Controller
    {
        private List<Order> _ordersDb;

        public OrderController()
        {
            User bob = new User()
            {
                Id = 12,
                FirstName = "Bobo",
                LastName = "Bobsky",
                Address = "Bob's Street",
                Phone = 123123
            };

            User jill = new User()
            {
                FirstName = "Jill",
                LastName = "Wayne",
                Address = "Jill Street",
                Phone = 08006546345
            };

            Pizza kapri = new Pizza() { Id = 1, Name = "Kapri", Size = "Jumbo", Price = 10.5 };
            Pizza toskana = new Pizza() { Id = 2, Name = "Toskana", Size = "Sredna", Price = 7.5 };
            Pizza peproni = new Pizza() { Id = 3, Name = "Peperoni", Size = "Jumbo", Price = 12.5 };
            

            _ordersDb = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = bob,
                    Pizza = kapri,
                },
                new Order()
                {
                    Id = 2,
                    User = bob,
                    Pizza = toskana,
                },
                new Order()
                {
                    Id = 3,
                    User = jill,
                    Pizza = peproni,
                }
            };
        }

        [Route("Orders")]
        public IActionResult Index()
        {
            //ViewData.Add("Title", "Welcome to the orders page");
            ViewBag.Title = "Welcome to the orders page";

            List<OrdersViewModel> orders = new List<OrdersViewModel>();

            foreach (var order in _ordersDb)
            {
                orders.Add(new OrdersViewModel
                {
                    Pizza = order.Pizza.Name,
                    Price = order.Pizza.Price,
                    PersonName = $"{order.User.FirstName} {order.User.LastName}"
                });
            }


            return View(orders);
        }

        public IActionResult Details(int? id)
        {
            //ViewData.Add("Title", "These are your orders: ");

            try
            {
                Order order = _ordersDb.Find(x => x.Id == id);
                ViewBag.Title = $"This is your order id: {order.Id}";

                if (order != null)
                    return View(order);
            }
            catch
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}