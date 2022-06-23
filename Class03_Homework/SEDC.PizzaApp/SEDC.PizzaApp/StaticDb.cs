using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        //public static int UserId = 2;
        public static List<Pizza> Pizzas = new List<Pizza> {
        new Pizza()
        {
            Id = 1,
            PizzaSize = Models.Enums.PizzaSize.Normal,
            Name = "Capri",
            Price = 300,
            IsOnPromotion = true
        },
        new Pizza()
        {
            Id = 2,
            Name = "Pepperoni",
            PizzaSize = Models.Enums.PizzaSize.Family,
            Price = 400,
            IsOnPromotion = false
        }
    };
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName ="Tanja",
                LastName = "Stojanovska",
                PhoneNumber = "5253252322"
            },
             new User
            {
                Id = 2,
                FirstName ="Stefan",
                LastName = "Trajkov",
                PhoneNumber = "78979879"
            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(),
                User = Users.First(x => x.Id == 2),
                UserAdress = "Partizanska10",
                PaymentMethod = PaymentMethod.Cash
            },
            new Order
            {
                Id = 2,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(x => x.Id == 2),
                User = Users.First(x => x.Id == 1),
                UserAdress = "Partizanska101",
                PaymentMethod = PaymentMethod.Card
            }
        };
    }
}
