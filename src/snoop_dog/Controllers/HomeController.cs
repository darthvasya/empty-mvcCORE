using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using snoop_dog.Models;

namespace snoop_dog.Controllers
{
    public class HomeController : Controller
    {
        MobileContext mobileContext;

        public HomeController(MobileContext context)
        {
            this.mobileContext = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(this.mobileContext.Phones.ToList());
        }

        // GET: /<controller>/Buy/:id
        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.PhoneId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Order order)
        {
            mobileContext.Orders.Add(order);
            mobileContext.SaveChanges();
            return "Thanks, " + order.User + ", for the bid!";
        }
    }
}
