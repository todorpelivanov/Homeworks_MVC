using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
    public static class OrdersDb
    {
        public static List<Orders> Orders = new List<Orders> {
        new Orders()
        {
            Id =1,
            Price = 400,
            RecipientPhoneNumber = 077518482,
            RecipientName = "Mila",
            RecipientAdress = "Ulica Vardar br.11",
            NameOfOrder = "Capri"


        },
        new Orders()
        {
            Id =2,
            Price = 500,
            RecipientPhoneNumber = 070277778,
            RecipientName = "Monika",
            RecipientAdress = "Ulica 2 br. 55",
            NameOfOrder = "Pepperoni"

        }
        };
    }
}