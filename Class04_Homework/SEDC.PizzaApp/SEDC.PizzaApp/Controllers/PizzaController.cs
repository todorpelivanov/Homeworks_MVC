using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetPizzas()
        {
            List<PizzaViewModel> dbPizzas = StaticDb.Pizzas.Select(pizza => pizza.ToPizzaViewModel()).ToList();
            return View(dbPizzas);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Error");
            }

            PizzaViewModel? pizza = StaticDb.Pizzas.Select(pizza => pizza.ToPizzaViewModel()).FirstOrDefault(x => x.Id == id);
            if(pizza == null)
            {
                //return RedirectToAction("Error");
                return View("ResourceNotFound");
            }

            return View(pizza);
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
