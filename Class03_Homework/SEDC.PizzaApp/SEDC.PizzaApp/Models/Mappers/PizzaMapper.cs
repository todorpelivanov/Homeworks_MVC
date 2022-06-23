using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToPizzaViewModelMapper(this Pizza dbPizza)
        {
            return new PizzaViewModel()
            {
                Id = dbPizza.Id,
                Name = dbPizza.Name,
                Price = SetPizzaPrice(dbPizza),
                PizzaSize = dbPizza.PizzaSize,
            };
        }

        public static decimal SetPizzaPrice(Pizza pizza)
        {
            if (pizza.HasExtras)
            {
                return pizza.Price += 10;
            }
            else return pizza.Price = pizza.Price;
        }
    }
}
