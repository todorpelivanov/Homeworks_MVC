using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class CheeseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("JsonData")]
        public IActionResult GetJson()
        {
            Cheese cheese = new Cheese()
            {
                Id = 1,
                Name = "Kasni Porasni"
            };

            return new JsonResult(cheese);
        }
    }
}
