using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToPizzaViewModel(this Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                IsOnPromotion = pizza.IsOnPromotion,
                Name = pizza.Name,
                Price = pizza.Price
            };
        }
    }
}
