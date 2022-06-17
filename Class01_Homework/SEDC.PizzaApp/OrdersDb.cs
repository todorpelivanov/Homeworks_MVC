namespace SEDC.PizzaApp.Models
{
    public static class OrdersDb
    {

        public static List<Orders> Orders = new List<Orders>
        { new Orders()
        {
            Id = 1,
            NameOfOrder = "Peperoni"
        },
            new Orders()
            {
                Id = 2,
                NameOfOrder = "Capri"
            }
        };
    }
}