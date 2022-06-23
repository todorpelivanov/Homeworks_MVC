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
            List<Pizza> dbPizzas = StaticDb.Pizzas;

            List<PizzaViewModel> pizzaViewModels = dbPizzas.Select(x => x.ToPizzaViewModelMapper()).ToList();

            return View(pizzaViewModels);
            //return View(dbPizzas);
        }


        [HttpGet]
        public IActionResult Details([FromRoute]int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }

            Pizza? pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }

            PizzaViewModel pizzaViewModel = pizza.ToPizzaViewModelMapper();
            return View(pizzaViewModel);
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
