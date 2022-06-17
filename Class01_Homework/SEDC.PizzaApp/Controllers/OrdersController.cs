using SEDC.PizzaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace SEDC.PizzaApp.Controllers
{
    public class OrdersController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetOrders()
        {
            List<Orders> dbOrders = (List<Orders>)OrdersDb.Orders;
            return View(dbOrders);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }
            Orders? orders = OrdersDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orders == null)
            {
                return RedirectToAction("Empty");
            }
            return View(orders);
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult GetJson()
        {
            Orders orders = new Orders()
            {
                Id = 1,
                NameOfOrder = "Peperoni"
            };
            new Orders()
            {
                Id = 2,
                NameOfOrder = "Capri"
            };

            return new JsonResult(orders);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
