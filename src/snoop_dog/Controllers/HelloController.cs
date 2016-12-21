using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using snoop_dog.Models;

namespace snoop_dog.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public JsonResult Index(int id)
        {
            var phone = new Phone { Id = id, Company = "ASUS", Name = "Max", Price = 520 };
            return Json(phone);
        }
    }
}
